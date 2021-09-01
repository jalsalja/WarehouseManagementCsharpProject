using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppWarehouseManagement.LogInFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(textUsername.Text == "admin" && textPassword.Text == "1234")
            {
                MessageBox.Show("Succeed", "Succeed");
                this.Hide();
                MainPage mp= new MainPage();
                mp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Fail", "Error");
            }
        }
    }
}
