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

namespace Lab09A_210042149
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 abc = new Form1();
            abc.ShowDialog();

        }

        public void regUser(string str)
        {
            string newUser = $@"D:\Codes\C#\Lab09A_210042149\user\{str}.txt";

            using (StreamWriter writer = new StreamWriter(newUser))
            {
                writer.Write("un:" + usertxt.Text);
                writer.Write('\n');
                if (passtxt.Text.Length >= 6)
                {
                    if (passtxt.Text == repasstxt.Text)
                    {
                        writer.Write("pass:" + passtxt.Text);
                        writer.Write('\n');
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password must be at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                writer.Write("nm:" + nametxt.Text);
                writer.Write('\n');
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passtxt.Text.Length >= 6)
            {

                if (passtxt.Text == repasstxt.Text)
                {
                    regUser(usertxt.Text);
                    User _temp = new User(usertxt.Text, passtxt.Text, nametxt.Text);
                    MessageBox.Show("Account successfully created!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 abc = new Form1();
                    abc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Passwords do not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Password must be at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
