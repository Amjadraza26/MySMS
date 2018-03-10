using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class Students
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conStudents;
		SqlCommand comStudents;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daStudents;
		DataSet dsStudents;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public Students(string strConnString)
        {
			strConnectionString = strConnString;
			conStudents = new SqlConnection(strConnectionString);
			comStudents = new SqlCommand();
			daStudents = new SqlDataAdapter();
			dsStudents = new DataSet();
		}//end constructor
    
		public Students()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conStudents = new SqlConnection(strConnectionString);
			comStudents = new SqlCommand();
			daStudents = new SqlDataAdapter();
			dsStudents = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conStudents.Open();
			comStudents.Connection = conStudents;
			comStudents.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comStudents.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comStudents.CommandType = CommandType.StoredProcedure;
			daStudents.SelectCommand = comStudents;
			daStudents.Fill(dsStudents);
			conStudents.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsStudents.Tables.Add(dtErrorTable);
		}

		public DataSet SelectStudents()
		{
			try
			{
				ConnectAndExecute("StudentsSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsStudents;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsStudents;
			}//end try
		}//end function

		public DataSet SelectStudents(int intStudentID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@StudentID";
				objParameter.Value = intStudentID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("GetStudentsByID", objParameterList);
				return dsStudents;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsStudents;
			}
		}
		
		public DataSet InsertUpdateStudents(Int64 intStudentID, string strStudentName, string strFatherName, bool blnGender, string strCNIC, DateTime datDOB, string strEmail, string strContactNo, string strAddress, string strImage, bool blnDisability, bool blnDiscounted, bool blnIsEnabled, DateTime datDateCreated, string strRemarks, Int64 intUserID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@StudentID";
objParameter.Value = intStudentID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@StudentName";
objParameter.Value = strStudentName;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@FatherName";
objParameter.Value = strFatherName;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@Gender";
objParameter.Value = blnGender;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@CNIC";
objParameter.Value = strCNIC;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@DOB";
objParameter.Value = datDOB;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@Email";
objParameter.Value = strEmail;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@ContactNo";
objParameter.Value = strContactNo;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@Address";
objParameter.Value = strAddress;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@Image";
objParameter.Value = strImage;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@Disability";
objParameter.Value = blnDisability;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@Discounted";
objParameter.Value = blnDiscounted;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@IsEnabled";
objParameter.Value = blnIsEnabled;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@DateCreated";
objParameter.Value = datDateCreated;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@Remarks";
objParameter.Value = strRemarks;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@UserID";
objParameter.Value = intUserID;
objParameterList.Add(objParameter);

				//end parameter setting
			
				ConnectAndExecute("InsertUpdateStudents", objParameterList);
				return dsStudents;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsStudents;
			}
		}

		public DataSet DeleteStudents(int intStudentID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@StudentID";
				objParameter.Value = intStudentID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("DeleteByIDStudents", objParameterList);
				return dsStudents;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsStudents;
			}
		}
    
		public DataSet DeleteStudents()
		{
			try
			{
				ConnectAndExecute("DeleteAllStudents", new ArrayList()); //no parameter will send to stored procedure
				return dsStudents;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsStudents;
			}
		}
    
		public DataSet StudentsTruncate()
        {
			try
			{
				ConnectAndExecute("StudentsTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsStudents;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsStudents;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
