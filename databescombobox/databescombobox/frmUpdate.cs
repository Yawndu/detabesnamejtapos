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
    public partial class frmUpdate : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Kyle\\Downloads\\Finals ACT 1\\dbPhone.mdb";
        OleDbConnection conn;
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            string query = "select * from brand";
            DataTable dt = new DataTable();
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            string getValue;
            cboBrand.DataSource = dt;
            cboBrand.DisplayMember = "brand";
            getValue = cboBrand.SelectedIndex.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE model set price = @price, brandid = @brand where model_desc = '"+txtModel.Text+"'";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cmd.Parameters.AddWithValue("brand", cboBrand.SelectedIndex.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("INPUT UPDATED");
        }
    }
}
