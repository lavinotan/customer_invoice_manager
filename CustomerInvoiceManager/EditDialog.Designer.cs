namespace COMP2614Assign07
{
    partial class EditDialog
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.textBoxYTDSales = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
            this.labelNotePrompt = new System.Windows.Forms.Label();
            this.labelYTDSalesPrompt = new System.Windows.Forms.Label();
            this.labelPostalCodePrompt = new System.Windows.Forms.Label();
            this.labelProvincePrompt = new System.Windows.Forms.Label();
            this.labelCityPrompt = new System.Windows.Forms.Label();
            this.labelAddress2Prompt = new System.Windows.Forms.Label();
            this.labelAddress1Prompt = new System.Windows.Forms.Label();
            this.labelCompanyNamePrompt = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelClientCode = new System.Windows.Forms.Label();
            this.errorProviderClient = new System.Windows.Forms.ErrorProvider(this.components);
            this.maskedTextBoxClientCode = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxProvince = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.buttonShowInvoices = new System.Windows.Forms.Button();
            this.toolTipShowInvoices = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClient)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(113, 242);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(208, 20);
            this.textBoxNotes.TabIndex = 18;
            // 
            // textBoxYTDSales
            // 
            this.textBoxYTDSales.Location = new System.Drawing.Point(113, 214);
            this.textBoxYTDSales.Name = "textBoxYTDSales";
            this.textBoxYTDSales.Size = new System.Drawing.Size(100, 20);
            this.textBoxYTDSales.TabIndex = 15;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(113, 130);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(113, 102);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress2.TabIndex = 7;
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(113, 74);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress1.TabIndex = 5;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(113, 46);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompanyName.TabIndex = 3;
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(243, 216);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(78, 17);
            this.checkBoxCreditHold.TabIndex = 16;
            this.checkBoxCreditHold.Text = "Credit &Hold";
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // labelNotePrompt
            // 
            this.labelNotePrompt.AutoSize = true;
            this.labelNotePrompt.Location = new System.Drawing.Point(19, 245);
            this.labelNotePrompt.Name = "labelNotePrompt";
            this.labelNotePrompt.Size = new System.Drawing.Size(38, 13);
            this.labelNotePrompt.TabIndex = 17;
            this.labelNotePrompt.Text = "&Notes:";
            // 
            // labelYTDSalesPrompt
            // 
            this.labelYTDSalesPrompt.AutoSize = true;
            this.labelYTDSalesPrompt.Location = new System.Drawing.Point(19, 217);
            this.labelYTDSalesPrompt.Name = "labelYTDSalesPrompt";
            this.labelYTDSalesPrompt.Size = new System.Drawing.Size(61, 13);
            this.labelYTDSalesPrompt.TabIndex = 14;
            this.labelYTDSalesPrompt.Text = "&YTD Sales:";
            // 
            // labelPostalCodePrompt
            // 
            this.labelPostalCodePrompt.AutoSize = true;
            this.labelPostalCodePrompt.Location = new System.Drawing.Point(19, 189);
            this.labelPostalCodePrompt.Name = "labelPostalCodePrompt";
            this.labelPostalCodePrompt.Size = new System.Drawing.Size(67, 13);
            this.labelPostalCodePrompt.TabIndex = 12;
            this.labelPostalCodePrompt.Text = "P&ostal Code:";
            // 
            // labelProvincePrompt
            // 
            this.labelProvincePrompt.AutoSize = true;
            this.labelProvincePrompt.Location = new System.Drawing.Point(19, 161);
            this.labelProvincePrompt.Name = "labelProvincePrompt";
            this.labelProvincePrompt.Size = new System.Drawing.Size(52, 13);
            this.labelProvincePrompt.TabIndex = 10;
            this.labelProvincePrompt.Text = "&Province:";
            // 
            // labelCityPrompt
            // 
            this.labelCityPrompt.AutoSize = true;
            this.labelCityPrompt.Location = new System.Drawing.Point(19, 133);
            this.labelCityPrompt.Name = "labelCityPrompt";
            this.labelCityPrompt.Size = new System.Drawing.Size(24, 13);
            this.labelCityPrompt.TabIndex = 8;
            this.labelCityPrompt.Text = "C&ity";
            // 
            // labelAddress2Prompt
            // 
            this.labelAddress2Prompt.AutoSize = true;
            this.labelAddress2Prompt.Location = new System.Drawing.Point(19, 105);
            this.labelAddress2Prompt.Name = "labelAddress2Prompt";
            this.labelAddress2Prompt.Size = new System.Drawing.Size(57, 13);
            this.labelAddress2Prompt.TabIndex = 6;
            this.labelAddress2Prompt.Text = "A&ddress 2:";
            // 
            // labelAddress1Prompt
            // 
            this.labelAddress1Prompt.AutoSize = true;
            this.labelAddress1Prompt.Location = new System.Drawing.Point(19, 77);
            this.labelAddress1Prompt.Name = "labelAddress1Prompt";
            this.labelAddress1Prompt.Size = new System.Drawing.Size(57, 13);
            this.labelAddress1Prompt.TabIndex = 4;
            this.labelAddress1Prompt.Text = "&Address 1:";
            // 
            // labelCompanyNamePrompt
            // 
            this.labelCompanyNamePrompt.AutoSize = true;
            this.labelCompanyNamePrompt.Location = new System.Drawing.Point(19, 49);
            this.labelCompanyNamePrompt.Name = "labelCompanyNamePrompt";
            this.labelCompanyNamePrompt.Size = new System.Drawing.Size(85, 13);
            this.labelCompanyNamePrompt.TabIndex = 2;
            this.labelCompanyNamePrompt.Text = "C&ompany Name:";
            // 
            // buttonOK
            // 
            this.errorProviderClient.SetIconAlignment(this.buttonOK, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.buttonOK.Location = new System.Drawing.Point(154, 289);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "O&K";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(246, 289);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cance&l";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelClientCode
            // 
            this.labelClientCode.AutoSize = true;
            this.labelClientCode.Location = new System.Drawing.Point(19, 23);
            this.labelClientCode.Name = "labelClientCode";
            this.labelClientCode.Size = new System.Drawing.Size(58, 13);
            this.labelClientCode.TabIndex = 0;
            this.labelClientCode.Text = "&ClientCode";
            // 
            // errorProviderClient
            // 
            this.errorProviderClient.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderClient.ContainerControl = this;
            // 
            // maskedTextBoxClientCode
            // 
            this.maskedTextBoxClientCode.Location = new System.Drawing.Point(113, 20);
            this.maskedTextBoxClientCode.Mask = ">LLLLL";
            this.maskedTextBoxClientCode.Name = "maskedTextBoxClientCode";
            this.maskedTextBoxClientCode.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxClientCode.TabIndex = 1;
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Location = new System.Drawing.Point(113, 158);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProvince.TabIndex = 11;
            // 
            // maskedTextBoxPostalCode
            // 
            this.maskedTextBoxPostalCode.Location = new System.Drawing.Point(113, 186);
            this.maskedTextBoxPostalCode.Mask = ">L0L 0L0";
            this.maskedTextBoxPostalCode.Name = "maskedTextBoxPostalCode";
            this.maskedTextBoxPostalCode.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPostalCode.TabIndex = 13;
            // 
            // buttonShowInvoices
            // 
            this.buttonShowInvoices.Location = new System.Drawing.Point(22, 289);
            this.buttonShowInvoices.Name = "buttonShowInvoices";
            this.buttonShowInvoices.Size = new System.Drawing.Size(100, 23);
            this.buttonShowInvoices.TabIndex = 19;
            this.buttonShowInvoices.Text = "Show Invoices";
            this.buttonShowInvoices.UseVisualStyleBackColor = true;
            this.buttonShowInvoices.Click += new System.EventHandler(this.buttonShowInvoices_Click);
            // 
            // EditDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(341, 331);
            this.Controls.Add(this.buttonShowInvoices);
            this.Controls.Add(this.maskedTextBoxPostalCode);
            this.Controls.Add(this.comboBoxProvince);
            this.Controls.Add(this.maskedTextBoxClientCode);
            this.Controls.Add(this.labelClientCode);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.textBoxYTDSales);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddress2);
            this.Controls.Add(this.textBoxAddress1);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.checkBoxCreditHold);
            this.Controls.Add(this.labelNotePrompt);
            this.Controls.Add(this.labelYTDSalesPrompt);
            this.Controls.Add(this.labelPostalCodePrompt);
            this.Controls.Add(this.labelProvincePrompt);
            this.Controls.Add(this.labelCityPrompt);
            this.Controls.Add(this.labelAddress2Prompt);
            this.Controls.Add(this.labelAddress1Prompt);
            this.Controls.Add(this.labelCompanyNamePrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Edit Dialog";
            this.Load += new System.EventHandler(this.EditDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.TextBox textBoxYTDSales;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.CheckBox checkBoxCreditHold;
        private System.Windows.Forms.Label labelNotePrompt;
        private System.Windows.Forms.Label labelYTDSalesPrompt;
        private System.Windows.Forms.Label labelPostalCodePrompt;
        private System.Windows.Forms.Label labelProvincePrompt;
        private System.Windows.Forms.Label labelCityPrompt;
        private System.Windows.Forms.Label labelAddress2Prompt;
        private System.Windows.Forms.Label labelAddress1Prompt;
        private System.Windows.Forms.Label labelCompanyNamePrompt;
        public System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelClientCode;
        public System.Windows.Forms.ErrorProvider errorProviderClient;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxClientCode;
        private System.Windows.Forms.ComboBox comboBoxProvince;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPostalCode;
        private System.Windows.Forms.Button buttonShowInvoices;
        private System.Windows.Forms.ToolTip toolTipShowInvoices;
    }
}