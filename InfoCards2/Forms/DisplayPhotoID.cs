using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Forms
{
    public partial class DisplayPhotoID : Form
    {
       
        public DisplayPhotoID(string name, string base64)
        {
            InitializeComponent();
            this.Text = name;
            pictureBox1.Image = FromBase64toImage(base64);

        }
        public Image FromBase64toImage(string base64)
        {
            byte[] _imageBytes = Convert.FromBase64String(base64);
            using (MemoryStream memoryStream = new MemoryStream(_imageBytes))
            {
                Image image = Image.FromStream(memoryStream);
                return Image.FromStream(memoryStream);
            }
        }
    }
}
