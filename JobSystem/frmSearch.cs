using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JobSystem
{
    public partial class frmSearch : Form
    {
        SqlConnection myConnection;
        string connStr = "Server=MRCSERVER\\MRCSQLSERVER;Database=MRC DataBase;User ID=Freeman;Password=Freeman2"; 

        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            dgvSearch.Rows.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = tbSearch.Text.Trim();
            if (searchStr.Length < 1)
            {
                MessageBox.Show("Please enter a search phrase");
                tbSearch.Focus();
                return;
            }

            myConnection.ConnectionString = connStr;
            SqlCommand searchCmd = new SqlCommand();
            searchCmd.CommandType = CommandType.StoredProcedure;
            searchCmd.Connection = myConnection;
            //searchCmd.Parameters.Add(new SqlParameter("@searchStr", SqlDbType.VarChar));
            searchCmd.Parameters.AddWithValue("@searchStr", searchStr);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = searchCmd;
            try
            {
                myConnection.Open();
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "SearchJobCard");
                dgvSearch.DataSource = dataSet.Tables["SearchJobCard"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open) myConnection.Close();
            }

        }
    }
}
