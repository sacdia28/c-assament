namespace Ticket_Assignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ldlname = new System.Windows.Forms.Label();
            this.ldlage = new System.Windows.Forms.Label();
            this.ldlnumber = new System.Windows.Forms.Label();
            this.ldlweight = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtticket = new System.Windows.Forms.TextBox();
            this.txtbaggage = new System.Windows.Forms.TextBox();
            this.grclass = new System.Windows.Forms.GroupBox();
            this.rdobusiness = new System.Windows.Forms.RadioButton();
            this.rdonormal = new System.Windows.Forms.RadioButton();
            this.rdofirst = new System.Windows.Forms.RadioButton();
            this.groptions = new System.Windows.Forms.GroupBox();
            this.chadd = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lstbox = new System.Windows.Forms.ListBox();
            this.grclass.SuspendLayout();
            this.groptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "personal information";
            // 
            // ldlname
            // 
            this.ldlname.AutoSize = true;
            this.ldlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlname.Location = new System.Drawing.Point(185, 76);
            this.ldlname.Name = "ldlname";
            this.ldlname.Size = new System.Drawing.Size(142, 20);
            this.ldlname.TabIndex = 2;
            this.ldlname.Text = "passenger name";
            // 
            // ldlage
            // 
            this.ldlage.AutoSize = true;
            this.ldlage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlage.Location = new System.Drawing.Point(185, 128);
            this.ldlage.Name = "ldlage";
            this.ldlage.Size = new System.Drawing.Size(128, 20);
            this.ldlage.TabIndex = 3;
            this.ldlage.Text = "passenger age";
            // 
            // ldlnumber
            // 
            this.ldlnumber.AutoSize = true;
            this.ldlnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlnumber.Location = new System.Drawing.Point(185, 177);
            this.ldlnumber.Name = "ldlnumber";
            this.ldlnumber.Size = new System.Drawing.Size(150, 20);
            this.ldlnumber.TabIndex = 4;
            this.ldlnumber.Text = "Number of tickets";
            // 
            // ldlweight
            // 
            this.ldlweight.AutoSize = true;
            this.ldlweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlweight.Location = new System.Drawing.Point(185, 222);
            this.ldlweight.Name = "ldlweight";
            this.ldlweight.Size = new System.Drawing.Size(169, 20);
            this.ldlweight.TabIndex = 5;
            this.ldlweight.Text = "Baggage weight(kg)";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(381, 76);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(212, 26);
            this.txtname.TabIndex = 6;
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Location = new System.Drawing.Point(381, 122);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(212, 26);
            this.txtage.TabIndex = 7;
            // 
            // txtticket
            // 
            this.txtticket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtticket.Location = new System.Drawing.Point(381, 177);
            this.txtticket.Name = "txtticket";
            this.txtticket.Size = new System.Drawing.Size(212, 26);
            this.txtticket.TabIndex = 8;
            // 
            // txtbaggage
            // 
            this.txtbaggage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbaggage.Location = new System.Drawing.Point(381, 222);
            this.txtbaggage.Name = "txtbaggage";
            this.txtbaggage.Size = new System.Drawing.Size(212, 26);
            this.txtbaggage.TabIndex = 9;
            // 
            // grclass
            // 
            this.grclass.Controls.Add(this.rdobusiness);
            this.grclass.Controls.Add(this.rdonormal);
            this.grclass.Controls.Add(this.rdofirst);
            this.grclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grclass.Location = new System.Drawing.Point(189, 289);
            this.grclass.Name = "grclass";
            this.grclass.Size = new System.Drawing.Size(462, 80);
            this.grclass.TabIndex = 10;
            this.grclass.TabStop = false;
            this.grclass.Text = "Travel class";
            // 
            // rdobusiness
            // 
            this.rdobusiness.AutoSize = true;
            this.rdobusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdobusiness.Location = new System.Drawing.Point(303, 38);
            this.rdobusiness.Name = "rdobusiness";
            this.rdobusiness.Size = new System.Drawing.Size(153, 24);
            this.rdobusiness.TabIndex = 2;
            this.rdobusiness.TabStop = true;
            this.rdobusiness.Text = "Business class";
            this.rdobusiness.UseVisualStyleBackColor = true;
            this.rdobusiness.CheckedChanged += new System.EventHandler(this.rdobusiness_CheckedChanged);
            // 
            // rdonormal
            // 
            this.rdonormal.AutoSize = true;
            this.rdonormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdonormal.Location = new System.Drawing.Point(151, 38);
            this.rdonormal.Name = "rdonormal";
            this.rdonormal.Size = new System.Drawing.Size(134, 24);
            this.rdonormal.TabIndex = 1;
            this.rdonormal.TabStop = true;
            this.rdonormal.Text = "normal class";
            this.rdonormal.UseVisualStyleBackColor = true;
            // 
            // rdofirst
            // 
            this.rdofirst.AutoSize = true;
            this.rdofirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdofirst.Location = new System.Drawing.Point(6, 38);
            this.rdofirst.Name = "rdofirst";
            this.rdofirst.Size = new System.Drawing.Size(116, 24);
            this.rdofirst.TabIndex = 0;
            this.rdofirst.TabStop = true;
            this.rdofirst.Text = "First class";
            this.rdofirst.UseVisualStyleBackColor = true;
            // 
            // groptions
            // 
            this.groptions.Controls.Add(this.chadd);
            this.groptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groptions.Location = new System.Drawing.Point(195, 375);
            this.groptions.Name = "groptions";
            this.groptions.Size = new System.Drawing.Size(456, 88);
            this.groptions.TabIndex = 11;
            this.groptions.TabStop = false;
            this.groptions.Text = "Aditional options";
            this.groptions.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chadd
            // 
            this.chadd.AutoSize = true;
            this.chadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chadd.Location = new System.Drawing.Point(34, 39);
            this.chadd.Name = "chadd";
            this.chadd.Size = new System.Drawing.Size(330, 24);
            this.chadd.TabIndex = 0;
            this.chadd.Text = "Add Travel insurance ($25 per ticket)";
            this.chadd.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(195, 482);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(102, 30);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(381, 482);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(108, 30);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(551, 482);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(94, 30);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lstbox
            // 
            this.lstbox.FormattingEnabled = true;
            this.lstbox.ItemHeight = 20;
            this.lstbox.Location = new System.Drawing.Point(726, 103);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(191, 364);
            this.lstbox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 581);
            this.Controls.Add(this.lstbox);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groptions);
            this.Controls.Add(this.grclass);
            this.Controls.Add(this.txtbaggage);
            this.Controls.Add(this.txtticket);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.ldlweight);
            this.Controls.Add(this.ldlnumber);
            this.Controls.Add(this.ldlage);
            this.Controls.Add(this.ldlname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grclass.ResumeLayout(false);
            this.grclass.PerformLayout();
            this.groptions.ResumeLayout(false);
            this.groptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ldlname;
        private System.Windows.Forms.Label ldlage;
        private System.Windows.Forms.Label ldlnumber;
        private System.Windows.Forms.Label ldlweight;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtticket;
        private System.Windows.Forms.TextBox txtbaggage;
        private System.Windows.Forms.GroupBox grclass;
        private System.Windows.Forms.RadioButton rdonormal;
        private System.Windows.Forms.RadioButton rdofirst;
        private System.Windows.Forms.RadioButton rdobusiness;
        private System.Windows.Forms.GroupBox groptions;
        private System.Windows.Forms.CheckBox chadd;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lstbox;
    }
}

