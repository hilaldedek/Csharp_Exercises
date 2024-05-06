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
    public partial class Login : Form
    {
        public Login(User _user)
        {
            InitializeComponent();
            user = _user;
        }
        User user; //Login formu oluşturulurken bir User nesnesi verilir ve bu nesne user değişkenine atanır.
        private void Form2_Load(object sender, EventArgs e)
        {
            lblMessage.Text = $"Hoşgeldiniz {user.username}";
        }
    }
}
