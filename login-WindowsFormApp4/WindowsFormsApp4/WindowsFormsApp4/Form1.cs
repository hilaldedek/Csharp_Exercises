using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Models;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1() //Form1 sınıfının constructor'ı
        {
            InitializeComponent(); //Formun oluşturulmasını sağlayan method
        }
        User user; //user, User sınıfının bir örneği
        private void Form1_Load(object sender, EventArgs e) //form yüklendiğinde gerçekleşecek olaylar
        {
            user = new User("hilal", "123"); //User adında bir nesne oluşturulur ve nesnenin kullanıcı adı ve parolası atanır.
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username=txtUsername.Text;
            string password=txtPassword.Text;   
            if(username==user.username && password == user.password)
            {
                //bu if bloğuna girildiyse Login formundan bir örnek oluşturulur ve login.Show() ile bu Login formu gösterilir. this.Hide() ile de mevcut form gizlenir. 
                Login login = new Login(user);
                login.Show();
                this.Hide();    
            }
            else
            {
                MessageBox.Show("Authentication Error!");
            }
        }
    }
}
