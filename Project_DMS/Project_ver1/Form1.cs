using System.Windows.Forms;
using System;

namespace Project_ver1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar != '\0')
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("phongga088") && textBox2.Text.Equals("123"))
            {
                // If correct, close current form and open Form2
                //MessageBox.Show("Incorrect username or password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                // If incorrect, display a message or take appropriate action
                MessageBox.Show("Incorrect username or password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}