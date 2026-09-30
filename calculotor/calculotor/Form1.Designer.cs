namespace calculotor
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
            this.total = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.usage = new System.Windows.Forms.Label();
            this.ldltotal = new System.Windows.Forms.Label();
            this.ldlt = new System.Windows.Forms.Label();
            this.ldlss = new System.Windows.Forms.Label();
            this.ldlc = new System.Windows.Forms.Label();
            this.ldl = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtcurren = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprevious = new System.Windows.Forms.TextBox();
            this.ldlprice = new System.Windows.Forms.Label();
            this.ldlcurrent = new System.Windows.Forms.Label();
            this.ldlreading = new System.Windows.Forms.Label();
            this.ldlenter = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // total
            // 
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total.Location = new System.Drawing.Point(460, 362);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(188, 32);
            this.total.TabIndex = 33;
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // tax
            // 
            this.tax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tax.Location = new System.Drawing.Point(460, 326);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(188, 29);
            this.tax.TabIndex = 32;
            this.tax.Click += new System.EventHandler(this.tax_Click);
            // 
            // usage
            // 
            this.usage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usage.Location = new System.Drawing.Point(460, 287);
            this.usage.Name = "usage";
            this.usage.Size = new System.Drawing.Size(184, 34);
            this.usage.TabIndex = 31;
            this.usage.Click += new System.EventHandler(this.usage_Click);
            // 
            // ldltotal
            // 
            this.ldltotal.AutoSize = true;
            this.ldltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldltotal.Location = new System.Drawing.Point(93, 374);
            this.ldltotal.Name = "ldltotal";
            this.ldltotal.Size = new System.Drawing.Size(297, 20);
            this.ldltotal.TabIndex = 30;
            this.ldltotal.Text = "Total bill (including $5 fixed charge):";
            this.ldltotal.Click += new System.EventHandler(this.ldltotal_Click);
            // 
            // ldlt
            // 
            this.ldlt.AutoSize = true;
            this.ldlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlt.Location = new System.Drawing.Point(107, 335);
            this.ldlt.Name = "ldlt";
            this.ldlt.Size = new System.Drawing.Size(135, 20);
            this.ldlt.TabIndex = 29;
            this.ldlt.Text = "tax amount(7%)";
            this.ldlt.Click += new System.EventHandler(this.ldlt_Click);
            // 
            // ldlss
            // 
            this.ldlss.AutoSize = true;
            this.ldlss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlss.Location = new System.Drawing.Point(107, 301);
            this.ldlss.Name = "ldlss";
            this.ldlss.Size = new System.Drawing.Size(147, 20);
            this.ldlss.TabIndex = 28;
            this.ldlss.Text = "enter usage(unit)";
            this.ldlss.Click += new System.EventHandler(this.ldlss_Click);
            // 
            // ldlc
            // 
            this.ldlc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ldlc.Location = new System.Drawing.Point(66, 276);
            this.ldlc.Name = "ldlc";
            this.ldlc.Size = new System.Drawing.Size(619, 137);
            this.ldlc.TabIndex = 27;
            this.ldlc.Click += new System.EventHandler(this.ldlc_Click);
            // 
            // ldl
            // 
            this.ldl.AutoSize = true;
            this.ldl.Location = new System.Drawing.Point(410, 301);
            this.ldl.Name = "ldl";
            this.ldl.Size = new System.Drawing.Size(0, 20);
            this.ldl.TabIndex = 26;
            this.ldl.Click += new System.EventHandler(this.ldl_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(493, 136);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(241, 26);
            this.txtprice.TabIndex = 25;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtcurren
            // 
            this.txtcurren.Location = new System.Drawing.Point(493, 104);
            this.txtcurren.Name = "txtcurren";
            this.txtcurren.Size = new System.Drawing.Size(241, 26);
            this.txtcurren.TabIndex = 24;
            this.txtcurren.TextChanged += new System.EventHandler(this.txtcurren_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(493, 37);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(241, 26);
            this.txtname.TabIndex = 23;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtprevious
            // 
            this.txtprevious.Location = new System.Drawing.Point(493, 72);
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(241, 26);
            this.txtprevious.TabIndex = 22;
            this.txtprevious.TextChanged += new System.EventHandler(this.txtprevious_TextChanged);
            // 
            // ldlprice
            // 
            this.ldlprice.AutoSize = true;
            this.ldlprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlprice.Location = new System.Drawing.Point(172, 112);
            this.ldlprice.Name = "ldlprice";
            this.ldlprice.Size = new System.Drawing.Size(161, 20);
            this.ldlprice.TabIndex = 21;
            this.ldlprice.Text = "enter price per unit";
            this.ldlprice.Click += new System.EventHandler(this.ldlprice_Click);
            // 
            // ldlcurrent
            // 
            this.ldlcurrent.AutoSize = true;
            this.ldlcurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlcurrent.Location = new System.Drawing.Point(172, 92);
            this.ldlcurrent.Name = "ldlcurrent";
            this.ldlcurrent.Size = new System.Drawing.Size(178, 20);
            this.ldlcurrent.TabIndex = 20;
            this.ldlcurrent.Text = "enter current reading";
            this.ldlcurrent.Click += new System.EventHandler(this.ldlcurrent_Click);
            // 
            // ldlreading
            // 
            this.ldlreading.AutoSize = true;
            this.ldlreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlreading.Location = new System.Drawing.Point(172, 72);
            this.ldlreading.Name = "ldlreading";
            this.ldlreading.Size = new System.Drawing.Size(178, 20);
            this.ldlreading.TabIndex = 19;
            this.ldlreading.Text = "enter previus reading";
            this.ldlreading.Click += new System.EventHandler(this.ldlreading_Click);
            // 
            // ldlenter
            // 
            this.ldlenter.AutoSize = true;
            this.ldlenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlenter.Location = new System.Drawing.Point(172, 41);
            this.ldlenter.Name = "ldlenter";
            this.ldlenter.Size = new System.Drawing.Size(179, 20);
            this.ldlenter.TabIndex = 18;
            this.ldlenter.Text = "enter customer name";
            this.ldlenter.Click += new System.EventHandler(this.ldlenter_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(418, 198);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(140, 47);
            this.btn.TabIndex = 17;
            this.btn.Text = "calculate bill";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.total);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.usage);
            this.Controls.Add(this.ldltotal);
            this.Controls.Add(this.ldlt);
            this.Controls.Add(this.ldlss);
            this.Controls.Add(this.ldlc);
            this.Controls.Add(this.ldl);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtcurren);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtprevious);
            this.Controls.Add(this.ldlprice);
            this.Controls.Add(this.ldlcurrent);
            this.Controls.Add(this.ldlreading);
            this.Controls.Add(this.ldlenter);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label usage;
        private System.Windows.Forms.Label ldltotal;
        private System.Windows.Forms.Label ldlt;
        private System.Windows.Forms.Label ldlss;
        private System.Windows.Forms.Label ldlc;
        private System.Windows.Forms.Label ldl;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtcurren;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprevious;
        private System.Windows.Forms.Label ldlprice;
        private System.Windows.Forms.Label ldlcurrent;
        private System.Windows.Forms.Label ldlreading;
        private System.Windows.Forms.Label ldlenter;
        private System.Windows.Forms.Button btn;
    }
}

