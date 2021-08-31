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
    public partial class WorkOrder : Form
    {
        string poNum;
        string description;
        int create;
        public WorkOrder(string poNum, int create, string description)
        {
            InitializeComponent();
            poNumLab.Text = $"WO# {poNum}";
            descLab.Text = $"{description}";
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
            DbFileEntry.DisplayPO($"SELECT item_number, item_name, qty from wo where wonum = {poNum}", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DbFileEntry db = new DbFileEntry();
            if (e.ColumnIndex == 0)
            {
                this.Hide();
                db.AddToInventory(poNum, dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), 0);
                WorkOrder po = new WorkOrder(poNum, 0, description);
                po.Show();
                this.Close();
            }
            if (e.ColumnIndex == 1)
            {
                this.Hide();
                string num = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                DbFileEntry.DeletePOFile(poNum, num, false);
                WorkOrder po = new WorkOrder(poNum, 0, description);
                po.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            POWOAddItem a = new POWOAddItem(poNum, description, 1, false);
            a.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileEntryContents.ViewAllWO purO = new FileEntryContents.ViewAllWO();
            purO.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Close();
        }
    }
}
