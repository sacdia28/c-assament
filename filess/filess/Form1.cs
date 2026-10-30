using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creatingfiles
            StreamWriter lines;
            lines = File.CreateText("filess.doc");
            lines.WriteLine("ether functions of reading include");
            lines.WriteLine("welcome to jamhuuriya university");
            lines.WriteLine("class ca244");
            lines.WriteLine("sacdia hersi adan");
            MessageBox.Show("File successfully created and written!");
            //closing the lines
            lines.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
            if (File.Exists("filess.doc"))
            {
                foreach (string line in File.ReadLines("filess.doc"))
                {
                    lst1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Faylku ma jiro! Fadlan marka hore 'writeline' riix.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
            if (File.Exists("filess.doc"))
            {
                string[] lines = File.ReadAllLines("filess.doc");

                foreach (string line in lines)
                {
                    lst1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Faylku ma jiro! Fadlan marka hore 'writeline' riix.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("filess.doc"))
            {
                File.Delete("filess.doc");

                lst1.Items.Clear();

                MessageBox.Show("File successfully deleted!");
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }
            //  Delete file button delete files
private void btndeletefile_Click(object sender, EventArgs e)
        {
           
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
        }
    }
}

