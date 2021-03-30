namespace COMP2614Assign07
{
    partial class PrintInvoiceReportDialog
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
            this.textBoxPrintInvoiceReport = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPrintInvoiceReport
            // 
            this.textBoxPrintInvoiceReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrintInvoiceReport.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrintInvoiceReport.Location = new System.Drawing.Point(12, 12);
            this.textBoxPrintInvoiceReport.Multiline = true;
            this.textBoxPrintInvoiceReport.Name = "textBoxPrintInvoiceReport";
            this.textBoxPrintInvoiceReport.ReadOnly = true;
            this.textBoxPrintInvoiceReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPrintInvoiceReport.Size = new System.Drawing.Size(478, 302);
            this.textBoxPrintInvoiceReport.TabIndex = 0;
            this.textBoxPrintInvoiceReport.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(415, 331);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // PrintInvoiceReportDialog
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(502, 366);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxPrintInvoiceReport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintInvoiceReportDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Print Invoice Report";
            this.Load += new System.EventHandler(this.PrintInvoiceReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrintInvoiceReport;
        private System.Windows.Forms.Button buttonClose;
    }
}