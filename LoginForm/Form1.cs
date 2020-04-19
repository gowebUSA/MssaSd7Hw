using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static int attempt = 3;

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if ((this.textBox1.Text == "Admin") && (this.textBox2.Text == "admin"))
            {
                attempt = 0;
                pictureBox1.Image = new Bitmap(@"C:\Users\Public\Pictures\access-granted.png");
                MessageBox.Show("you are granted with access");


            }
            else if ((attempt == 3) && (attempt > 0))
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\Public\Pictures\access-denied.png");
                label4.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                --attempt;
            }
            else
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\Public\Pictures\access-denied.png");
                MessageBox.Show("you are not granted with access");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
