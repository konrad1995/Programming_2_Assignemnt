using Assignment;
using System;

namespace Assignment.Classes
{
    class InfoCardFactory : IInfoCardFactory
    {
       
        private readonly string[] _categories = new string[3] 
        { "Credit Card", 
           "Photo ID", 
           "User Profile" 
        };
   
        private readonly string[] _descriptions = new string[3]
        {
            "Store details of users Credit Cards.", 
            "Store ID Photo.", 
            "Store user profile details."
        };
        public string[] CategoriesSupported
        {
            get { return _categories; }
        }

        public IInfoCard CreateInfoCard(string initialDetails)
        {
            string[] _tempString = initialDetails.Split('|');
            if (_tempString[0] == _categories[0])
            {
                return new CreditCard(_tempString[1], _tempString[2], _tempString[3], _tempString[4], _tempString[5], _tempString[6]);
            }
            else if (_tempString[0] == _categories[1])
            {
                return new PhotoID(_tempString[1], _tempString[2]);
            }
            else
            {
                return new UserProfile(_tempString[1], _tempString[2], _tempString[3], _tempString[4], _tempString[5], _tempString[6]);
            }
        }
        public IInfoCard CreateNewInfoCard(string category)
        {
            switch (category)
            {
                case "Credit Card":
                    return new CreditCard();
                case "Photo ID":
                    return new PhotoID();
                case "User Profile":
                    return new UserProfile();
            }
            return null;
        }
        public string GetDescription(string category)
        {
            switch (category)
            {
                case "Credit Card":
                    return _descriptions[0];
                case "Photo ID":
                    return _descriptions[1];
                case "User Profile":
                    return _descriptions[2];

            }
            return null;
        }
    }
}
