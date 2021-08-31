﻿using System;
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
    public partial class ViewAllWO : Form
    {
        public ViewAllWO()
        {
            InitializeComponent();
            DbFileEntry.ViewAllPO(dataGridView1, "SELECT DISTINCT wonum, description from wo");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DbFileEntry db = new DbFileEntry();
            if (e.ColumnIndex == 0)
            {
                this.Hide();
                WorkOrder po = new WorkOrder(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), 0, dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                po.Show();
                this.Close();
            }
            if (e.ColumnIndex == 1)
            {
                this.Hide();
                string num = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                DbFileEntry.DeletePO(num, false);
                ViewAllWO po = new ViewAllWO();
                po.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Close();
        }
    }
}
