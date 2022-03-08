namespace Assignment.Forms
{
    partial class FormUserProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDoB = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonOtherGender = new System.Windows.Forms.RadioButton();
            this.radioButtonFemaleGender = new System.Windows.Forms.RadioButton();
            this.radioButtonMaleGender = new System.Windows.Forms.RadioButton();
            this.groupBoxNationality = new System.Windows.Forms.GroupBox();
            this.comboBoxNationalities = new System.Windows.Forms.ComboBox();
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.maskedTextFullName = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxColour = new System.Windows.Forms.GroupBox();
            this.panelColour = new System.Windows.Forms.Panel();
            this.buttonChooseColour = new System.Windows.Forms.Button();
            this.groupBoxPicture = new System.Windows.Forms.GroupBox();
            this.buttonRemovePicture = new System.Windows.Forms.Button();
            this.buttonAddPicture = new System.Windows.Forms.Button();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.panelFunctions = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.groupBoxDoB.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxNationality.SuspendLayout();
            this.groupBoxName.SuspendLayout();
            this.tableLayoutMainPanel.SuspendLayout();
            this.groupBoxColour.SuspendLayout();
            this.groupBoxPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.panelFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDoB
            // 
            this.groupBoxDoB.Controls.Add(this.dateTimePicker);
            this.groupBoxDoB.Location = new System.Drawing.Point(3, 113);
            this.groupBoxDoB.Name = "groupBoxDoB";
            this.groupBoxDoB.Size = new System.Drawing.Size(458, 49);
            this.groupBoxDoB.TabIndex = 3;
            this.groupBoxDoB.TabStop = false;
            this.groupBoxDoB.Text = "Date of Birth";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(9, 23);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(440, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonOtherGender);
            this.groupBoxGender.Controls.Add(this.radioButtonFemaleGender);
            this.groupBoxGender.Controls.Add(this.radioButtonMaleGender);
            this.groupBoxGender.Location = new System.Drawing.Point(3, 58);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(458, 49);
            this.groupBoxGender.TabIndex = 2;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // radioButtonOtherGender
            // 
            this.radioButtonOtherGender.AutoSize = true;
            this.radioButtonOtherGender.Location = new System.Drawing.Point(128, 19);
            this.radioButtonOtherGender.Name = "radioButtonOtherGender";
            this.radioButtonOtherGender.Size = new System.Drawing.Size(51, 17);
            this.radioButtonOtherGender.TabIndex = 3;
            this.radioButtonOtherGender.Text = "Other";
            this.radioButtonOtherGender.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemaleGender
            // 
            this.radioButtonFemaleGender.AutoSize = true;
            this.radioButtonFemaleGender.Location = new System.Drawing.Point(63, 19);
            this.radioButtonFemaleGender.Name = "radioButtonFemaleGender";
            this.radioButtonFemaleGender.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemaleGender.TabIndex = 2;
            this.radioButtonFemaleGender.Text = "Female";
            this.radioButtonFemaleGender.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaleGender
            // 
            this.radioButtonMaleGender.AutoSize = true;
            this.radioButtonMaleGender.Checked = true;
            this.radioButtonMaleGender.Location = new System.Drawing.Point(9, 19);
            this.radioButtonMaleGender.Name = "radioButtonMaleGender";
            this.radioButtonMaleGender.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMaleGender.TabIndex = 1;
            this.radioButtonMaleGender.TabStop = true;
            this.radioButtonMaleGender.Text = "Male";
            this.radioButtonMaleGender.UseVisualStyleBackColor = true;
            // 
            // groupBoxNationality
            // 
            this.groupBoxNationality.Controls.Add(this.comboBoxNationalities);
            this.groupBoxNationality.Location = new System.Drawing.Point(3, 168);
            this.groupBoxNationality.Name = "groupBoxNationality";
            this.groupBoxNationality.Size = new System.Drawing.Size(458, 49);
            this.groupBoxNationality.TabIndex = 4;
            this.groupBoxNationality.TabStop = false;
            this.groupBoxNationality.Text = "Nationality";
            // 
            // comboBoxNationalities
            // 
            this.comboBoxNationalities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNationalities.FormattingEnabled = true;
            this.comboBoxNationalities.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan\t",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Côte d\'Ivoire",
            "Cabo Verde",
            "Cambodia\t",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo (Congo-Brazzaville)",
            "Costa Rica\t",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Democratic Republic of the Congo",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini (fmr. \"Swaziland\")",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (formerly Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua\t",
            "Niger",
            "Nigeria",
            "North Korea",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestine State",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles\t",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.comboBoxNationalities.Location = new System.Drawing.Point(9, 22);
            this.comboBoxNationalities.Name = "comboBoxNationalities";
            this.comboBoxNationalities.Size = new System.Drawing.Size(440, 21);
            this.comboBoxNationalities.TabIndex = 6;
            this.comboBoxNationalities.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxValidation_KeyPress);
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.maskedTextFullName);
            this.groupBoxName.Location = new System.Drawing.Point(3, 3);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(458, 49);
            this.groupBoxName.TabIndex = 1;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Full Name";
            // 
            // maskedTextFullName
            // 
            this.maskedTextFullName.Location = new System.Drawing.Point(9, 19);
            this.maskedTextFullName.Name = "maskedTextFullName";
            this.maskedTextFullName.Size = new System.Drawing.Size(440, 20);
            this.maskedTextFullName.TabIndex = 1;
            this.maskedTextFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxValidation_KeyPress);
            // 
            // tableLayoutMainPanel
            // 
            this.tableLayoutMainPanel.ColumnCount = 1;
            this.tableLayoutMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMainPanel.Controls.Add(this.groupBoxNationality, 0, 3);
            this.tableLayoutMainPanel.Controls.Add(this.groupBoxDoB, 0, 2);
            this.tableLayoutMainPanel.Controls.Add(this.groupBoxName, 0, 0);
            this.tableLayoutMainPanel.Controls.Add(this.groupBoxColour, 0, 4);
            this.tableLayoutMainPanel.Controls.Add(this.groupBoxGender, 0, 1);
            this.tableLayoutMainPanel.Controls.Add(this.groupBoxPicture, 0, 5);
            this.tableLayoutMainPanel.Controls.Add(this.panelFunctions, 0, 7);
            this.tableLayoutMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMainPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMainPanel.Name = "tableLayoutMainPanel";
            this.tableLayoutMainPanel.RowCount = 8;
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMainPanel.Size = new System.Drawing.Size(464, 621);
            this.tableLayoutMainPanel.TabIndex = 0;
            // 
            // groupBoxColour
            // 
            this.groupBoxColour.Controls.Add(this.panelColour);
            this.groupBoxColour.Controls.Add(this.buttonChooseColour);
            this.groupBoxColour.Location = new System.Drawing.Point(3, 223);
            this.groupBoxColour.Name = "groupBoxColour";
            this.groupBoxColour.Size = new System.Drawing.Size(458, 49);
            this.groupBoxColour.TabIndex = 5;
            this.groupBoxColour.TabStop = false;
            this.groupBoxColour.Text = "Favourite Colour";
            // 
            // panelColour
            // 
            this.panelColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelColour.Location = new System.Drawing.Point(9, 20);
            this.panelColour.Name = "panelColour";
            this.panelColour.Size = new System.Drawing.Size(48, 23);
            this.panelColour.TabIndex = 1;
            // 
            // buttonChooseColour
            // 
            this.buttonChooseColour.Location = new System.Drawing.Point(63, 19);
            this.buttonChooseColour.Name = "buttonChooseColour";
            this.buttonChooseColour.Size = new System.Drawing.Size(386, 24);
            this.buttonChooseColour.TabIndex = 7;
            this.buttonChooseColour.Text = "Choose Colour";
            this.buttonChooseColour.UseVisualStyleBackColor = true;
            this.buttonChooseColour.Click += new System.EventHandler(this.ButtonChooseColour_Click);
            // 
            // groupBoxPicture
            // 
            this.groupBoxPicture.Controls.Add(this.buttonRemovePicture);
            this.groupBoxPicture.Controls.Add(this.buttonAddPicture);
            this.groupBoxPicture.Controls.Add(this.pictureBoxProfilePicture);
            this.groupBoxPicture.Location = new System.Drawing.Point(3, 278);
            this.groupBoxPicture.Name = "groupBoxPicture";
            this.tableLayoutMainPanel.SetRowSpan(this.groupBoxPicture, 2);
            this.groupBoxPicture.Size = new System.Drawing.Size(458, 301);
            this.groupBoxPicture.TabIndex = 6;
            this.groupBoxPicture.TabStop = false;
            this.groupBoxPicture.Text = "Profile Picture";
            // 
            // buttonRemovePicture
            // 
            this.buttonRemovePicture.Location = new System.Drawing.Point(249, 19);
            this.buttonRemovePicture.Name = "buttonRemovePicture";
            this.buttonRemovePicture.Size = new System.Drawing.Size(200, 23);
            this.buttonRemovePicture.TabIndex = 9;
            this.buttonRemovePicture.Text = "Remove Picture";
            this.buttonRemovePicture.UseVisualStyleBackColor = true;
            this.buttonRemovePicture.Click += new System.EventHandler(this.ButtonRemovePicture_Click);
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.Location = new System.Drawing.Point(9, 19);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.Size = new System.Drawing.Size(200, 23);
            this.buttonAddPicture.TabIndex = 8;
            this.buttonAddPicture.Text = "Add Picture";
            this.buttonAddPicture.UseVisualStyleBackColor = true;
            this.buttonAddPicture.Click += new System.EventHandler(this.ButtonAddPicture_Click);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(0, 55);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(458, 246);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfilePicture.TabIndex = 11;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // panelFunctions
            // 
            this.panelFunctions.Controls.Add(this.buttonCancel);
            this.panelFunctions.Controls.Add(this.buttonSave);
            this.panelFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunctions.Location = new System.Drawing.Point(3, 585);
            this.panelFunctions.Name = "panelFunctions";
            this.panelFunctions.Size = new System.Drawing.Size(458, 33);
            this.panelFunctions.TabIndex = 12;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(380, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 28);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(468, 22);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(8, 20);
            this.domainUpDown1.TabIndex = 1;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // FormUserProfile
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(464, 621);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.tableLayoutMainPanel);
            this.MaximumSize = new System.Drawing.Size(480, 660);
            this.MinimumSize = new System.Drawing.Size(480, 660);
            this.Name = "FormUserProfile";
            this.Text = "Profile Form";
            this.groupBoxDoB.ResumeLayout(false);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxNationality.ResumeLayout(false);
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.tableLayoutMainPanel.ResumeLayout(false);
            this.groupBoxColour.ResumeLayout(false);
            this.groupBoxPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.panelFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxDoB;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonOtherGender;
        private System.Windows.Forms.RadioButton radioButtonFemaleGender;
        private System.Windows.Forms.RadioButton radioButtonMaleGender;
        private System.Windows.Forms.GroupBox groupBoxNationality;
        private System.Windows.Forms.ComboBox comboBoxNationalities;
        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMainPanel;
        private System.Windows.Forms.MaskedTextBox maskedTextFullName;
        private System.Windows.Forms.GroupBox groupBoxColour;
        private System.Windows.Forms.Panel panelColour;
        private System.Windows.Forms.Button buttonChooseColour;
        private System.Windows.Forms.GroupBox groupBoxPicture;
        private System.Windows.Forms.Button buttonRemovePicture;
        private System.Windows.Forms.Button buttonAddPicture;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Panel panelFunctions;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}