using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SharpDX;
using Point = System.Drawing.Point;
using Rectangle = System.Drawing.Rectangle;

namespace SkySimulator
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private Vector3 ToBetaVector(NumericUpDown redControl, NumericUpDown greenControl, NumericUpDown blueControl)
        {
            return new Vector3((float)redControl.Value, (float)greenControl.Value, (float)blueControl.Value) * 0.000001f;
        }

        private AtmosphereSettings SettingsFromControls()
        {
            var settings = new AtmosphereSettings
                           {
                               RadiusEarth = (float)earthRadius.Value * 1000,
                               RadiusAtmosphere = (float)atmosphereRadius.Value * 1000,
                               SunIntensity = (float)sunIntensity.Value,
                               BetaR = ToBetaVector(betaRedR, betaGreenR, betaBlueR),
                               ScaleHeightR = (float)scaleHeightR.Value,
                               BetaM = ToBetaVector(betaRedM, betaGreenM, betaBlueM),
                               ScaleHeightM = (float)scaleHeightM.Value,
                               G = (float)g.Value
                           };

            return settings;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var width = (int)widthBox.Value;
            var height = (int)heightBox.Value;
            var sunAngle = MathUtil.DegreesToRadians((float)sunAngleBox.Value);

            var atmosphere = new Atmosphere(SettingsFromControls());

            var colourData = atmosphere.GetSkydome(width, height, new Vector3((float)Math.Sin(sunAngle), (float)Math.Cos(sunAngle), 0.0f));

            var bmp = new Bitmap(width, height);
            var imageData = bmp.LockBits(new Rectangle(Point.Empty, bmp.Size), ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);

            var ptr = imageData.Scan0;
            var stride = imageData.Stride;
            var size = stride * height;

            var bytes = new byte[size];

            for (var j = 0; j < height; j++)
            {
                var currentRowIndex = stride * j;
                for (var i = 0; i < width; i++)
                {
                    var index = currentRowIndex + i * 3;
                    bytes[index + 0] = colourData[i, j].B;
                    bytes[index + 1] = colourData[i, j].G;
                    bytes[index + 2] = colourData[i, j].R;
                }
            }

            Marshal.Copy(bytes, 0, ptr, size);
            bmp.UnlockBits(imageData);

            using (var resultForm = new ResultForm(width, height, bmp))
            {
                resultForm.ShowDialog();
            }
        }
    }
}
