using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;
using DataChart.DataAccess;

namespace DataChart
{
    public partial class DataChart : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;

        public DataChart()
        {
            InitializeComponent();
        }

        private void Menu_Screen(object sender, EventArgs e) // Menu Screen
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd1 = new("Select * from Person", sqlCon); // Show all data
                    dt.Load(sqlCmd1.ExecuteReader());
                    dataGridViewUpper.DataSource = dt;


                    // Fix the frame
                    dataGridViewUpper.AutoResizeRows();
                    dataGridViewLower.AutoResizeRows();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                List<DataTable> tables = DAL.GetData("Select FirstName + ' ' + LastName as 'Full name' from Person");
                dataGridViewLower.DataSource = tables[0];
            }
        }

        private void addButton(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new() // Insert data through win form
                    {
                        Connection = sqlCon,
                        CommandText = "SpAddPerson",
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCmd.Parameters.AddWithValue("@FirstName", boxFirstName.Text);
                    sqlCmd.Parameters.AddWithValue("@LastName", boxLastName.Text);

                    SqlParameter outPutParam = new()
                    {
                        ParameterName = "@Id",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    sqlCmd.Parameters.Add(outPutParam);
                    

                    if (string.IsNullOrWhiteSpace(boxFirstName.Text) || string.IsNullOrWhiteSpace(boxLastName.Text))
                    {
                        MessageBox.Show("First name and last name required!");
                    }
                    else
                    {
                        sqlCmd.ExecuteNonQuery();
                    }


                    boxFirstName.Clear();
                    boxLastName.Clear();

                    SqlCommand sqlCmd1 = new("Select * from Person", sqlCon); // Show all data
                    dt.Load(sqlCmd1.ExecuteReader());
                    dataGridViewUpper.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } // Add data button

        private void deleteButton(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                try
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new()
                    {
                        Connection = sqlCon,
                        CommandText = "SpDeletePerson",
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCmd.Parameters.AddWithValue("@Id", boxId.Text);
                    

                    if (string.IsNullOrEmpty(boxId.Text))
                    {
                        MessageBox.Show("Id is required!");
                    }
                    else
                    {
                        var cmd = new SqlCommand("Select * from Person where Id='" + boxId.Text + "'", sqlCon);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            sqlCmd.ExecuteNonQuery();
                            SqlCommand sqlCmd1 = new("Select * from Person", sqlCon); // Show all data
                            dt.Load(sqlCmd1.ExecuteReader());
                            dataGridViewUpper.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Id not found!");
                        }
                    }
                    
                    boxId.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } // Delete data button

        private void getPersonButton(object sender, EventArgs e) // Get Person Button
        {

            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                DataTable dt = new();
                try
                {
                    sqlCon.Open();

                    SqlCommand sqlCmdId = new()
                    {
                        Connection = sqlCon,
                        CommandText = "SpGetPersonById",
                        CommandType = CommandType.StoredProcedure

                    };
                    sqlCmdId.Parameters.AddWithValue("@Id", boxGetPerson.Text);


                    if (string.IsNullOrEmpty(boxGetPerson.Text))
                    {
                        MessageBox.Show("Id is required!");
                    }
                    else
                    {
                        var cmd = new SqlCommand("Select * from Person where Id='" + boxGetPerson.Text + "'",sqlCon);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            sqlCmdId.ExecuteNonQuery();
                            dataGridViewLower.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Id not found!");
                        }
                    }

                    boxGetPerson.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void refreshButton(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                try
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd1 = new("Select * from Person", sqlCon); // Show all data
                    dt.Load(sqlCmd1.ExecuteReader());
                    dataGridViewUpper.DataSource = dt;

                    dataGridViewLower.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    List<DataTable> tables = DAL.GetData("Select FirstName + ' ' + LastName as 'Full name' from Person");
                    dataGridViewLower.DataSource = tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } // Refresh Button 

        private void GetMultipeResults()
        {
            using (SqlConnection sqlCon = new SqlConnection())
            {
                using (SqlCommand sqlCmd = new SqlCommand("Select Id from Person ; Select FirstName + LastName as 'Full Name'", sqlCon))
                {
                    sqlCon.Open();
                    SqlDataReader reader = sqlCmd.ExecuteReader();

                    DataTable dtId = new DataTable();
                    DataTable dtFullName = new DataTable();

                    dtId.Load(reader);
                    dtFullName.Load(reader);

                    dataGridViewLower.DataSource = dtId;
                    dataGridViewLower.DataSource = dtFullName;
                }
            }
        } // Not in use
    }
}
