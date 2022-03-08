using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class DisplayCreditCard : Form
    {
        public DisplayCreditCard(string name, string fullName, string cardNumber, DateTime expiry, DateTime startDate, string cvc)
        {
            InitializeComponent();
            labelName.Text = name;
            labelFullName.Text = fullName;
            labelCardNumber.Text = cardNumber;
            labelExpiryDate.Text = expiry.ToString("MM/yyyy");
            labelStartDate.Text = startDate.ToString("MM/yyyy");
            labelCVC.Text = cvc;
        }
    }
}
