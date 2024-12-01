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
    public partial class frmSearch : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Kyle\\Downloads\\Finals ACT 1\\dbPhone.mdb";
        OleDbConnection conn;
        
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select model_desc as MODEL, price as PRICE, brandid as BRAND from model where model_desc ='"+txtKeyword.Text+ "' or price = '"+txtKeyword.Text+"' and brandid = '"+txtKeyword.Text+"'";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter adpater = new OleDbDataAdapter(query, conn);
            adpater.Fill(dt);
            conn.Close();

            grdResult.DataSource = dt;
        }
    }
}
