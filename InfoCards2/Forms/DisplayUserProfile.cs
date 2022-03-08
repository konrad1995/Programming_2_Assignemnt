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
    public partial class DisplayUserProfile : Form
    {
        public DisplayUserProfile(string fullName, string gender, string dateOfBirth, string favColour, string userProfilePicture, string nationality)
        {
            InitializeComponent();
            labelFullName.Text = fullName;
            labelGender.Text = gender;
            labelDate.Text = dateOfBirth;
            panelFavColour.BackColor = Color.FromArgb(Int32.Parse(favColour));
            pictureBox1.Image =  FromBase64toImage(userProfilePicture);
            labelNationality.Text = nationality;

        }
      
        public Image FromBase64toImage(string base64)
        {
            byte[] _imageBytes; _imageBytes = Convert.FromBase64String(base64);
            using (MemoryStream memoryStream = new MemoryStream(_imageBytes))
            {
                return Image.FromStream(memoryStream);
            }
        }
    }
}
