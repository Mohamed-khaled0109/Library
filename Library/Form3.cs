using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form3 : Form
    {
        Context context=new Context();
        Book book=new Book();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text) || string.IsNullOrWhiteSpace(txtTitel.Text) || string.IsNullOrWhiteSpace(txtprice.Text) || string.IsNullOrWhiteSpace(txtGenre.Text) || string.IsNullOrWhiteSpace(txtAutherId.Text))
            {
                MessageBox.Show("All fields are required");

            }
            else
            {
                book.Title = txtTitel.Text;
                book.Description = txtDescription.Text;
                book.Genre = txtGenre.Text;
                book.price = double.Parse(txtprice.Text);
                book.AutherId = int.Parse(txtAutherId.Text);
                context.Books.Add(book);
                context.SaveChanges();
                MessageBox.Show("The book has been added successfully", "Success", MessageBoxButtons.OK);
                Relese();

            }
        }

        public void Relese()
        {
            txtTitel.Text=string.Empty;
            txtDescription.Text=string.Empty;
            txtGenre.Text=string.Empty;
            txtprice.Text=string.Empty;
            txtAutherId.Text=string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                int ID=int.Parse(txtId.Text);
                var quere=context.Books.ToList();
                foreach(var item in  quere)
                {
                    if (item.Id == ID)
                    {
                        context.Books.Remove(item);
                    }
                }
                context.SaveChanges();
                Relese();
                MessageBox.Show("The book has been deleted successfully", "Success", MessageBoxButtons.OK);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var quere = context.Books.ToList();
            foreach (var book in quere)
            {
                var item = new ListViewItem(book.Id.ToString());
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Description);
                item.SubItems.Add(book.Genre);
                item.SubItems.Add(book.AutherId.ToString());
                listView1.Items.Add(item);
            }

        }
    }
}
