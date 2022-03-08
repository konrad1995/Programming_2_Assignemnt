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
using Assignment.Classes;

namespace Assignment.Forms
{
    public partial class FormUserProfile : Form
    {
        public UserProfile userProfile;
        private string _base64Image;

        public FormUserProfile(string fullName, string gender, string dateOfBirth, string favColour, string base64Picture, string nationality)
        {
            if (fullName == null || gender == null || dateOfBirth == null || favColour == null || base64Picture == null || nationality == null)
            {
                InitializeComponent();
            }
            else
            {
                InitializeComponent();
                Text = fullName;
                maskedTextFullName.Text = fullName;
                SetGender(gender);
                dateTimePicker.Value = DateTime.Parse(dateOfBirth);
                panelColour.BackColor = Color.FromArgb(Int32.Parse(favColour));
                UserImage = base64Picture;
                FromBase64toImage(base64Picture);
                comboBoxNationalities.Text = nationality;

            }


        }
        public UserProfile GetUserProfile
        {
            get { return userProfile; }
        }

        public string UserImage
        {
            get{return _base64Image;}
            set { _base64Image = value; }
        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
            userProfile = new UserProfile (maskedTextFullName.Text, GetGender(), dateTimePicker.Value.ToString(), panelColour.BackColor.ToArgb().ToString().ToUpper(), _base64Image, comboBoxNationalities.Text);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        private void ButtonAddPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string _filePath = openFileDialog.FileName;
                    openFileDialog.OpenFile();
                    GetImageFromFile(_filePath);
                    FromBase64toImage(UserImage);
                    pictureBoxProfilePicture.Update();
                }
            }
          
            
        }
        public void FromBase64toImage(string base64)
        {
            byte[] _imageBytes = Convert.FromBase64String(base64);
            using (MemoryStream memoryStream = new MemoryStream(_imageBytes))
            {
                Image image = Image.FromStream(memoryStream); 
                pictureBoxProfilePicture.Image = Image.FromStream(memoryStream);    
                memoryStream.Dispose();
            }
        }
        public void GetImageFromFile(string path)
        {
            using (Image image = Image.FromFile(path))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, image.RawFormat);
                    byte[] _imageBytes = memoryStream.ToArray();
                    UserImage = Convert.ToBase64String(_imageBytes);
                    memoryStream.Dispose();
                }
            }
        }
        private void ButtonRemovePicture_Click(object sender, EventArgs e)
        {
            pictureBoxProfilePicture.Image.Dispose();
            pictureBoxProfilePicture.Update();
        }

        private void ButtonChooseColour_Click(object sender, EventArgs e)
        {
            panelColour.BackColor = GetColour();
            panelColour.Update();
        }
        public Color GetColour()
        {
            ColorDialog userColour = new ColorDialog();
            Color tempColour = Color.Transparent;
            if (userColour.ShowDialog() == DialogResult.OK)
            {
                tempColour = userColour.Color;
            }
            return tempColour;

        }
        public string GetGender()
        {
            string gender;
            if (radioButtonFemaleGender.Checked)
            {
                gender = "Female";
            }
            else if (radioButtonMaleGender.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Other";
            }
            return gender;
        }
        public void SetGender(string gender)
        {
            switch (gender)
            {
                case "Male":
                    radioButtonMaleGender.Checked = true;
                    radioButtonFemaleGender.Checked = false;
                    radioButtonOtherGender.Checked = false;
                    break;
                case "Female":
                    radioButtonFemaleGender.Checked = true;
                    radioButtonMaleGender.Checked = false;
                    radioButtonOtherGender.Checked = false;
                    break;
                case "Other":
                    radioButtonOtherGender.Checked = true;
                    radioButtonMaleGender.Checked = false;
                    radioButtonFemaleGender.Checked = false;
                    break;
            }
        }
        void TextBoxValidation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space));
        }
        private void NationalityVaildation()
        {

        }

     
    }
}
