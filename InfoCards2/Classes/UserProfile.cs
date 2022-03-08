using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment.Forms;

namespace Assignment.Classes
{
    public class UserProfile : IInfoCard
    {

        DisplayUserProfile display;
        private string _infoCardName;
        private readonly string _category = "User Profile";
        private string _fullName;
        private string _gender;
        private string _dateOfBirth;
        private string _age;
        private string _favColour;
        private string _nationality;
        private string _userProfilePicture;

        public UserProfile()
        {
     
        }
        public UserProfile(string fullName, string gender, string dateOfBirth, string favColour, string base64Picture, string nationality)
        {
            Name = fullName;
            FullName = fullName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            FavColour = favColour;
            UserProfilePicture = base64Picture;
            Nationality = nationality;
        }

        public string Name
        {
            get { return _infoCardName; }
            set { _infoCardName = value; }
        }
        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }

        }

        public string Category
        {
            get { return _category; }
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string FavColour
        {
            get { return _favColour; }
            set { _favColour = value; }
        }

        public string UserProfilePicture
        {
            get { return _userProfilePicture; }
            set { _userProfilePicture = value; }
        }
        public void CloseDisplay()
        {
            display.Close();
            display.Dispose();
        }

        public void DisplayData(Panel displayPanel)
        {
            display = new DisplayUserProfile(FullName, Gender, DateOfBirth, FavColour, UserProfilePicture, Nationality);

            displayPanel.Controls.Add(display);
            display.Dock = DockStyle.Fill;
            display.Show();
        }

        public bool EditData()
        {

            FormUserProfile formUserProfile = new FormUserProfile(FullName, Gender, DateOfBirth, FavColour, UserProfilePicture, Nationality);
            if (formUserProfile.ShowDialog() == DialogResult.OK)
            {
                Name = formUserProfile.GetUserProfile.Name;
                FullName = formUserProfile.GetUserProfile.FullName;
                Gender = formUserProfile.GetUserProfile.Gender;
                DateOfBirth = formUserProfile.GetUserProfile.DateOfBirth;
                FavColour = formUserProfile.GetUserProfile.FavColour;
                UserProfilePicture = formUserProfile.GetUserProfile.UserProfilePicture;
                Nationality = formUserProfile.GetUserProfile.Nationality;

                return true;
            }
            return false;
        }

        public string GetDataAsString()
        {
            string dataAsString = Category + "|" + FullName + "|" + Gender + "|" + DateOfBirth + "|" + FavColour + "|" + UserProfilePicture + "|" + Nationality;
            return dataAsString;
        }
    }
}
