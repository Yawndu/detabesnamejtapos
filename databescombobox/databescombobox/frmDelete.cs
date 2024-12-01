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
    public partial class frmDelete : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Kyle\\Downloads\\Finals ACT 1\\dbPhone.mdb";
        OleDbConnection conn;
        public frmDelete()
        {
            InitializeComponent();
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE from model where model_desc = @model";
            conn = new OleDbConnection(connStr);    
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@model", txtModel.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("DELETED");

        }
    }
}
