namespace student_information
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
            this.components = new System.ComponentModel.Container();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudenid = new System.Windows.Forms.Label();
            this.lbldepartement = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.lblout = new System.Windows.Forms.Label();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsemester
            // 
            this.txtsemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsemester.Location = new System.Drawing.Point(486, 185);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(188, 26);
            this.txtsemester.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(486, 48);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(188, 26);
            this.txtname.TabIndex = 2;
            // 
            // txtdepartment
            // 
            this.txtdepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdepartment.Location = new System.Drawing.Point(486, 143);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(188, 26);
            this.txtdepartment.TabIndex = 3;
            this.txtdepartment.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtstudentid
            // 
            this.txtstudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstudentid.Location = new System.Drawing.Point(486, 96);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(188, 26);
            this.txtstudentid.TabIndex = 4;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(259, 54);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(199, 20);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Enter the student name";
            // 
            // lblstudenid
            // 
            this.lblstudenid.AutoSize = true;
            this.lblstudenid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudenid.Location = new System.Drawing.Point(277, 98);
            this.lblstudenid.Name = "lblstudenid";
            this.lblstudenid.Size = new System.Drawing.Size(169, 20);
            this.lblstudenid.TabIndex = 6;
            this.lblstudenid.Text = "Enter the student id";
            // 
            // lbldepartement
            // 
            this.lbldepartement.AutoSize = true;
            this.lbldepartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartement.Location = new System.Drawing.Point(277, 145);
            this.lbldepartement.Name = "lbldepartement";
            this.lbldepartement.Size = new System.Drawing.Size(181, 20);
            this.lbldepartement.TabIndex = 7;
            this.lbldepartement.Text = "Enter the department";
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(293, 191);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(163, 20);
            this.lbloutput.TabIndex = 8;
            this.lbloutput.Text = "Enter the semester";
            // 
            // lblout
            // 
            this.lblout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblout.Location = new System.Drawing.Point(281, 233);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(393, 42);
            this.lblout.TabIndex = 9;
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowinfo.Location = new System.Drawing.Point(281, 311);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(155, 31);
            this.btnshowinfo.TabIndex = 10;
            this.btnshowinfo.Text = "show information";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(453, 311);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(101, 31);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(577, 311);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(97, 31);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lblout);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lbldepartement);
            this.Controls.Add(this.lblstudenid);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtsemester);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudenid;
        private System.Windows.Forms.Label lbldepartement;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lblout;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

