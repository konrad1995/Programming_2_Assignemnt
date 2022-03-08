
namespace Assignment.Forms
{
    partial class DisplayUserProfile
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
            this.TopLevel = false;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.groupBoxAge = new System.Windows.Forms.GroupBox();
            this.groupBoxNationality = new System.Windows.Forms.GroupBox();
            this.groupBoxFavColour = new System.Windows.Forms.GroupBox();
            this.groupBoxPicture = new System.Windows.Forms.GroupBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.panelFavColour = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxName.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxAge.SuspendLayout();
            this.groupBoxNationality.SuspendLayout();
            this.groupBoxFavColour.SuspendLayout();
            this.groupBoxPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxGender, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxAge, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxNationality, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFavColour, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxPicture, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(446, 661);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(446, 661);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 661);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.labelFullName);
            this.groupBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxName.Location = new System.Drawing.Point(3, 3);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(440, 49);
            this.groupBoxName.TabIndex = 0;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Full Name";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.labelGender);
            this.groupBoxGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGender.Location = new System.Drawing.Point(3, 58);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(440, 49);
            this.groupBoxGender.TabIndex = 1;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // groupBoxAge
            // 
            this.groupBoxAge.Controls.Add(this.labelDate);
            this.groupBoxAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAge.Location = new System.Drawing.Point(3, 113);
            this.groupBoxAge.Name = "groupBoxAge";
            this.groupBoxAge.Size = new System.Drawing.Size(440, 49);
            this.groupBoxAge.TabIndex = 2;
            this.groupBoxAge.TabStop = false;
            this.groupBoxAge.Text = "Date of Birth/ Age";
            // 
            // groupBoxNationality
            // 
            this.groupBoxNationality.Controls.Add(this.labelNationality);
            this.groupBoxNationality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNationality.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxNationality.Location = new System.Drawing.Point(3, 168);
            this.groupBoxNationality.Name = "groupBoxNationality";
            this.groupBoxNationality.Size = new System.Drawing.Size(440, 49);
            this.groupBoxNationality.TabIndex = 3;
            this.groupBoxNationality.TabStop = false;
            this.groupBoxNationality.Text = "Nationality";
            // 
            // groupBoxFavColour
            // 
            this.groupBoxFavColour.Controls.Add(this.panelFavColour);
            this.groupBoxFavColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFavColour.Location = new System.Drawing.Point(3, 223);
            this.groupBoxFavColour.Name = "groupBoxFavColour";
            this.groupBoxFavColour.Size = new System.Drawing.Size(440, 49);
            this.groupBoxFavColour.TabIndex = 4;
            this.groupBoxFavColour.TabStop = false;
            this.groupBoxFavColour.Text = "Favourite Colour";
            // 
            // groupBoxPicture
            // 
            this.groupBoxPicture.Controls.Add(this.pictureBox1);
            this.groupBoxPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPicture.Location = new System.Drawing.Point(3, 278);
            this.groupBoxPicture.Name = "groupBoxPicture";
            this.tableLayoutPanel1.SetRowSpan(this.groupBoxPicture, 2);
            this.groupBoxPicture.Size = new System.Drawing.Size(440, 380);
            this.groupBoxPicture.TabIndex = 5;
            this.groupBoxPicture.TabStop = false;
            this.groupBoxPicture.Text = "Profile Picture";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(9, 16);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(48, 18);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "Name";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(6, 16);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(57, 18);
            this.labelGender.TabIndex = 0;
            this.labelGender.Text = "Gender";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(9, 16);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(68, 18);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date/Age";
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationality.Location = new System.Drawing.Point(6, 16);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(76, 18);
            this.labelNationality.TabIndex = 0;
            this.labelNationality.Text = "Nationality";
            // 
            // panelFavColour
            // 
            this.panelFavColour.Location = new System.Drawing.Point(12, 19);
            this.panelFavColour.Name = "panelFavColour";
            this.panelFavColour.Size = new System.Drawing.Size(419, 24);
            this.panelFavColour.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DisplayUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DisplayUserProfile";
            this.Text = "Form1";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxAge.ResumeLayout(false);
            this.groupBoxAge.PerformLayout();
            this.groupBoxNationality.ResumeLayout(false);
            this.groupBoxNationality.PerformLayout();
            this.groupBoxFavColour.ResumeLayout(false);
            this.groupBoxPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.GroupBox groupBoxAge;
        private System.Windows.Forms.GroupBox groupBoxNationality;
        private System.Windows.Forms.GroupBox groupBoxFavColour;
        private System.Windows.Forms.GroupBox groupBoxPicture;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Panel panelFavColour;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}