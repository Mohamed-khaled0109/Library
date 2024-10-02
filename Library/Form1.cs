using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    public partial class Form1 : Form
    {
        Form3 form3 = new Form3();
        Context context = new Context();
        Registrars registrar = new Registrars();
        Form2 form2 = new Form2();
        Form4 form4 = new Form4();
        Form5 form5 = new Form5(); 
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            form2.ShowDialog();
        }
        public void relese()
        {
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("All fields are required");
                return;
            }
            else
            {
                registrar.Name = txtName.Text;
                registrar.Password = txtPassword.Text;
            }

            var existingRegistrar = context.Registrars.FirstOrDefault(r => r.Name == registrar.Name && r.Password == registrar.Password);

            if (existingRegistrar != null)
            {
                 MessageBox.Show("Registration successfully");

                if (txtName.Text == "Admin")
                {
                  
                    form3.Show();

                }
                else
                {
                    form4.Show();
                }
                MessageBox.Show(txtName.Text);

                this.Hide();
            }
            else
            {
                MessageBox.Show("The email or password is incorrect");
            }

            relese();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form5.Show();
        }
    }
}
