using SharpDX;

namespace SkySimulator
{
    public class AtmosphereSettings
    {
        public Vector3 BetaR = new Vector3(5.5e-6f, 13.0e-6f, 22.4e-6f); // Rayleigh Coefficients
        public Vector3 BetaM = new Vector3(21e-6f); // Mie coefficients

        public float ScaleHeightR = 7994f; // Rayleigh scale height
        public float ScaleHeightM = 1200f; // Mie scale height

        public float RadiusEarth = 6360e3f;
        public float RadiusAtmosphere = 6420e3f;

        public float SunIntensity = 25f;

        public float G = 0.76f; // mean cosine
    }
}
