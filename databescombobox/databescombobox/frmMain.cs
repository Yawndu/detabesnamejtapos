using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace databescombobox
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        
        }

        private void btnMainAdd_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();
        }

        private void btnMainUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate update = new frmUpdate(); 
            update.ShowDialog();
        }

        private void btnMainDelete_Click(object sender, EventArgs e)
        {
            frmDelete delete = new frmDelete(); 
            delete.ShowDialog();
        }

        private void btnMainSearch_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch();
            search.ShowDialog();
        }
    }
}
