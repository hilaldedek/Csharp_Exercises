using game_WindowsFormApp3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_WindowsFormApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account account=new Account();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            account.userName = txtUserName.Text;
            account.race=cmbIrk.SelectedItem.ToString();
            account.branch=cmbBrans.SelectedItem.ToString();
            account.weapon=txtSilah.Text;
            ChangeState(false);
            ChangeVisible(true);
        }
        public void ChangeState(bool state)
        {
            txtUserName.Enabled = state;
            txtSilah.Enabled = state;
            cmbBrans.Enabled = state;
            cmbIrk.Enabled = state; 
            btnSelect.Enabled = state;
        }
        public void ChangeVisible(bool isVisible)
        {
            labelHealth.Visible=wolfman.Visible=btnAttact.Visible=isVisible;
        }

        private void btnAttact_Click(object sender, EventArgs e)
        {
            account.Attact();
            labelHealth.Width -= account.damage;
            MessageBox.Show($"Düşmana {account.damage} kadar hasar verdiniz.");
            if( labelHealth.Width<=0 )
            {
                MessageBox.Show("Düşmana yendiniz!");
                wolfman.Visible = false;
            }
        }
    }
}
