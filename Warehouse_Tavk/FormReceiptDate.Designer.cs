namespace Warehouse_Tavk
{
    partial class FormReceiptDate
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelReceiptDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelReceiptDate
            // 
            this.labelReceiptDate.AutoSize = true;
            this.labelReceiptDate.Location = new System.Drawing.Point(69, 119);
            this.labelReceiptDate.Name = "labelReceiptDate";
            this.labelReceiptDate.Size = new System.Drawing.Size(185, 16);
            this.labelReceiptDate.TabIndex = 1;
            this.labelReceiptDate.Text = "Укажите дату поступления";
            // 
            // FormReceiptDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 323);
            this.Controls.Add(this.labelReceiptDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormReceiptDate";
            this.Text = "Дата поступления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelReceiptDate;
    }
}