
namespace Assignment
{
    partial class FormCreditCard
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxInfoCard = new System.Windows.Forms.MaskedTextBox();
            this.textBoxFullName = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxStartDate = new System.Windows.Forms.MaskedTextBox();
            this.textBoxExpiry = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCVC = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelRow4 = new System.Windows.Forms.Panel();
            this.panelRow3 = new System.Windows.Forms.Panel();
            this.groupBoxCardNumber = new System.Windows.Forms.GroupBox();
            this.groupBoxCVC = new System.Windows.Forms.GroupBox();
            this.groupBoxStartDate = new System.Windows.Forms.GroupBox();
            this.groupBoxExpiry = new System.Windows.Forms.GroupBox();
            this.panelRow2 = new System.Windows.Forms.Panel();
            this.groupBoxFullName = new System.Windows.Forms.GroupBox();
            this.panelRow1 = new System.Windows.Forms.Panel();
            this.groupBoxCardName = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel.SuspendLayout();
            this.panelRow4.SuspendLayout();
            this.panelRow3.SuspendLayout();
            this.groupBoxCardNumber.SuspendLayout();
            this.groupBoxCVC.SuspendLayout();
            this.groupBoxStartDate.SuspendLayout();
            this.groupBoxExpiry.SuspendLayout();
            this.panelRow2.SuspendLayout();
            this.groupBoxFullName.SuspendLayout();
            this.panelRow1.SuspendLayout();
            this.groupBoxCardName.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 25);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(323, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 25);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // textBoxInfoCard
            // 
            this.textBoxInfoCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfoCard.Location = new System.Drawing.Point(11, 19);
            this.textBoxInfoCard.Name = "textBoxInfoCard";
            this.textBoxInfoCard.Size = new System.Drawing.Size(369, 20);
            this.textBoxInfoCard.TabIndex = 1;
            this.textBoxInfoCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxValidation_KeyPress);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(11, 19);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(369, 20);
            this.textBoxFullName.TabIndex = 2;
            this.textBoxFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxValidation_KeyPress);
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCardNumber.Location = new System.Drawing.Point(14, 19);
            this.textBoxCardNumber.Mask = "0000-0000-0000-0000";
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(123, 20);
            this.textBoxCardNumber.TabIndex = 3;
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.AsciiOnly = true;
            this.textBoxStartDate.BeepOnError = true;
            this.textBoxStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStartDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.textBoxStartDate.Location = new System.Drawing.Point(6, 19);
            this.textBoxStartDate.Mask = "00/0000";
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(52, 20);
            this.textBoxStartDate.TabIndex = 4;
            this.textBoxStartDate.ValidatingType = typeof(System.DateTime);
            this.textBoxStartDate.Click += new System.EventHandler(this.TbStartDate_Click);
            this.textBoxStartDate.DragDrop += new System.Windows.Forms.DragEventHandler(this.TbStartDate_Click);
            this.textBoxStartDate.DragOver += new System.Windows.Forms.DragEventHandler(this.TbStartDate_Click);
            // 
            // textBoxExpiry
            // 
            this.textBoxExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExpiry.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.textBoxExpiry.Location = new System.Drawing.Point(6, 20);
            this.textBoxExpiry.Mask = "00/0000";
            this.textBoxExpiry.Name = "textBoxExpiry";
            this.textBoxExpiry.Size = new System.Drawing.Size(52, 20);
            this.textBoxExpiry.TabIndex = 5;
            this.textBoxExpiry.ValidatingType = typeof(System.DateTime);
            this.textBoxExpiry.Click += new System.EventHandler(this.TbExpiryDate_Click);
            this.textBoxExpiry.DragDrop += new System.Windows.Forms.DragEventHandler(this.TbExpiryDate_Click);
            this.textBoxExpiry.DragOver += new System.Windows.Forms.DragEventHandler(this.TbExpiryDate_Click);
            // 
            // textBoxCVC
            // 
            this.textBoxCVC.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textBoxCVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCVC.Location = new System.Drawing.Point(6, 19);
            this.textBoxCVC.Mask = "000";
            this.textBoxCVC.Name = "textBoxCVC";
            this.textBoxCVC.Size = new System.Drawing.Size(34, 20);
            this.textBoxCVC.TabIndex = 6;
            this.textBoxCVC.ValidatingType = typeof(int);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.3913F));
            this.tableLayoutPanel.Controls.Add(this.panelRow4, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.panelRow3, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.panelRow2, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.panelRow1, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(407, 237);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // panelRow4
            // 
            this.panelRow4.Controls.Add(this.buttonCancel);
            this.panelRow4.Controls.Add(this.buttonSave);
            this.panelRow4.Location = new System.Drawing.Point(3, 204);
            this.panelRow4.Name = "panelRow4";
            this.panelRow4.Size = new System.Drawing.Size(401, 30);
            this.panelRow4.TabIndex = 4;
            // 
            // panelRow3
            // 
            this.panelRow3.Controls.Add(this.groupBoxCardNumber);
            this.panelRow3.Controls.Add(this.groupBoxCVC);
            this.panelRow3.Controls.Add(this.groupBoxStartDate);
            this.panelRow3.Controls.Add(this.groupBoxExpiry);
            this.panelRow3.Location = new System.Drawing.Point(3, 137);
            this.panelRow3.Name = "panelRow3";
            this.panelRow3.Size = new System.Drawing.Size(401, 61);
            this.panelRow3.TabIndex = 3;
            // 
            // groupBoxCardNumber
            // 
            this.groupBoxCardNumber.Controls.Add(this.textBoxCardNumber);
            this.groupBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCardNumber.Location = new System.Drawing.Point(0, 4);
            this.groupBoxCardNumber.Name = "groupBoxCardNumber";
            this.groupBoxCardNumber.Size = new System.Drawing.Size(158, 54);
            this.groupBoxCardNumber.TabIndex = 3;
            this.groupBoxCardNumber.TabStop = false;
            this.groupBoxCardNumber.Text = "Credit Card Number";
            // 
            // groupBoxCVC
            // 
            this.groupBoxCVC.Controls.Add(this.textBoxCVC);
            this.groupBoxCVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCVC.Location = new System.Drawing.Point(343, 4);
            this.groupBoxCVC.Name = "groupBoxCVC";
            this.groupBoxCVC.Size = new System.Drawing.Size(54, 54);
            this.groupBoxCVC.TabIndex = 6;
            this.groupBoxCVC.TabStop = false;
            this.groupBoxCVC.Text = "CVC";
            // 
            // groupBoxStartDate
            // 
            this.groupBoxStartDate.Controls.Add(this.textBoxStartDate);
            this.groupBoxStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStartDate.Location = new System.Drawing.Point(164, 4);
            this.groupBoxStartDate.Name = "groupBoxStartDate";
            this.groupBoxStartDate.Size = new System.Drawing.Size(80, 54);
            this.groupBoxStartDate.TabIndex = 4;
            this.groupBoxStartDate.TabStop = false;
            this.groupBoxStartDate.Text = "Start Date";
            // 
            // groupBoxExpiry
            // 
            this.groupBoxExpiry.Controls.Add(this.textBoxExpiry);
            this.groupBoxExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExpiry.Location = new System.Drawing.Point(250, 4);
            this.groupBoxExpiry.Name = "groupBoxExpiry";
            this.groupBoxExpiry.Size = new System.Drawing.Size(90, 54);
            this.groupBoxExpiry.TabIndex = 5;
            this.groupBoxExpiry.TabStop = false;
            this.groupBoxExpiry.Text = "Expiry Date";
            // 
            // panelRow2
            // 
            this.panelRow2.Controls.Add(this.groupBoxFullName);
            this.panelRow2.Location = new System.Drawing.Point(3, 70);
            this.panelRow2.Name = "panelRow2";
            this.panelRow2.Size = new System.Drawing.Size(401, 61);
            this.panelRow2.TabIndex = 2;
            // 
            // groupBoxFullName
            // 
            this.groupBoxFullName.Controls.Add(this.textBoxFullName);
            this.groupBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFullName.Location = new System.Drawing.Point(3, 4);
            this.groupBoxFullName.Name = "groupBoxFullName";
            this.groupBoxFullName.Size = new System.Drawing.Size(394, 54);
            this.groupBoxFullName.TabIndex = 2;
            this.groupBoxFullName.TabStop = false;
            this.groupBoxFullName.Text = "Full Name";
            // 
            // panelRow1
            // 
            this.panelRow1.Controls.Add(this.groupBoxCardName);
            this.panelRow1.Location = new System.Drawing.Point(3, 3);
            this.panelRow1.Name = "panelRow1";
            this.panelRow1.Size = new System.Drawing.Size(401, 61);
            this.panelRow1.TabIndex = 1;
            // 
            // groupBoxCardName
            // 
            this.groupBoxCardName.Controls.Add(this.textBoxInfoCard);
            this.groupBoxCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCardName.Location = new System.Drawing.Point(3, 4);
            this.groupBoxCardName.Name = "groupBoxCardName";
            this.groupBoxCardName.Size = new System.Drawing.Size(398, 54);
            this.groupBoxCardName.TabIndex = 1;
            this.groupBoxCardName.TabStop = false;
            this.groupBoxCardName.Text = "Info Card Name";
            // 
            // FormCreditCard
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "FormCreditCard";
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelRow4.ResumeLayout(false);
            this.panelRow3.ResumeLayout(false);
            this.groupBoxCardNumber.ResumeLayout(false);
            this.groupBoxCardNumber.PerformLayout();
            this.groupBoxCVC.ResumeLayout(false);
            this.groupBoxCVC.PerformLayout();
            this.groupBoxStartDate.ResumeLayout(false);
            this.groupBoxStartDate.PerformLayout();
            this.groupBoxExpiry.ResumeLayout(false);
            this.groupBoxExpiry.PerformLayout();
            this.panelRow2.ResumeLayout(false);
            this.groupBoxFullName.ResumeLayout(false);
            this.groupBoxFullName.PerformLayout();
            this.panelRow1.ResumeLayout(false);
            this.groupBoxCardName.ResumeLayout(false);
            this.groupBoxCardName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.MaskedTextBox textBoxInfoCard;
        private System.Windows.Forms.MaskedTextBox textBoxFullName;
        private System.Windows.Forms.MaskedTextBox textBoxCardNumber;
        private System.Windows.Forms.MaskedTextBox textBoxStartDate;
        private System.Windows.Forms.MaskedTextBox textBoxExpiry;
        private System.Windows.Forms.MaskedTextBox textBoxCVC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox groupBoxCVC;
        private System.Windows.Forms.GroupBox groupBoxStartDate;
        private System.Windows.Forms.GroupBox groupBoxExpiry;
        private System.Windows.Forms.Panel panelRow4;
        private System.Windows.Forms.Panel panelRow3;
        private System.Windows.Forms.GroupBox groupBoxCardNumber;
        private System.Windows.Forms.Panel panelRow2;
        private System.Windows.Forms.GroupBox groupBoxFullName;
        private System.Windows.Forms.Panel panelRow1;
        private System.Windows.Forms.GroupBox groupBoxCardName;
    }
}