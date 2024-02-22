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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string plamedi = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C: \Users\giftd\OneDrive\Desktop\new project\FRIDAY TEST.accdb";
                OleDbConnection con = new OleDbConnection(plamedi);
                con.Open();
                string select = "Select * from FALCON_BUSINESS_COLLEGE22 where FACULTY_NUMBER='" + textBox1.Text + "'";
                OleDbDataAdapter mbala = new OleDbDataAdapter(select, con);
                DataTable keren = new DataTable();
                mbala.Fill(keren);
                dataGridView1.DataSource = keren;
                con.Close();
                string CONTACT_HOURS = keren.Rows[0]["CONTACT_HOURS"].ToString();
                string department = keren.Rows[0]["DEPARTMENT_CONT_HOURS"].ToString();
                string school = keren.Rows[0]["COLLEGE_CONT_HOURS"].ToString();
                int CONTACT_H = Convert.ToInt32(CONTACT_HOURS);
                label3.Text = "department contact hours : " + department;
                label4.Text = "school contact hours : " + school;
                if (CONTACT_H < 8)

                {
                    label1.Text = " The school still close " + CONTACT_H + "  " + DateTime.Now;
                }
                else if ((CONTACT_H >= 8) && (CONTACT_H < 12))
                {
                    label1.Text = " Lecturer in class teching computer networking " + CONTACT_H + "  " + DateTime.Now;
                }

                else if ((CONTACT_H >= 12) && (CONTACT_H <= 13))
                {
                    label1.Text = " Lecturer is in Lunch " + CONTACT_H + "  " + DateTime.Now;
                }

                else if ((CONTACT_H > 13) && (CONTACT_H <= 16))
                {
                    label1.Text = " Lecturer is still in class Lecturing " + CONTACT_H + "- " + DateTime.Now;
                }
                else if (CONTACT_H > 16)
                {
                    label1.Text = "Lecture is out";



                }
            }

            catch
            {
                MessageBox.Show("please enter correct faculty number");
            }
               
                    
            


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
