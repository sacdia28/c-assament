namespace personal_information
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
            this.ldlpersonal = new System.Windows.Forms.Label();
            this.ldlname = new System.Windows.Forms.Label();
            this.ldlage = new System.Windows.Forms.Label();
            this.ldlnight = new System.Windows.Forms.Label();
            this.ldlguest = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtnight = new System.Windows.Forms.TextBox();
            this.txtguest = new System.Windows.Forms.TextBox();
            this.grrom = new System.Windows.Forms.GroupBox();
            this.rdhight = new System.Windows.Forms.RadioButton();
            this.rdnormal = new System.Windows.Forms.RadioButton();
            this.rds = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groptions = new System.Windows.Forms.GroupBox();
            this.chpernight = new System.Windows.Forms.CheckBox();
            this.btncal = new System.Windows.Forms.Button();
            this.BTNCLEAR = new System.Windows.Forms.Button();
            this.BTNEXIT = new System.Windows.Forms.Button();
            this.LSTBOX = new System.Windows.Forms.ListBox();
            this.grrom.SuspendLayout();
            this.groptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ldlpersonal
            // 
            this.ldlpersonal.AutoSize = true;
            this.ldlpersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlpersonal.Location = new System.Drawing.Point(227, 66);
            this.ldlpersonal.Name = "ldlpersonal";
            this.ldlpersonal.Size = new System.Drawing.Size(173, 20);
            this.ldlpersonal.TabIndex = 0;
            this.ldlpersonal.Text = "personal information";
            // 
            // ldlname
            // 
            this.ldlname.AutoSize = true;
            this.ldlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlname.Location = new System.Drawing.Point(227, 114);
            this.ldlname.Name = "ldlname";
            this.ldlname.Size = new System.Drawing.Size(107, 20);
            this.ldlname.TabIndex = 1;
            this.ldlname.Text = "Guest name";
            // 
            // ldlage
            // 
            this.ldlage.AutoSize = true;
            this.ldlage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlage.Location = new System.Drawing.Point(227, 158);
            this.ldlage.Name = "ldlage";
            this.ldlage.Size = new System.Drawing.Size(89, 20);
            this.ldlage.TabIndex = 2;
            this.ldlage.Text = "guest age";
            // 
            // ldlnight
            // 
            this.ldlnight.AutoSize = true;
            this.ldlnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlnight.Location = new System.Drawing.Point(227, 202);
            this.ldlnight.Name = "ldlnight";
            this.ldlnight.Size = new System.Drawing.Size(135, 20);
            this.ldlnight.TabIndex = 3;
            this.ldlnight.Text = "number of night";
            // 
            // ldlguest
            // 
            this.ldlguest.AutoSize = true;
            this.ldlguest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlguest.Location = new System.Drawing.Point(227, 241);
            this.ldlguest.Name = "ldlguest";
            this.ldlguest.Size = new System.Drawing.Size(140, 20);
            this.ldlguest.TabIndex = 4;
            this.ldlguest.Text = "number of guest";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(373, 114);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(224, 26);
            this.txtname.TabIndex = 5;
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Location = new System.Drawing.Point(373, 158);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(224, 26);
            this.txtage.TabIndex = 6;
            // 
            // txtnight
            // 
            this.txtnight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnight.Location = new System.Drawing.Point(373, 196);
            this.txtnight.Name = "txtnight";
            this.txtnight.Size = new System.Drawing.Size(224, 26);
            this.txtnight.TabIndex = 7;
            // 
            // txtguest
            // 
            this.txtguest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtguest.Location = new System.Drawing.Point(373, 241);
            this.txtguest.Name = "txtguest";
            this.txtguest.Size = new System.Drawing.Size(224, 26);
            this.txtguest.TabIndex = 8;
            // 
            // grrom
            // 
            this.grrom.Controls.Add(this.rdhight);
            this.grrom.Controls.Add(this.rdnormal);
            this.grrom.Controls.Add(this.rds);
            this.grrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grrom.Location = new System.Drawing.Point(213, 294);
            this.grrom.Name = "grrom";
            this.grrom.Size = new System.Drawing.Size(420, 124);
            this.grrom.TabIndex = 9;
            this.grrom.TabStop = false;
            this.grrom.Text = "Room type";
            // 
            // rdhight
            // 
            this.rdhight.AutoSize = true;
            this.rdhight.Location = new System.Drawing.Point(285, 52);
            this.rdhight.Name = "rdhight";
            this.rdhight.Size = new System.Drawing.Size(74, 24);
            this.rdhight.TabIndex = 2;
            this.rdhight.TabStop = true;
            this.rdhight.Text = "hight";
            this.rdhight.UseVisualStyleBackColor = true;
            // 
            // rdnormal
            // 
            this.rdnormal.AutoSize = true;
            this.rdnormal.Location = new System.Drawing.Point(141, 50);
            this.rdnormal.Name = "rdnormal";
            this.rdnormal.Size = new System.Drawing.Size(88, 24);
            this.rdnormal.TabIndex = 1;
            this.rdnormal.TabStop = true;
            this.rdnormal.Text = "normal";
            this.rdnormal.UseVisualStyleBackColor = true;
            // 
            // rds
            // 
            this.rds.AutoSize = true;
            this.rds.Location = new System.Drawing.Point(18, 52);
            this.rds.Name = "rds";
            this.rds.Size = new System.Drawing.Size(108, 24);
            this.rds.TabIndex = 0;
            this.rds.TabStop = true;
            this.rds.Text = "Standard";
            this.rds.UseVisualStyleBackColor = true;
            // 
            // groptions
            // 
            this.groptions.Controls.Add(this.chpernight);
            this.groptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groptions.Location = new System.Drawing.Point(213, 424);
            this.groptions.Name = "groptions";
            this.groptions.Size = new System.Drawing.Size(420, 118);
            this.groptions.TabIndex = 10;
            this.groptions.TabStop = false;
            this.groptions.Text = "Aditional options";
            // 
            // chpernight
            // 
            this.chpernight.AutoSize = true;
            this.chpernight.Location = new System.Drawing.Point(32, 51);
            this.chpernight.Name = "chpernight";
            this.chpernight.Size = new System.Drawing.Size(300, 24);
            this.chpernight.TabIndex = 0;
            this.chpernight.Text = "breakfast(10 per guest per night)";
            this.chpernight.UseVisualStyleBackColor = true;
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(231, 561);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(105, 37);
            this.btncal.TabIndex = 11;
            this.btncal.Text = "CALCULATE";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // BTNCLEAR
            // 
            this.BTNCLEAR.Location = new System.Drawing.Point(354, 561);
            this.BTNCLEAR.Name = "BTNCLEAR";
            this.BTNCLEAR.Size = new System.Drawing.Size(136, 37);
            this.BTNCLEAR.TabIndex = 12;
            this.BTNCLEAR.Text = "CLEAR";
            this.BTNCLEAR.UseVisualStyleBackColor = true;
            this.BTNCLEAR.Click += new System.EventHandler(this.BTNCLEAR_Click);
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.Location = new System.Drawing.Point(522, 561);
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(111, 37);
            this.BTNEXIT.TabIndex = 13;
            this.BTNEXIT.Text = "EXIT";
            this.BTNEXIT.UseVisualStyleBackColor = true;
            this.BTNEXIT.Click += new System.EventHandler(this.BTNEXIT_Click);
            // 
            // LSTBOX
            // 
            this.LSTBOX.FormattingEnabled = true;
            this.LSTBOX.ItemHeight = 20;
            this.LSTBOX.Location = new System.Drawing.Point(757, 127);
            this.LSTBOX.Name = "LSTBOX";
            this.LSTBOX.Size = new System.Drawing.Size(254, 404);
            this.LSTBOX.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.LSTBOX);
            this.Controls.Add(this.BTNEXIT);
            this.Controls.Add(this.BTNCLEAR);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.groptions);
            this.Controls.Add(this.grrom);
            this.Controls.Add(this.txtguest);
            this.Controls.Add(this.txtnight);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.ldlguest);
            this.Controls.Add(this.ldlnight);
            this.Controls.Add(this.ldlage);
            this.Controls.Add(this.ldlname);
            this.Controls.Add(this.ldlpersonal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grrom.ResumeLayout(false);
            this.grrom.PerformLayout();
            this.groptions.ResumeLayout(false);
            this.groptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ldlpersonal;
        private System.Windows.Forms.Label ldlname;
        private System.Windows.Forms.Label ldlage;
        private System.Windows.Forms.Label ldlnight;
        private System.Windows.Forms.Label ldlguest;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtnight;
        private System.Windows.Forms.TextBox txtguest;
        private System.Windows.Forms.GroupBox grrom;
        private System.Windows.Forms.RadioButton rdhight;
        private System.Windows.Forms.RadioButton rdnormal;
        private System.Windows.Forms.RadioButton rds;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groptions;
        private System.Windows.Forms.CheckBox chpernight;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Button BTNCLEAR;
        private System.Windows.Forms.Button BTNEXIT;
        private System.Windows.Forms.ListBox LSTBOX;
    }
}

