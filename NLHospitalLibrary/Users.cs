using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NLHospitalLibrary
{
    /// <summary>
    /// Summary description for Users.
    /// </summary>
    public class Users
    {
        private SqlConnection mOCn;
        private readonly SqlDataAdapter mODa;

        public Users()
        {
            InitializeConnection();

            const string sSql = "SELECT UserName, Password FROM Login ";

            var oSelCmd = new SqlCommand(sSql, mOCn) { CommandType = CommandType.Text };

            mODa = new SqlDataAdapter { SelectCommand = oSelCmd };

            mOCn = null;
        }

        public DataSet FindData(string id, string pass)
        {
            InitializeConnection();

            mOCn.Open();

            var thisDataSet = new DataSet();

            var foundDataSet = new DataSet();

            try
            {
                mODa.Fill(thisDataSet, "Login");

                for (var n = 0; n < thisDataSet.Tables["Login"].Rows.Count; n++)
                {
                    if (thisDataSet.Tables["Login"].Rows[n]["UserName"].ToString() != id) continue;

                    if (thisDataSet.Tables["Login"].Rows[n]["Password"].ToString() == pass)
                    {
                        mODa.Fill(foundDataSet, n, 1, "Login");
                    }
                }
            }
            catch (Exception exception)
            {
                // ignored
                MessageBox.Show(exception.Message);
            }
            finally
            {
                mOCn.Close();

                mOCn = null;
            }

            return foundDataSet;
        }

        private void InitializeConnection()
        {
            mOCn = new SqlConnection(
                @"Data Source=.;Integrated Security=SSPI;"
                + "Initial Catalog=NLHospital");
        }
    }
}
