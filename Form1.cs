using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encoder = System.Drawing.Imaging.Encoder;

namespace filigraneur
{
    public partial class Form1 : Form
    {
        Image filigrane1,filigrane2,image;
        String image_filename;
        bool image_selected = false,filigrane_selected=false;
        int filigrane_height = 164, filegrane_guard = 28;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_choose_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image files (*.png, *.jpg)|*.png;*.jpg|All files|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = img;
                image = img;
                image_filename=selectedFileName;
                image_selected = true;
                enable_filigraner_button();
            }
        }

        private void button_filigraner_Click(object sender, EventArgs e)
        {
            float scale_factor = (float)filigrane_height / (float)filigrane1.Height;
            int filigrane_width = (int)((float)filigrane1.Width * scale_factor);

            Bitmap resized_filigrane1 = ResizeImage(filigrane1, filigrane_width, filigrane_height);
            
            using (Graphics g = Graphics.FromImage(image))
            {
                //g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                if (filigrane1 != null)
                    g.DrawImage(resized_filigrane1, image.Width - filigrane_width - filegrane_guard, image.Height - filigrane_height - filegrane_guard, resized_filigrane1.Width, resized_filigrane1.Height);
                if(filigrane2 != null)
                    g.DrawImage(filigrane2  , image.Width - filigrane2.Width - filegrane_guard, image.Height - filigrane2.Height - filegrane_guard, filigrane2.Width, filigrane2.Height);
            }
            pictureBox1.Image = image;

            string newFileName = Path.Combine(Path.GetDirectoryName(image_filename), (textBox1.Text + Path.GetFileName(image_filename)));

            //set saving quality
            var encoder = ImageCodecInfo.GetImageEncoders()
                            .First(c => c.FormatID == ImageFormat.Jpeg.Guid);
            var encParams = new EncoderParameters(1);
            encParams.Param[0] = new EncoderParameter(Encoder.Quality, (long)trackBar1.Value);
            image.Save(newFileName, encoder, encParams);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image files (*.png, *.jpg)|*.png;*.jpg|All files|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                //Modify image
                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox_filigrane2.Image = img;
                filigrane2 = img;
                filigrane_selected = true;
                enable_filigraner_button();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int filigrane_height = 164, filegrane_guard = 28;
            float scale_factor = (float)filigrane_height / (float)filigrane1.Height;
            int filigrane_width = (int)((float)filigrane1.Width * scale_factor);

            Bitmap resized_filigrane1 = ResizeImage(filigrane1, filigrane_width, filigrane_height);

            using (Graphics g = Graphics.FromImage(image))
            {
                //g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    //wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    if (filigrane1 != null)
                        g.DrawImage(resized_filigrane1, image.Width - filigrane_width - filegrane_guard, image.Height - filigrane_height - filegrane_guard, resized_filigrane1.Width, resized_filigrane1.Height);
                    if (filigrane2 != null)
                        g.DrawImage(filigrane2, image.Width - filigrane2.Width - filegrane_guard, image.Height - filigrane2.Height - filegrane_guard, filigrane2.Width, filigrane2.Height);
                }
            }
            pictureBox1.Image = image;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = "JPG Quality : " + trackBar1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           multi_filigrane form = new multi_filigrane(Path.GetDirectoryName(image_filename),textBox1.Text, (long)trackBar1.Value, filigrane1,filigrane2);
            form.ShowDialog();
        }

        private void button_choose_filigrane_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image files (*.png, *.jpg)|*.png;*.jpg|All files|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                //Modify image
                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox_filigrane1.Image = img;
                filigrane1 = img;
                filigrane_selected = true;
                enable_filigraner_button();
            }
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public void enable_filigraner_button()
        {
            if(image_selected && filigrane_selected)
            {
                button2.Enabled = true;
                button_filigraner.Enabled = true;
                button3.Enabled = true;
            }

        }
    }
}
