using System;
using System.Drawing;
using System.Windows.Forms;
using Assignment.Classes;

namespace Assignment
{
    public partial class FormCreditCard : Form
    {
        public CreditCard creditCard;
        readonly DateTime _currentDate = DateTime.Now;
        TimeSpan _tenYearsDuration = new TimeSpan(3651, 0, 0, 0);

        public FormCreditCard(string name, string fullName, string cardNumber, DateTime expiry, DateTime startDate, string cvc)
        {
            InitializeComponent();

            textBoxInfoCard.Text = name;
            textBoxFullName.Text = fullName;
            textBoxCardNumber.Text = cardNumber;
            textBoxExpiry.Text = expiry.ToString("MM/yyyy");
            textBoxStartDate.Text = startDate.ToString("MM/yyyy");
            textBoxCVC.Text = cvc;
        }

        public CreditCard GetCreditCard
        {
            get { return creditCard; }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            bool status = false;

            try
            {
                DateTime.Parse(textBoxExpiry.Text);
                DateTime.Parse(textBoxStartDate.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Expiry/Start date is not priovided", "ArgumentNullException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Expiry/Start date has wrong format. Make sure you pass valid date.", "FormatException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = true;
            }
            if (!status)
            {
                DateTime _expiry = DateTime.Parse(textBoxExpiry.Text);
                DateTime _startDate = DateTime.Parse(textBoxStartDate.Text);

                if (_expiry <= _currentDate || TimeDiffreance(_expiry) > _tenYearsDuration)
                {
                    MessageBox.Show("Invalid Expiry Date!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.groupBoxExpiry.BackColor = Color.Red;
                    this.groupBoxStartDate.BackColor = SystemColors.Control;
                }
                else if (_startDate > _currentDate || TimeDiffreance(_startDate) > _tenYearsDuration)
                {
                    MessageBox.Show("Invalid Start Date!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.groupBoxStartDate.BackColor = Color.Red;
                    this.groupBoxExpiry.BackColor = SystemColors.Control;
                }
                else if (_expiry <= _startDate || TimeDiffreance(_expiry) > _tenYearsDuration || (TimeDiffreance(_expiry) + TimeDiffreance(_startDate)) > _tenYearsDuration)
                {
                    MessageBox.Show("Invalid Expiry or Start Date!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.groupBoxExpiry.BackColor = Color.Red;
                    this.groupBoxStartDate.BackColor = Color.Red;
                }
                else if (String.IsNullOrEmpty(textBoxFullName.Text))
                {
                    MessageBox.Show("Full name box is empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrEmpty(textBoxInfoCard.Text))
                {
                    MessageBox.Show("Info Card box is empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!textBoxCardNumber.MaskFull)
                {
                    MessageBox.Show("Your card number is in invalid format!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!textBoxCVC.MaskFull)
                {
                    MessageBox.Show("Your CVC is in invalid format!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to save your credit card details?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        creditCard = new CreditCard(textBoxInfoCard.Text, textBoxFullName.Text, textBoxCardNumber.Text, textBoxExpiry.Text, textBoxStartDate.Text, textBoxCVC.Text);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }

            }
        }
        private TimeSpan TimeDiffreance(DateTime date)
        {
            TimeSpan _timeDifference = _currentDate - date;
            if (_timeDifference < TimeSpan.Zero)
            {
                _timeDifference = date - _currentDate;
            }
            return _timeDifference;
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TbStartDate_Click(object sender, EventArgs e)
        {
            this.groupBoxStartDate.BackColor = SystemColors.Control;
        }
        private void TbExpiryDate_Click(object sender, EventArgs e)
        {
            this.groupBoxExpiry.BackColor = SystemColors.Control;
        }
        private void TextBoxValidation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space));
        }
    }
}
