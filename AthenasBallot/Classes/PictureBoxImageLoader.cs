using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AthenasBallot.Classes
{
    public class PictureBoxImageLoader
    {
        public void ConfigureOpenFileDialog(OpenFileDialog ofdPhoto)
        {
            ofdPhoto.Filter = "Image(*.JPG;*PNG;*.IMG,*.JPEG)|*.JPG;*PNG;*.IMG,*.JPEG";
            ofdPhoto.RestoreDirectory = true;
        }
        public void LoadImageIntoPictureBox(PictureBox pictureBox, OpenFileDialog ofdPhoto)
        {
            pictureBox.Image = Image.FromFile(ofdPhoto.FileName);
        }
        public byte[] ConvertPictureBoxImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();

            pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.GetBuffer();
        }

    }
}
