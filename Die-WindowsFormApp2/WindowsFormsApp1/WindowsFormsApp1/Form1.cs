using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random1= new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int number1=random1.Next(1,6);
            DieText.Text ="DIE RESULT: "+ " " +number1.ToString();
        }
    }
}
