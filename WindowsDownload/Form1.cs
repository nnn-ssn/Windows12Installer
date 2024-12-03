using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDownload
{




    public partial class Form1 : Form
    {

        bool list1 = true;
        bool list2 = false;
        bool list3 = false;
        bool list4 = false;
        bool list5 = false;
        bool list6 = false;



        public Form1()
        {
            InitializeComponent();
        }

        public void Download()
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                label2.Text = "Пожалуйста, выбирите значения!";

                label2.Location = new Point(234, 323);


                label2.Visible = true;
                timer1.Enabled = true;


            }
        }

        public void list3Start()
        {

        }

        public void list2Start() 
        { 

            if (list1 != true) 
            {
                list2 = true;

                comboBox1.Visible = true;
                comboBox2.Visible = true;

                button1.Visible = true;

                label1.Visible = true;
            }

            else { list3Start(); }




            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (list1)
            {
                list1 = false;

                button1.Visible = false;
                label2.Visible = false;

                list2Start();

            }
            else if (list2)
            {
                Download();
            } 



            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = false;
            timer1.Enabled = false; 
        }
    }
}
