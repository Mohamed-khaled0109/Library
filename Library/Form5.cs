using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    public partial class Form5 : Form
    {
        Context context = new Context();
        Registrars registrar = new Registrars();
        bool IsExisting = true;
        public Form5()
        {
            InitializeComponent();
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // 1. التحقق من أن جميع الحقول مملوءة
        //    if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
        //    {
        //        MessageBox.Show("All fields are required");
        //        return; // نخرج من الدالة لأن هناك خطأ
        //    }

        //    // 2. التحقق من وجود الاسم في قاعدة البيانات باستخدام LINQ
        //    IsExisting = context.Registrars.Any(r => r.Name == txtName.Text);

        //    // 3. إذا كان الاسم موجودًا
        //    if (IsExisting)
        //    {
        //        MessageBox.Show("The name is used before");
        //        relese(); // تفريغ الحقول
        //        return; // نخرج من الدالة لأن الاسم موجود
        //    }

        //    // 4. إذا لم يكن الاسم موجودًا، نضيف سجل جديد
        //    Registrars registrar = new Registrars
        //    {
        //        Name = txtName.Text,
        //        Phone = txtPhone.Text,
        //        Password = txtPassword.Text
        //    };

        //    context.Registrars.Add(registrar); // إضافة السجل الجديد
        //    context.SaveChanges(); // حفظ التغييرات في قاعدة البيانات

        //    // 5. إظهار رسالة نجاح وإغلاق النافذة
        //    MessageBox.Show("Registrar added successfully!");
        //    this.Close();
        //}

        // دالة إعادة تعيين الحقول




        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var quere = context.Registrars.ToList();
        //    foreach (var name in quere)
        //    {
        //        if (name.Name == txtName.Text)
        //        {
        //            IsExisting = true;
        //        }
        //    }

        //    if (string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
        //     {
        //         MessageBox.Show("All fields are required");
        //     }
        //    else
        //     {
        //         registrar.Name = txtName.Text;
        //         registrar.Password = txtPassword.Text;
        //         registrar.Phone = txtPhone.Text;

        //     }
        //    if (IsExisting)
        //    {
        //        MessageBox.Show("The name is used befor"); 
        //        relese();
        //    }
        //    else
        //    {  
        //         context.Registrars.Add(registrar);
        //        this.Close();
        //    }

        //    context.SaveChanges();
        //    relese();

        //}

        public void relese()
        {
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    relese();
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {

            // 1. التحقق من أن جميع الحقول مملوءة
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("All fields are required");
                return; // نخرج من الدالة لأن هناك خطأ
            }

            // 2. التحقق من وجود الاسم في قاعدة البيانات باستخدام LINQ
            IsExisting = context.Registrars.Any(r => r.Name == txtName.Text);

            // 3. إذا كان الاسم موجودًا
            if (IsExisting)
            {
                MessageBox.Show("The name is used before");
                relese(); // تفريغ الحقول
                return; // نخرج من الدالة لأن الاسم موجود
            }

            // 4. إذا لم يكن الاسم موجودًا، نضيف سجل جديد
            Registrars registrar = new Registrars
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Password = txtPassword.Text
            };

            context.Registrars.Add(registrar); // إضافة السجل الجديد
            context.SaveChanges(); // حفظ التغييرات في قاعدة البيانات

            // 5. إظهار رسالة نجاح وإغلاق النافذة
            MessageBox.Show("Registrar added successfully!");
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            relese();
        }
    }
}
