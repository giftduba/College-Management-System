using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_No2
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

            try
            {


                double contacthours;
                int classzise = Convert.ToInt32(textBox6.Text);
                int credithours = Convert.ToInt32(textBox5.Text);
                contacthours = (classzise / 50) * credithours;
                int depatment = 10;
                int college = 9;

                string plaing = NewMethod();
                OleDbConnection con = new OleDbConnection(plaing);
                con.Open();
                string data = $"INSERT INTO FALCON_BUSINESS_COLLEGE22 (Facult_Number,Lecture_Name,Lecture_surname,lecture_Code,Module_code,Credit_Hours,Class_Size,Contact_hours) VALUES('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4}','{textBox5.Text}','{textBox6.Text}','{textBox7.Text}','{Convert.ToString(contacthours)}' ,'{Convert.ToString(depatment)}','{Convert.ToString(college)}')";
                OleDbCommand com = new OleDbCommand(data, con);
                com.ExecuteNonQuery();
                MessageBox.Show("submit");
                con.Close();
            }
            catch
            {
                MessageBox.Show("please input another faculty number");
            }

            string NewMethod()
            {
                return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C: \Users\giftd\OneDrive\Desktop\new project\FRIDAY TEST.accdb";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
