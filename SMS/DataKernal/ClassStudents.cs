using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class ClassStudents
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conClassStudents;
		SqlCommand comClassStudents;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daClassStudents;
		DataSet dsClassStudents;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public ClassStudents(string strConnString)
        {
			strConnectionString = strConnString;
			conClassStudents = new SqlConnection(strConnectionString);
			comClassStudents = new SqlCommand();
			daClassStudents = new SqlDataAdapter();
			dsClassStudents = new DataSet();
		}//end constructor
    
		public ClassStudents()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conClassStudents = new SqlConnection(strConnectionString);
			comClassStudents = new SqlCommand();
			daClassStudents = new SqlDataAdapter();
			dsClassStudents = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conClassStudents.Open();
			comClassStudents.Connection = conClassStudents;
			comClassStudents.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comClassStudents.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comClassStudents.CommandType = CommandType.StoredProcedure;
			daClassStudents.SelectCommand = comClassStudents;
			daClassStudents.Fill(dsClassStudents);
			conClassStudents.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsClassStudents.Tables.Add(dtErrorTable);
		}

		public DataSet SelectClassStudents()
		{
			try
			{
				ConnectAndExecute("ClassStudentsSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsClassStudents;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsClassStudents;
			}//end try
		}//end function

		public DataSet SelectClassStudents(int intClassStudentID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@ClassStudentID";
				objParameter.Value = intClassStudentID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("GetClassStudentsByID", objParameterList);
				return dsClassStudents;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassStudents;
			}
		}
		
		public DataSet InsertUpdateClassStudents(Int64 intClassStudentID, Int64 intClassID, Int64 intSectionID, Int64 intStudentID, Int64 intUserID, DateTime datDateCreated, bool blnIsEnabled, string strRemarks, Int64 intRollNo)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@ClassStudentID";
objParameter.Value = intClassStudentID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@ClassID";
objParameter.Value = intClassID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@SectionID";
objParameter.Value = intSectionID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@StudentID";
objParameter.Value = intStudentID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@UserID";
objParameter.Value = intUserID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@DateCreated";
objParameter.Value = datDateCreated;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@IsEnabled";
objParameter.Value = blnIsEnabled;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@Remarks";
objParameter.Value = strRemarks;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@RollNo";
objParameter.Value = intRollNo;
objParameterList.Add(objParameter);

				//end parameter setting
			
				ConnectAndExecute("InsertUpdateClassStudents", objParameterList);
				return dsClassStudents;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassStudents;
			}
		}

		public DataSet DeleteClassStudents(int intClassStudentID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@ClassStudentID";
				objParameter.Value = intClassStudentID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("DeleteByIDClassStudents", objParameterList);
				return dsClassStudents;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassStudents;
			}
		}
    
		public DataSet DeleteClassStudents()
		{
			try
			{
				ConnectAndExecute("DeleteAllClassStudents", new ArrayList()); //no parameter will send to stored procedure
				return dsClassStudents;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassStudents;
			}
		}
    
		public DataSet ClassStudentsTruncate()
        {
			try
			{
				ConnectAndExecute("ClassStudentsTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsClassStudents;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassStudents;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
