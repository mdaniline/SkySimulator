using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SkySimulator
{
    public partial class ResultForm : Form
    {
        public ResultForm(int width, int height, Bitmap image)
        {
            InitializeComponent();
            this.Width = width;
            this.Height = height;
            this.canvas.Image = image;
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";

                saveFileDialog.ShowDialog();
                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    using (var stream = saveFileDialog.OpenFile())
                    {
                        switch (saveFileDialog.FilterIndex)
                        {
                            case 1:
                                canvas.Image.Save(stream, ImageFormat.Jpeg);
                                break;
                            case 2:
                                canvas.Image.Save(stream, ImageFormat.Bmp);
                                break;
                            case 3:
                                canvas.Image.Save(stream, ImageFormat.Gif);
                                break;
                            case 4:
                                canvas.Image.Save(stream, ImageFormat.Png);
                                break;
                        }

                    }
                }
            }

        }
    }
}
