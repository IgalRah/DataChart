using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataChart.DataAccess
{
    class DAL
    {
        public static string strCon = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;

        public static List<DataTable> GetData(string selectCommand)
        {
            List<DataTable> tables = new List<DataTable>();
            DataSet ds = new DataSet();

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, strCon);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataAdapter.Fill(ds);

                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    tables.Add(ds.Tables[i]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tables;
        }
    }
}
