namespace Project_Pizza
{
    partial class invioces
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpInvoice = new System.Windows.Forms.TabPage();
            this.lbfrmInvoice = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNumberCasher = new System.Windows.Forms.Label();
            this.lbNameItem = new System.Windows.Forms.Label();
            this.lbPriceItem = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpInvoice);
            this.tabControl1.Location = new System.Drawing.Point(2, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 450);
            this.tabControl1.TabIndex = 3;
            // 
            // tpInvoice
            // 
            this.tpInvoice.Controls.Add(this.lbPriceItem);
            this.tpInvoice.Controls.Add(this.lbNameItem);
            this.tpInvoice.Controls.Add(this.lbNumberCasher);
            this.tpInvoice.Controls.Add(this.label3);
            this.tpInvoice.Controls.Add(this.label2);
            this.tpInvoice.Controls.Add(this.label1);
            this.tpInvoice.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpInvoice.Location = new System.Drawing.Point(4, 22);
            this.tpInvoice.Name = "tpInvoice";
            this.tpInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tpInvoice.Size = new System.Drawing.Size(490, 424);
            this.tpInvoice.TabIndex = 1;
            this.tpInvoice.Text = "Invoice";
            this.tpInvoice.UseVisualStyleBackColor = true;
            this.tpInvoice.Click += new System.EventHandler(this.tpInvoice_Click);
            // 
            // lbfrmInvoice
            // 
            this.lbfrmInvoice.FormattingEnabled = true;
            this.lbfrmInvoice.Location = new System.Drawing.Point(494, 33);
            this.lbfrmInvoice.Name = "lbfrmInvoice";
            this.lbfrmInvoice.Size = new System.Drawing.Size(294, 420);
            this.lbfrmInvoice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الكاشير";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المنتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "سعر المنتج";
            // 
            // lbNumberCasher
            // 
            this.lbNumberCasher.AutoSize = true;
            this.lbNumberCasher.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberCasher.ForeColor = System.Drawing.Color.Red;
            this.lbNumberCasher.Location = new System.Drawing.Point(189, 95);
            this.lbNumberCasher.Name = "lbNumberCasher";
            this.lbNumberCasher.Size = new System.Drawing.Size(0, 30);
            this.lbNumberCasher.TabIndex = 3;
            this.lbNumberCasher.Visible = false;
            // 
            // lbNameItem
            // 
            this.lbNameItem.AutoSize = true;
            this.lbNameItem.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameItem.ForeColor = System.Drawing.Color.Red;
            this.lbNameItem.Location = new System.Drawing.Point(184, 198);
            this.lbNameItem.Name = "lbNameItem";
            this.lbNameItem.Size = new System.Drawing.Size(0, 30);
            this.lbNameItem.TabIndex = 4;
            this.lbNameItem.Visible = false;
            // 
            // lbPriceItem
            // 
            this.lbPriceItem.AutoSize = true;
            this.lbPriceItem.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceItem.ForeColor = System.Drawing.Color.Red;
            this.lbPriceItem.Location = new System.Drawing.Point(199, 327);
            this.lbPriceItem.Name = "lbPriceItem";
            this.lbPriceItem.Size = new System.Drawing.Size(0, 30);
            this.lbPriceItem.TabIndex = 5;
            this.lbPriceItem.Visible = false;
            // 
            // invioces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbfrmInvoice);
            this.Controls.Add(this.tabControl1);
            this.Name = "invioces";
            this.Text = "invioces";
            this.tabControl1.ResumeLayout(false);
            this.tpInvoice.ResumeLayout(false);
            this.tpInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbNameItem;
        public System.Windows.Forms.Label lbPriceItem;
        public System.Windows.Forms.Label lbNumberCasher;
        public System.Windows.Forms.TabPage tpInvoice;
        public System.Windows.Forms.ListBox lbfrmInvoice;
    }
}