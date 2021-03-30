namespace COMP2614Assign07
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.labelCountPrompt = new System.Windows.Forms.Label();
            this.labelCountResult = new System.Windows.Forms.Label();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.labelTotalYTDSales = new System.Windows.Forms.Label();
            this.labelTotalYTDSalesPrompt = new System.Windows.Forms.Label();
            this.labelCreditHoldCount = new System.Windows.Forms.Label();
            this.labelCreditHoldCountPrompt = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.toolTipReport = new System.Windows.Forms.ToolTip(this.components);
            this.labelYTDSalesDifferencePrompt = new System.Windows.Forms.Label();
            this.labelYTDSalesDifference = new System.Windows.Forms.Label();
            this.checkBoxConfirmDeletion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(606, 328);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellDoubleClick);
            this.dataGridViewClients.SelectionChanged += new System.EventHandler(this.dataGridViewClients_SelectionChanged);
            // 
            // labelCountPrompt
            // 
            this.labelCountPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountPrompt.AutoSize = true;
            this.labelCountPrompt.Location = new System.Drawing.Point(15, 358);
            this.labelCountPrompt.Name = "labelCountPrompt";
            this.labelCountPrompt.Size = new System.Drawing.Size(38, 13);
            this.labelCountPrompt.TabIndex = 1;
            this.labelCountPrompt.Text = "Count:";
            // 
            // labelCountResult
            // 
            this.labelCountResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountResult.AutoSize = true;
            this.labelCountResult.Location = new System.Drawing.Point(114, 358);
            this.labelCountResult.Name = "labelCountResult";
            this.labelCountResult.Size = new System.Drawing.Size(47, 13);
            this.labelCountResult.TabIndex = 2;
            this.labelCountResult.Text = "<Count>";
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNew.Location = new System.Drawing.Point(445, 353);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 11;
            this.buttonAddNew.Text = "&New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // labelTotalYTDSales
            // 
            this.labelTotalYTDSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalYTDSales.AutoSize = true;
            this.labelTotalYTDSales.Location = new System.Drawing.Point(114, 412);
            this.labelTotalYTDSales.Name = "labelTotalYTDSales";
            this.labelTotalYTDSales.Size = new System.Drawing.Size(91, 13);
            this.labelTotalYTDSales.TabIndex = 6;
            this.labelTotalYTDSales.Text = "<TotalYTDSales>";
            // 
            // labelTotalYTDSalesPrompt
            // 
            this.labelTotalYTDSalesPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalYTDSalesPrompt.AutoSize = true;
            this.labelTotalYTDSalesPrompt.Location = new System.Drawing.Point(15, 412);
            this.labelTotalYTDSalesPrompt.Name = "labelTotalYTDSalesPrompt";
            this.labelTotalYTDSalesPrompt.Size = new System.Drawing.Size(88, 13);
            this.labelTotalYTDSalesPrompt.TabIndex = 5;
            this.labelTotalYTDSalesPrompt.Text = "Total YTD Sales:";
            // 
            // labelCreditHoldCount
            // 
            this.labelCreditHoldCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCreditHoldCount.AutoSize = true;
            this.labelCreditHoldCount.Location = new System.Drawing.Point(114, 385);
            this.labelCreditHoldCount.Name = "labelCreditHoldCount";
            this.labelCreditHoldCount.Size = new System.Drawing.Size(96, 13);
            this.labelCreditHoldCount.TabIndex = 4;
            this.labelCreditHoldCount.Text = "<CreditHoldCount>";
            // 
            // labelCreditHoldCountPrompt
            // 
            this.labelCreditHoldCountPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCreditHoldCountPrompt.AutoSize = true;
            this.labelCreditHoldCountPrompt.Location = new System.Drawing.Point(15, 385);
            this.labelCreditHoldCountPrompt.Name = "labelCreditHoldCountPrompt";
            this.labelCreditHoldCountPrompt.Size = new System.Drawing.Size(93, 13);
            this.labelCreditHoldCountPrompt.TabIndex = 3;
            this.labelCreditHoldCountPrompt.Text = "Credit Hold Count:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(543, 353);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "&Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(347, 353);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReport.Location = new System.Drawing.Point(506, 429);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(112, 23);
            this.buttonReport.TabIndex = 13;
            this.buttonReport.Text = "&Show Invoices";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // labelYTDSalesDifferencePrompt
            // 
            this.labelYTDSalesDifferencePrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelYTDSalesDifferencePrompt.AutoSize = true;
            this.labelYTDSalesDifferencePrompt.Location = new System.Drawing.Point(15, 439);
            this.labelYTDSalesDifferencePrompt.Name = "labelYTDSalesDifferencePrompt";
            this.labelYTDSalesDifferencePrompt.Size = new System.Drawing.Size(195, 13);
            this.labelYTDSalesDifferencePrompt.TabIndex = 7;
            this.labelYTDSalesDifferencePrompt.Text = "YTD Sales Difference to Total Average:";
            // 
            // labelYTDSalesDifference
            // 
            this.labelYTDSalesDifference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelYTDSalesDifference.AutoSize = true;
            this.labelYTDSalesDifference.Location = new System.Drawing.Point(222, 439);
            this.labelYTDSalesDifference.Name = "labelYTDSalesDifference";
            this.labelYTDSalesDifference.Size = new System.Drawing.Size(116, 13);
            this.labelYTDSalesDifference.TabIndex = 8;
            this.labelYTDSalesDifference.Text = "<YTDSalesDifference>";
            // 
            // checkBoxConfirmDeletion
            // 
            this.checkBoxConfirmDeletion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxConfirmDeletion.AutoSize = true;
            this.checkBoxConfirmDeletion.Checked = true;
            this.checkBoxConfirmDeletion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxConfirmDeletion.Location = new System.Drawing.Point(347, 395);
            this.checkBoxConfirmDeletion.Name = "checkBoxConfirmDeletion";
            this.checkBoxConfirmDeletion.Size = new System.Drawing.Size(125, 17);
            this.checkBoxConfirmDeletion.TabIndex = 9;
            this.checkBoxConfirmDeletion.Text = "Use Confirm Deletion";
            this.checkBoxConfirmDeletion.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 468);
            this.Controls.Add(this.checkBoxConfirmDeletion);
            this.Controls.Add(this.labelYTDSalesDifference);
            this.Controls.Add(this.labelYTDSalesDifferencePrompt);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelCreditHoldCount);
            this.Controls.Add(this.labelCreditHoldCountPrompt);
            this.Controls.Add(this.labelTotalYTDSales);
            this.Controls.Add(this.labelTotalYTDSalesPrompt);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.labelCountResult);
            this.Controls.Add(this.labelCountPrompt);
            this.Controls.Add(this.dataGridViewClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Binding Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Label labelCountPrompt;
        private System.Windows.Forms.Label labelCountResult;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Label labelTotalYTDSales;
        private System.Windows.Forms.Label labelTotalYTDSalesPrompt;
        private System.Windows.Forms.Label labelCreditHoldCount;
        private System.Windows.Forms.Label labelCreditHoldCountPrompt;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.ToolTip toolTipReport;
        private System.Windows.Forms.Label labelYTDSalesDifferencePrompt;
        private System.Windows.Forms.Label labelYTDSalesDifference;
        private System.Windows.Forms.CheckBox checkBoxConfirmDeletion;
    }
}

