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
    public partial class FileEntryForm : Form
    {
        public FileEntryForm()
        {
            InitializeComponent();
        }

        private void CheckContentBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileEntryContents.FileContentsForm fc = new FileEntryContents.FileContentsForm();
            fc.ShowDialog();
        }

        private void BackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mp = new MainPage();
            mp.ShowDialog();
        }

        private void SaveFromFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileEntryContents.SaveFromFile sf = new FileEntryContents.SaveFromFile();
            sf.ShowDialog();

        }
    }
}
