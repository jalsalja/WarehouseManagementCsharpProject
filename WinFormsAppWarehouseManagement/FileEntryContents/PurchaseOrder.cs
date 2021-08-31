using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppWarehouseManagement.FileEntryContents
{
    public partial class PurchaseOrder : Form
    {
        string poNum;
        string description;
        int create;
        public PurchaseOrder(string poNum, int create, string description)
        {
            InitializeComponent();
            poNumLabel.Text = $"PO# {poNum}";
            descLabel.Text = $"{description}";
            this.poNum = poNum;
            this.create = create;
            this.description = description;
            if (create != 1)
            {
                View();
            }
        }

        private void View()
        {
            DbFileEntry.DisplayPO($"SELECT item_number, item_name, qty_ordered from po where PO = {poNum}", dataGridView1);
        }
        

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DbFileEntry db = new DbFileEntry();
            if (e.ColumnIndex == 0)
            {
                this.Hide();
                db.AddToInventory(poNum, dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), 1);
                PurchaseOrder po = new PurchaseOrder(poNum, 0, description);
                po.Show();
                this.Close();
            }
            if (e.ColumnIndex == 1)
            {
                this.Hide();
                string num = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                DbFileEntry.DeletePOFile(poNum, num, true);
                PurchaseOrder po = new PurchaseOrder(poNum, 0, description);
                po.Show();
                this.Close();
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            POWOAddItem a = new POWOAddItem(poNum, description, 1, true);
            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllPO po = new ViewAllPO();
            po.Show();
            this.Close();
        }
    }
}
