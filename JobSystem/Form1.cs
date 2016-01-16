using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace JobSystem
{
    public partial class Form1 : Form
    {

        
        #region "Globals"


        //SQL
        bool connectionGood;
        string connStr = "Server=MRC-FILE-1;Database=MRC DataBase;User ID=balls;Password=balls"; //?????
        string updateCommand = "UPDATE JobCard SET JName = @JName, JDescription = @JDescription, JWarrenty = @JWarrenty, JHoursEstmated = @JHoursEstmated, JHoursTook = @JHoursTook, JPrice = @JPrice, JSquares = @JSquares, JDate = @JDate WHERE JID = @JID";
        string insertCommand = "INSERT INTO JobCard (JName, JDescription, JWarrenty, JHoursEstmated, JHoursTook, JPrice, JSquares, JDate) VALUES (@JName,@JDescription,@JWarrenty,@JHoursEstmated,@JHoursTook,@JPrice,@JSquares,@JDate)";
        string selectCommand = "SELECT * FROM JobCard";
        string deleteCommand = "DELETE FROM JobCard WHERE JID = @JID";
        int i = 0;

        //Global Vars
        SqlConnection myConnection;

        public struct jd
        {
            public int JID;
            public string JName;
            public string JDescription;
            public string JWarrenty;
            public decimal JHoursEstimated;
            public decimal JHoursTook;
            public decimal JPrice;
            public decimal JSqaures;
            public DateTime JDate;
        }

        List<jd> JobCardRows = new List<jd>();

        #endregion 

        public Form1()
        {
            InitializeComponent();
            startUp();
        }


        void startUp()
        {
            //initialize SQL
            connectionGood = iniSQL();
            //if (connectionGood) MessageBox.Show("Good Connection");
            loadJobCardRows();
            displayRecord(i);

        }

        void displayRecord(int i)
        {
            lblID.Text = JobCardRows[i].JID.ToString();
            dateTextBox.Text = JobCardRows[i].JDate.ToString("mM/dd/yyyy");
            job_NameTextBox.Text = JobCardRows[i].JName;
            descriptionTextBox.Text = JobCardRows[i].JDescription;
        }


        //initializes and test SQL Connection
        bool iniSQL()
        {
            myConnection = new SqlConnection(connStr);
            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                myConnection.Close();
            }
            return true;
        }

        //loads list with data
        void loadJobCardRows()
        {
            JobCardRows.Clear();
            myConnection = new SqlConnection(connStr);
            try
            {

                myConnection.Open();
                SqlCommand selectAllCmd = new SqlCommand(selectCommand, myConnection);
                SqlDataReader myDataReader = selectAllCmd.ExecuteReader();
                while(myDataReader.Read())
                {                  
                    jd newrow = new jd();
                    newrow.JID = (int)myDataReader[0];
                    if(!myDataReader.IsDBNull(1)) newrow.JName = (string)myDataReader[1];
                    if(!myDataReader.IsDBNull(2)) newrow.JDescription = (string)myDataReader[2];
                    if (!myDataReader.IsDBNull(3)) newrow.JWarrenty = (string)myDataReader[3];
                    if (!myDataReader.IsDBNull(4)) newrow.JHoursEstimated = (decimal)myDataReader[4];
                    if (!myDataReader.IsDBNull(5)) newrow.JHoursTook = (decimal)myDataReader[5];
                    if (!myDataReader.IsDBNull(6)) newrow.JPrice = (decimal)myDataReader[6];
                    if (!myDataReader.IsDBNull(7)) newrow.JSqaures = (decimal)myDataReader[7];
                    if (!myDataReader.IsDBNull(8)) newrow.JDate= (DateTime)myDataReader[8];
                    JobCardRows.Add(newrow);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            finally
            {
                myConnection.Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(i != JobCardRows.Count - 1) i++;
            displayRecord(i);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(i != 0)  i--;            
            displayRecord(i);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                clearForm();
                btnNew.Text = "Insert";
            }
            else
            {
                bool success = insertInto();
                btnNew.Text = "New";
            }
        }

        void clearForm()
        {
            lblID.Text = "New";
            dateTextBox.Clear();
            squaresTextBox.Clear();
            job_NameTextBox.Clear();
            descriptionTextBox.Clear();
            time_EstimatedTextBox.Clear();
            time_TookTextBox.Clear();
            cmbWarranty.Items.Clear();
            costTextBox.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                myConnection = new SqlConnection(connStr);
                try
                {
                    myConnection.Open();

                    SqlCommand deleteCmd = new SqlCommand(deleteCommand, myConnection);
                    deleteCmd.Parameters.AddWithValue("@JID", int.Parse(lblID.Text));
                    deleteCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    myConnection.Close();
                    loadJobCardRows();
                    i = 0;
                    displayRecord(i);
                }
            }
        }


        bool insertInto()
        {

            myConnection = new SqlConnection(connStr);
            try
            {
                decimal estimatedHours;
                decimal actualHours;
                decimal price;
                decimal squares;
                DateTime date;

                if (job_NameTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please enter a Job Name.");
                    return false;
                }

                if(!decimal.TryParse(time_EstimatedTextBox.Text.Trim(), out estimatedHours))
                {
                    MessageBox.Show("Estimated Hours is not a valid value.", "No Good");
                    return false;
                }
                if (!decimal.TryParse(time_TookTextBox.Text.Trim(), out actualHours))
                {
                    MessageBox.Show("Actual Hours is not a valid value.", "No Good");
                    return false;
                }
                if (!decimal.TryParse(costTextBox.Text.Trim(), out price))
                {
                    MessageBox.Show("Price is not a valid value. Do not include \'$\'", "No Good");
                    return false;
                }
                if (!decimal.TryParse(squaresTextBox.Text.Trim(), out squares))
                {
                    MessageBox.Show("Square is not a valid value.", "No Good");
                    return false;
                }
                if (!DateTime.TryParse(dateTextBox.Text.Trim(), out date))
                {
                    MessageBox.Show("Date format not valid.", "No Good");
                    return false;
                }

                myConnection.Open();
                SqlCommand insertCmd = new SqlCommand(insertCommand, myConnection);
                insertCmd.Parameters.AddWithValue("@JName", job_NameTextBox.Text.Trim());
                insertCmd.Parameters.AddWithValue("@JDescription", descriptionTextBox.Text.Trim());
                insertCmd.Parameters.AddWithValue("@JWarrenty", "THIS IS A WARRANTY");
                insertCmd.Parameters.AddWithValue("@JHoursEstmated", estimatedHours);
                insertCmd.Parameters.AddWithValue("@JHoursTook", actualHours);
                insertCmd.Parameters.AddWithValue("@JPrice", price);
                insertCmd.Parameters.AddWithValue("@JSquares", squares);
                insertCmd.Parameters.AddWithValue("@JDate", date);
                insertCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                myConnection.Close();
            }
            return true;
        }







    }
}
