namespace CashierApplication
{
    partial class Form1
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
            this.Itemtxtbox = new System.Windows.Forms.TextBox();
            this.Discounttxtbox = new System.Windows.Forms.TextBox();
            this.Pricetxtbox = new System.Windows.Forms.TextBox();
            this.Quantitytxtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Paymenttxtbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6TotalAm = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9Change = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Itemtxtbox
            // 
            this.Itemtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemtxtbox.Location = new System.Drawing.Point(12, 55);
            this.Itemtxtbox.Name = "Itemtxtbox";
            this.Itemtxtbox.Size = new System.Drawing.Size(289, 30);
            this.Itemtxtbox.TabIndex = 0;
            // 
            // Discounttxtbox
            // 
            this.Discounttxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discounttxtbox.Location = new System.Drawing.Point(312, 55);
            this.Discounttxtbox.Name = "Discounttxtbox";
            this.Discounttxtbox.Size = new System.Drawing.Size(177, 30);
            this.Discounttxtbox.TabIndex = 1;
            // 
            // Pricetxtbox
            // 
            this.Pricetxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricetxtbox.Location = new System.Drawing.Point(107, 94);
            this.Pricetxtbox.Name = "Pricetxtbox";
            this.Pricetxtbox.Size = new System.Drawing.Size(194, 30);
            this.Pricetxtbox.TabIndex = 2;
            // 
            // Quantitytxtbox
            // 
            this.Quantitytxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitytxtbox.Location = new System.Drawing.Point(415, 91);
            this.Quantitytxtbox.Name = "Quantitytxtbox";
            this.Quantitytxtbox.Size = new System.Drawing.Size(74, 30);
            this.Quantitytxtbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Paymenttxtbox
            // 
            this.Paymenttxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paymenttxtbox.Location = new System.Drawing.Point(232, 278);
            this.Paymenttxtbox.Name = "Paymenttxtbox";
            this.Paymenttxtbox.Size = new System.Drawing.Size(144, 30);
            this.Paymenttxtbox.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(382, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Discount (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total amount:";
            // 
            // label6TotalAm
            // 
            this.label6TotalAm.AutoSize = true;
            this.label6TotalAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6TotalAm.Location = new System.Drawing.Point(229, 218);
            this.label6TotalAm.Name = "label6TotalAm";
            this.label6TotalAm.Size = new System.Drawing.Size(0, 25);
            this.label6TotalAm.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Payment received:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Change";
            // 
            // label9Change
            // 
            this.label9Change.AutoSize = true;
            this.label9Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9Change.Location = new System.Drawing.Point(231, 341);
            this.label9Change.Name = "label9Change";
            this.label9Change.Size = new System.Drawing.Size(0, 25);
            this.label9Change.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 400);
            this.Controls.Add(this.label9Change);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6TotalAm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Paymenttxtbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Quantitytxtbox);
            this.Controls.Add(this.Pricetxtbox);
            this.Controls.Add(this.Discounttxtbox);
            this.Controls.Add(this.Itemtxtbox);
            this.Name = "Form1";
            this.Text = "Purchase Discounted Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Itemtxtbox;
        private System.Windows.Forms.TextBox Discounttxtbox;
        private System.Windows.Forms.TextBox Pricetxtbox;
        private System.Windows.Forms.TextBox Quantitytxtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Paymenttxtbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6TotalAm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9Change;
    }
}

