using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            int id = int.Parse(txtstudentid.Text);
            string department = txtdepartment.Text;
            string semester = txtsemester.Text;
            lblout.Text = name + "," + id + "," + department + "," + semester;
           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtstudentid.Clear();
            txtdepartment.Text = string.Empty;
            txtsemester.Text = string.Empty;
            lblout.Text = string.Empty;
           
        }
    }
}
