using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Assignment.Classes;


namespace Assignment.Forms
{
    public partial class PhotoIDForm : Form
    {
        public PhotoID photoID;
        private string _base64Image;
       
        public PhotoIDForm(string name, string base64)
        {
            bool status = false;
            try
            {
                Convert.FromBase64String(base64);
            }
            catch (ArgumentNullException)
            {
                status = true;
            }
            catch (FormatException)
            {
                status = true;
            }
            if (!status)
            {
                InitializeComponent();
                FromBase64toImage(base64);
                this.textBoxName.Text = name;
                this.Text = name;
            }
            InitializeComponent();
        }

        public PhotoID GetPhotoID
        {
            get { return photoID; }
        }
        private void ButtonImport_Click(object sender, EventArgs e)
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

                    //Read the contents of the file into a stream
                    openFileDialog.OpenFile();
                    GetImageFromFile(_filePath);
                    FromBase64toImage(_base64Image);
                }
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
                    _base64Image = Convert.ToBase64String(_imageBytes);
                    memoryStream.Dispose();
                }
            }
        }
        public void FromBase64toImage(string base64)
        {
            byte[] _imageBytes = Convert.FromBase64String(base64);
            using (MemoryStream memoryStream = new MemoryStream(_imageBytes))
            {
                Image image = Image.FromStream(memoryStream);
                this.pictureBox.Image = Image.FromStream(memoryStream);
                memoryStream.Dispose();
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            photoID = new PhotoID(textBoxName.Text, _base64Image);

            this.DialogResult = DialogResult.OK;
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        void TextBoxValidation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space));
        }
    }
}
