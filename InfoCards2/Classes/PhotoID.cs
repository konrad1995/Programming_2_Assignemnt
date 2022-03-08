using Assignment.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Classes
{
    public class PhotoID : IInfoCard
    {
        DisplayPhotoID displayPhotoID;
       
        readonly string _category = "Photo ID";
        string _infoCardName;
        string _photoBase64;
        string _dataString;


        public PhotoID()
        {
            Name = "";
        }
        public PhotoID(string name, string photo)
        {
            Name = name;
            Photo = photo;
        }
      
        public string Name
        {
            get { return _infoCardName; }
            set { _infoCardName = value; }
        }

        public string Category
        {
            get { return _category; }
        }

        public string Photo
        {
            get { return _photoBase64; }
            set { _photoBase64 = value; }
        }

        public void CloseDisplay()
        {
            displayPhotoID.Close();
            displayPhotoID.Dispose();
        }

        public void DisplayData(Panel displayPanel)
        {
            displayPhotoID = new DisplayPhotoID(Name, Photo);
            displayPhotoID.ShowDialog();
        }

        public bool EditData()
        {
            PhotoIDForm form = new PhotoIDForm(Name, Photo);

            if (form.ShowDialog() == DialogResult.OK)
            {
                Name = form.GetPhotoID.Name;
                Photo = form.GetPhotoID.Photo;
                return true;
            }
            return false;
        }

        public string GetDataAsString()
        {
            _dataString = _category + "|" + Name + "|" + _photoBase64;
            return _dataString;
        }
    }
}
