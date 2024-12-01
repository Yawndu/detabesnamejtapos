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
    public partial class frmAdd : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Kyle\\Downloads\\Finals ACT 1\\dbPhone.mdb";
        OleDbConnection conn;
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT into model(model_desc, price, brandid) values(@model, @price, @brand)";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@model", txtmodel.Text);
            cmd.Parameters.AddWithValue("@price", txtprice.Text);
            cmd.Parameters.AddWithValue("@brand", cbobrand.SelectedIndex);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("INPUT ADDED");
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            string query = "select * from brand";
            DataTable dt = new DataTable();
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            string getValue;
            cbobrand.DataSource = dt;
            cbobrand.DisplayMember = "brand";
            cbobrand.ValueMember = "brandid";

            getValue = cbobrand.SelectedValue.ToString();
        }
    }
}
