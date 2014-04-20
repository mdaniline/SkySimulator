using System;
using System.Threading.Tasks;
using SharpDX;

namespace SkySimulator
{

    public class Atmosphere
    {
        private AtmosphereSettings settings;
        private BoundingSphere atmosphereSphere;
        private BoundingSphere earthSphere;

        public Atmosphere(AtmosphereSettings settings)
        {
            this.settings = settings;
            this.atmosphereSphere = new BoundingSphere(Vector3.Zero, settings.RadiusAtmosphere);
            this.earthSphere = new BoundingSphere(Vector3.Zero, settings.RadiusEarth);
        }

        public Color[,] GetSkydome(int width, int height, Vector3 sunDirection)
        {
            var ret = new Color[width, height];
            var position = new Vector3(0, settings.RadiusEarth + 1.0f, 0);
            Parallel.For(0, height, j=>
            {
                var y = 2 * (j + 0.5f) / (height - 1) - 1;
                for (var i = 0; i < width; i++)
                {
                    var x = 2 * (i + 0.5f) / (width - 1) - 1;
                    var z2 = y * y + x * x;
                    if (z2 <= 1)
                    {
                        var phi = Math.Atan2(y, x);
                        var theta = Math.Acos(1 - z2);

                        var direction = new Vector3((float)(Math.Sin(theta) * Math.Cos(phi)), (float)Math.Cos(theta), (float)Math.Sin(theta));

                        var colour = ComputeIncidentLight(new Ray(position, direction), ref sunDirection);

                        ret[i, j] = colour;
                    }

                }
            });
            return ret;
        }

        private bool IntersectsAtmosphere(ref Ray ray, out float t0, out float t1)
        {
            Vector3 relativeCentre;
            Vector3.Subtract(ref ray.Position, ref atmosphereSphere.Center, out relativeCentre);
            float bOverTwo = Vector3.Dot(relativeCentre, ray.Direction);
            float c = Vector3.Dot(relativeCentre, relativeCentre) - atmosphereSphere.Radius * atmosphereSphere.Radius;

            var rootSquared = bOverTwo * bOverTwo - c;
            if (MathUtil.WithinEpsilon(rootSquared, 0f))
            {
                t0 = -bOverTwo;
                t1 = -bOverTwo;
                return true;
            }
            else if (rootSquared > 0)
            {
                var root = (float)Math.Sqrt(rootSquared);;
                t0 = -bOverTwo - root;
                t1 = -bOverTwo + root;
                return true;
            }
            else
            {
                t0 = 0;
                t1 = 0;
                return false;
            }
        }

        private Color ComputeIncidentLight(Ray ray, ref Vector3 sunDirection)
        {
            const int numSamples = 16;
            const int numSamplesLight = 8;

            float t0; // Assume we start within the atmposphere
            float t1;
            if (!IntersectsAtmosphere(ref ray, out t0, out t1))
            {
                return Color.Black;
            }
            // We are within the sphere
            if (t0 < 0)
            {
                t0 = 0;
            }

            var segmentLength = (t1 - t0) / numSamples;
            var current = t0;

            var sumR = Vector3.Zero;
            var sumM = Vector3.Zero;

            var opticalDepthR = 0.0f;
            var opticalDepthM = 0.0f;

            var mu = Vector3.Dot(ray.Direction, sunDirection);
            var phaseR = 3.0f / (16 * MathUtil.Pi) * (1 + mu * mu);
            var phaseM = 3.0f / (8 * MathUtil.Pi) * ((1 - settings.G * settings.G) * (1 * mu * mu)) / ((2 + settings.G * settings.G) * (float)Math.Pow(1 + settings.G * settings.G - 2 * settings.G * mu, 1.5));

            for (var i = 0; i < numSamples; i++)
            {
                var samplePosition = ray.Position + ray.Direction * (current + 0.5f * segmentLength);
                var currentHeight = samplePosition.Length() - settings.RadiusEarth;

                // Optical depth for light
                var hr = (float)Math.Exp(-currentHeight / settings.ScaleHeightR) * segmentLength;
                var hm = (float)Math.Exp(-currentHeight / settings.ScaleHeightM) * segmentLength;
                opticalDepthR += hr;
                opticalDepthM += hm;

                var sunRay = new Ray(samplePosition, sunDirection);
                float sunRayMax;
                float sunRayMin;

                // Do not need to check as we know we are within the atmosphere now
                IntersectsAtmosphere(ref sunRay, out sunRayMin, out sunRayMax);

                var segmentLengthLight = sunRayMax / numSamplesLight;
                var currentLight = 0.0f;
                var opticalDepthLightR = 0.0f;
                var opticalDepthLightM = 0.0f;
                var useResult = true;
                for (var j = 0; j < numSamplesLight; j++)
                {
                    var samplePositionLight = sunRay.Position + sunRay.Direction * (currentLight + 0.5f * segmentLengthLight);
                    var currentHeightLight = samplePositionLight.Length() - settings.RadiusEarth;
                    if (currentHeightLight < 0)
                    {
                        useResult = false;
                        break;
                    }
                    opticalDepthLightR += (float)Math.Exp(-currentHeightLight / settings.ScaleHeightR) * segmentLengthLight;
                    opticalDepthLightM += (float)Math.Exp(-currentHeightLight / settings.ScaleHeightM) * segmentLengthLight;
                    currentLight += segmentLengthLight;
                }
                if (useResult)
                {
                    var tau = settings.BetaR * (opticalDepthR + opticalDepthLightR) + settings.BetaM * (1.1f * (opticalDepthM + opticalDepthLightM));
                    var attenuation = new Vector3((float)Math.Exp(-tau.X), (float)Math.Exp(-tau.Y), (float)Math.Exp(-tau.Z));
                    sumR += hr * attenuation;
                    sumM += hm * attenuation;
                }
                current += segmentLength;
            }

            var result = settings.SunIntensity * (sumR * phaseR * settings.BetaR + sumM * phaseM * settings.BetaM);
            return new Color(result);
        }


    }
}
