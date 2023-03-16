using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab009;

namespace Lab09A_210042149
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 abc = new Form2();
            abc.ShowDialog();
        }


        public void checkUser(string str)
        {
            string user = $@"D:\Codes\C#\Lab09A_210042149\user\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string u in users)
                {
                    if (u.Contains("un:"))
                    {
                        if (usertxt.Text == u.Remove(0, 3))
                        {
                            foreach (string p in users)
                            {
                                if (p.Contains("pass:"))
                                {
                                    if (passtxt.Text == p.Remove(0, 5))
                                    {
                                        GlobalClass._userName = u.Remove(0, 3);
                                        foreach (string n in users)
                                        {
                                            if (n.Contains("nm:"))
                                            {
                                                GlobalClass._name = n.Remove(0, 3);
                                            }
                                        }
                                        this.Hide();
                                        Form3 abc = new Form3();
                                        abc.ShowDialog();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkUser(usertxt.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
