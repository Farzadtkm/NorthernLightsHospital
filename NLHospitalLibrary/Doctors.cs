using System;
using System.Data;
using System.Data.SqlClient;


namespace NLHospitalLibrary
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    public class Doctors
    {
        private DataSet mODs;
        private SqlConnection mOCn;
        private readonly SqlDataAdapter mODa;
        private const string MsClassName = "Doctors";

        public Doctors()
        {
            InitializeConnection();

            var sSql = "SELECT DoctorID, LastName, FirstName, Specialty " +
                       " FROM	Doctors " +
                       " ORDER BY DoctorID ";

            var oSelCmd = new SqlCommand(sSql, mOCn) { CommandType = CommandType.Text };


            sSql = "UPDATE Doctors " +
                   " SET LastName = @LastName, FirstName = @FirstName, Specialty = @Specialty " +
                   " WHERE DoctorID = @DoctorID ";

            var oUpdCmd = new SqlCommand(sSql, mOCn) { CommandType = CommandType.Text };

            oUpdCmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 30, "LastName"));

            oUpdCmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 30, "FirstName"));

            oUpdCmd.Parameters.Add(new SqlParameter("@Specialty", SqlDbType.NVarChar, 20, "Specialty"));

            oUpdCmd.Parameters.Add(new SqlParameter("@DoctorID", SqlDbType.NChar, 4, "DoctorID"));

            sSql = "INSERT INTO Doctors " +
                " (LastName, FirstName, Specialty)" +
                " VALUES (@LastName, @FirstName, @Specialty)";

            var oInsCmd = new SqlCommand(sSql, mOCn) { CommandType = CommandType.Text };

            oInsCmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 30, "LastName"));

            oInsCmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 30, "FirstName"));

            oInsCmd.Parameters.Add(new SqlParameter("@Specialty", SqlDbType.NVarChar, 20, "Specialty"));

            sSql = "DELETE Doctors " +
                   " WHERE DoctorID = @DoctorID ";

            var oDelCmd = new SqlCommand(sSql, mOCn) {CommandType = CommandType.Text};

            oDelCmd.Parameters.Add(new SqlParameter("@DoctorID", SqlDbType.NChar, 4, "DoctorID"));

            mODa = new SqlDataAdapter
            {
                SelectCommand = oSelCmd, 
                
                UpdateCommand = oUpdCmd, 
                
                DeleteCommand = oDelCmd, 
                
                InsertCommand = oInsCmd
            };

            mOCn = null;
        }

        public string AddData(string id, string lastName, string firstName, string specialty)
        {
            var message = "";

            try
            {
                InitializeConnection();

                mOCn.Open();

                var thisDataSet = new DataSet();

                mODa.Fill(thisDataSet, "Doctors");

                var keys = new DataColumn[1];

                keys[0] = thisDataSet.Tables["Doctors"].Columns["DoctorID"];

                thisDataSet.Tables["Doctors"].PrimaryKey = keys;

                var findRow = thisDataSet.Tables["Doctors"].Rows.Find(id);

                if (findRow == null)
                {
                    var thisRow = thisDataSet.Tables["Doctors"].NewRow();

                    thisRow["DoctorId"] = id;

                    thisRow["LastName"] = lastName;

                    thisRow["FirstName"] = firstName;

                    thisRow["Specialty"] = specialty;

                    thisDataSet.Tables["Doctors"].Rows.Add(thisRow);

                    if (thisDataSet.Tables["Doctors"].Rows.Find(id) != null)
                    {
                        message = " Doctor Record Was Added";
                    }
                }
                else
                {
                    message = " Doctor " + id + " already present in database.";
                }

                mODa.Update(thisDataSet, "Doctors");

            }
            catch (Exception e)
            {
                message = "Record was not added : " + e.Message;
            }
            finally
            {
                mOCn.Close();

                mOCn = null;
            }

            return message;
        }

        public DataSet FindData(string id)
        {
            InitializeConnection();
            mOCn.Open();
            DataSet thisDataSet = new DataSet();
            DataSet foundDataSet = new DataSet();
            try
            {
                mODa.Fill(thisDataSet, "Doctors");
                for (int n = 0; n < thisDataSet.Tables["Doctors"].Rows.Count; n++)
                {
                    if (thisDataSet.Tables["Doctors"].Rows[n]["DoctorID"].ToString() == id)
                    {
                        mODa.Fill(foundDataSet, n, 1, "Doctors");
                    }
                }
            }
            catch
            {
                // ignored
            }
            finally
            {
                mOCn.Close();
                mOCn = null;
            }
            return foundDataSet;
        }

        public string UpdateData(string id, string lastName, string firstName, string specialty)
        {
            var sMsg = "";

            try
            {
                InitializeConnection();
                
                mOCn.Open();
                
                var thisDataSet = new DataSet();
                
                mODa.Fill(thisDataSet, "Doctors");

                thisDataSet.Tables["Doctors"].Rows[0]["DoctorID"] = id;
                
                thisDataSet.Tables["Doctors"].Rows[0]["LastName"] = lastName;
                
                thisDataSet.Tables["Doctors"].Rows[0]["FirstName"] = firstName;
                
                thisDataSet.Tables["Doctors"].Rows[0]["Specialty"] = specialty;
                
                mODa.Update(thisDataSet, "Doctors");
            }
            catch (Exception e)
            {
                sMsg = "Record was not updated" + e.Message;
            }
            finally
            {
                mOCn.Close();
                
                mOCn = null;
            }

            return sMsg;
        }

        public string DeleteData(string id)
        {
            string sMsg;

            try
            {
                InitializeConnection();
                
                mOCn.Open();
                
                var thisDataSet = new DataSet();
                
                mODa.Fill(thisDataSet, "Doctors");

                var keys = new DataColumn[1];
                
                keys[0] = thisDataSet.Tables["Doctors"].Columns["DoctorID"];
                
                thisDataSet.Tables["Doctors"].PrimaryKey = keys;
                
                var findRow = thisDataSet.Tables["Doctors"].Rows.Find(id);

                if (findRow == null)
                {
                    sMsg = " Doctor " + id + " not present in database.";
                }
                else
                {
                    findRow.Delete();
                    
                    mODa.Update(thisDataSet, "Doctors");
                    
                    sMsg = " Doctor " + id + " deleted from database.";
                }
            }
            catch (Exception e)
            {
                sMsg = "Record was not deleted" + e.Message;
            }
            finally
            {
                mOCn.Close();
                
                mOCn = null;
            }

            return sMsg;
        }

        public string SaveData(DataSet oDs)
        {
            string message;
            
            SqlTransaction oTran = null;

            try
            {
                InitializeConnection();
                
                mOCn.Open();
                
                oTran = mOCn.BeginTransaction();
                
                long lRecordsAffected = mODa.Update(oDs, MsClassName);
                
                oTran.Commit();
                
                message = lRecordsAffected + " Doctor Records Were Updated";
            }
            catch (Exception e)
            {
                oTran?.Rollback();
                
                message = "Records were not updated" + e.Message;
            }
            finally
            {
                mOCn.Close();
             
                mOCn = null;
            }

            return message;
        }

        public DataSet GetData()
        {
            mODs = new DataSet();
            
            mODa.Fill(mODs, MsClassName);
            
            return mODs;
        }

        private void InitializeConnection()
        {
            mOCn = new SqlConnection(
                @"Data Source=(local);Integrated Security=SSPI;"
                + "Initial Catalog=NLHospital");
        }
    }
}
