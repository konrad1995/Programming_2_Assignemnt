using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Classes
{
    public class CreditCard : IInfoCard
    {
        DisplayCreditCard displayCreditCard;

        private string _infoCardName;
        private string _cardFullName;
        private string _cardNumber;
        private DateTime _cardExpiry;
        private DateTime _startDate;
        private string _cvc;
        private readonly string _category = "Credit Card";
        private string _dataAsString;

        public CreditCard()
        {
            Name = "";
            FullName = "";
            CardNumber = "";
            ExpiryDate = new DateTime(2001, 1, 1);
            StartDate = new DateTime(2000, 1, 1);
            CVC = "";
        }
        public CreditCard(string name, string fullName, string cardNumber, string expiry, string startDate, string cvc)
        {
            Name = name;
            FullName = fullName;
            CardNumber = cardNumber;
            ExpiryDate = DateTime.Parse(expiry);
            StartDate = DateTime.Parse(startDate);
            CVC = cvc;
        }

        public string Name
        {
            get { return _infoCardName; }
            set { _infoCardName = value; }
        }
        public string FullName
        {
            get { return _cardFullName; }
            set { _cardFullName = value; }
        }
        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }
        public DateTime ExpiryDate
        {
            get { return _cardExpiry; }
            set { _cardExpiry = value; }
        }
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        public string CVC
        {
            get { return _cvc; }
            set { _cvc = value; }
        }

        public string Category
        {
            get { return _category; }
        }


        public void CloseDisplay()
        {
            
            displayCreditCard.Close();
            displayCreditCard.Dispose();
        }

        public void DisplayData(Panel displayPanel)
        {
            displayCreditCard = new DisplayCreditCard(Name, FullName, CardNumber, ExpiryDate, StartDate, CVC);

            displayPanel.Controls.Add(displayCreditCard);
            displayCreditCard.Dock = DockStyle.Fill; 
            displayCreditCard.Show();
            
        }

        public bool EditData()
        {
            FormCreditCard creditCardForm = new FormCreditCard(Name, FullName, CardNumber, ExpiryDate, StartDate, CVC);      
            if (creditCardForm.ShowDialog() == DialogResult.OK)
            {
                Name = creditCardForm.GetCreditCard.Name;
                FullName = creditCardForm.GetCreditCard.FullName;
                CardNumber = creditCardForm.GetCreditCard.CardNumber;
                ExpiryDate = creditCardForm.GetCreditCard.ExpiryDate;
                StartDate = creditCardForm.GetCreditCard.StartDate;
                CVC = creditCardForm.GetCreditCard.CVC;

                return true;
            }
            return false;
       
        }

        public string GetDataAsString()
        {
            _dataAsString = _category + "|"
                + _infoCardName + "|"
                + _cardFullName + "|"
                + _cardNumber + "|"
                + _cardExpiry.ToString() + "|"
                + _startDate.ToString() + "|"
                + _cvc;
            return _dataAsString;
        }
        
    }
}
