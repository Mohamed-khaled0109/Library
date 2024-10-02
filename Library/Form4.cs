using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form4 : Form
    {
        Book book=new Book();
        Context context = new Context();
        bool IsExisting=false;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitel.Text))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var quere=context.Books.ToList();
                foreach(var item in quere)
                {
                    if (item.Title == txtTitel.Text)
                    {
                        IsExisting = true;
                        break;
                    }
                  
                }
                if (!IsExisting)
                {
                    MessageBox.Show("The book is not found, please re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTitel.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("The book has been ordered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var quere = context.Books.ToList();
            foreach (var book in quere)
            {
                var item = new ListViewItem(book.Title);
                item.SubItems.Add(book.Genre);
                item.SubItems.Add(book.price.ToString());
                listView1.Items.Add(item);
            }

        }
    }
}
