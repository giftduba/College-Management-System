using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_No2
{
    public partial class Form1 : Form
    {
        string rname;
        string sword;
        public Form1()
                 
        {
           

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            rname = textBox1.Text;
            sword = textBox2.Text;

            if ((rname == "gift") && (sword == "pass"))
            {
                Form2 pmd = new Form2();
                pmd.Show();
            }
            else if ((rname == "duba") && (sword == "1234"))
            {

                Form3 log = new Form3();
                log.Show();

            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
