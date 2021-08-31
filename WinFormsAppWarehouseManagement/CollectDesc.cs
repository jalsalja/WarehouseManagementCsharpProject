using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppWarehouseManagement
{
    public partial class CollectDesc : Form
    {
        string poNum;
        string desc;
        int num;
        public CollectDesc(string poNum, int num)
        {
            this.num = num;
            this.poNum = poNum;
            InitializeComponent();
            label2.Text = $"#{poNum}";

        }

        private void continue_Click(object sender, EventArgs e)
        {
            if (num == 1) {
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show("please Write a Description", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    FileEntryContents.PurchaseOrder purO = new FileEntryContents.PurchaseOrder(poNum, 1, textBox1.Text);
                    purO.Show();
                }
            }
            else
            {
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show("please Write a Description", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    FileEntryContents.WorkOrder workO = new FileEntryContents.WorkOrder(poNum, 1, textBox1.Text);
                    workO.Show();
                }
            }
        }
    }
}
