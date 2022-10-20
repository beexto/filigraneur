using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class multi_filigrane : Form
    {
        Image filigrane1, filigrane2;
        int filigrane_height = 164, filegrane_guard = 28;
        String path,prefix;
        int image_count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
                button_stop.Enabled = true;
                button_start.Enabled = false;
            }
            button1.Enabled = true;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
                button_stop.Enabled = false;
                button_start.Enabled = true;
            }
        }

        public multi_filigrane(String _path,String _prefix,long quality,Image _filigrane1, Image _filigrane2, int _filigrane_height = 164,int _filegrane_guard = 28)
        {
            InitializeComponent();
            this.filigrane1 = _filigrane1;
            this.filigrane2 = _filigrane2;
            filegrane_guard = _filegrane_guard;
            filigrane_height = _filigrane_height;
            path = _path;
            prefix = _prefix;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

        }   

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            //find images
            var imageFiles = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
             .Where(s => s.EndsWith(".png") || s.EndsWith(".jpg"));
            //count and update ui
            image_count = imageFiles.ToList<string>().Count;
            

            int filigrane_height = 164, filegrane_guard = 28;
            float scale_factor = (float)filigrane_height / (float)filigrane1.Height;
            int filigrane_width = (int)((float)filigrane1.Width * scale_factor);

            Bitmap resized_filigrane1 = Form1.ResizeImage(filigrane1, filigrane_width, filigrane_height);

            int progress = 0;
            foreach (String f in imageFiles)
            {
                using (Image image = Image.FromFile(f))
                {
                    using (Graphics g = Graphics.FromImage(image))
                    {
                        //g.CompositingMode = CompositingMode.SourceCopy;
                        g.CompositingQuality = CompositingQuality.HighQuality;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                        if (filigrane1 != null)
                            g.DrawImage(resized_filigrane1, image.Width - filigrane_width - filegrane_guard, image.Height - filigrane_height - filegrane_guard, resized_filigrane1.Width, resized_filigrane1.Height);
                        if (filigrane2 != null)
                            g.DrawImage(filigrane2, image.Width - filigrane2.Width - filegrane_guard, image.Height - filigrane2.Height - filegrane_guard, filigrane2.Width, filigrane2.Height);
                    }

                    string folder_path = Path.Combine(Path.GetDirectoryName(f), "filigraned");
                    //no need to check if it exist per doc
                    Directory.CreateDirectory(folder_path);
                    string newFileName = Path.Combine(folder_path, (prefix + Path.GetFileName(f)));
                    var encoder = ImageCodecInfo.GetImageEncoders()
                            .First(c => c.FormatID == ImageFormat.Jpeg.Guid);
                    var encParams = new EncoderParameters(1);
                    encParams.Param[0] = new EncoderParameter(Encoder.Quality, 95L);
                    image.Save(newFileName, encoder, encParams);
                    progress++;
                    worker.ReportProgress(progress);

                }
            }
            
        }

        // This event handler updates the progress.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Maximum = image_count;
            label1.Text = "Image : " + e.ProgressPercentage + "/" + image_count;
            progressBar1.Value++;
        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                label_status.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                label_status.Text = "Error: " + e.Error.Message;
            }
            else
            {
                label_status.Text = "Done!";
            }
        }
    }
}
