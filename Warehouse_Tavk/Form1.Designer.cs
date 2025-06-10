namespace Warehouse_Tavk
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.listBoxWarehouse = new System.Windows.Forms.ListBox();
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelWarehouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(65, 50);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(178, 292);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // listBoxWarehouse
            // 
            this.listBoxWarehouse.FormattingEnabled = true;
            this.listBoxWarehouse.ItemHeight = 16;
            this.listBoxWarehouse.Location = new System.Drawing.Point(561, 50);
            this.listBoxWarehouse.Name = "listBoxWarehouse";
            this.listBoxWarehouse.Size = new System.Drawing.Size(178, 292);
            this.listBoxWarehouse.TabIndex = 1;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Location = new System.Drawing.Point(65, 13);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(75, 16);
            this.labelProducts.TabIndex = 2;
            this.labelProducts.Text = "Продукты ";
            // 
            // labelWarehouse
            // 
            this.labelWarehouse.AutoSize = true;
            this.labelWarehouse.Location = new System.Drawing.Point(561, 13);
            this.labelWarehouse.Name = "labelWarehouse";
            this.labelWarehouse.Size = new System.Drawing.Size(47, 16);
            this.labelWarehouse.TabIndex = 3;
            this.labelWarehouse.Text = "Склад";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWarehouse);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.listBoxWarehouse);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.ListBox listBoxWarehouse;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelWarehouse;
    }
}

