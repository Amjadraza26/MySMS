using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class ClassTeachers
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conClassTeachers;
		SqlCommand comClassTeachers;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daClassTeachers;
		DataSet dsClassTeachers;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public ClassTeachers(string strConnString)
        {
			strConnectionString = strConnString;
			conClassTeachers = new SqlConnection(strConnectionString);
			comClassTeachers = new SqlCommand();
			daClassTeachers = new SqlDataAdapter();
			dsClassTeachers = new DataSet();
		}//end constructor
    
		public ClassTeachers()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conClassTeachers = new SqlConnection(strConnectionString);
			comClassTeachers = new SqlCommand();
			daClassTeachers = new SqlDataAdapter();
			dsClassTeachers = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conClassTeachers.Open();
			comClassTeachers.Connection = conClassTeachers;
			comClassTeachers.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comClassTeachers.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comClassTeachers.CommandType = CommandType.StoredProcedure;
			daClassTeachers.SelectCommand = comClassTeachers;
			daClassTeachers.Fill(dsClassTeachers);
			conClassTeachers.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsClassTeachers.Tables.Add(dtErrorTable);
		}

		public DataSet SelectClassTeachers()
		{
			try
			{
				ConnectAndExecute("ClassTeachersSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsClassTeachers;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsClassTeachers;
			}//end try
		}//end function

		public DataSet SelectClassTeachers(int intClassTeacherID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@ClassTeacherID";
				objParameter.Value = intClassTeacherID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("GetClassTeachersByID", objParameterList);
				return dsClassTeachers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassTeachers;
			}
		}
		
		public DataSet InsertUpdateClassTeachers(Int64 intClassTeacherID, Int64 intClassID, Int64 intSectionID, Int64 intSubjectID, Int64 intTeacherID, Int64 intUserID, bool blnIsEnabled, DateTime datDateCreated, string strRemarks)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@ClassTeacherID";
objParameter.Value = intClassTeacherID;
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
objParameter.ParameterName = "@SubjectID";
objParameter.Value = intSubjectID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@TeacherID";
objParameter.Value = intTeacherID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@UserID";
objParameter.Value = intUserID;
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

				//end parameter setting
			
				ConnectAndExecute("InsertUpdateClassTeachers", objParameterList);
				return dsClassTeachers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassTeachers;
			}
		}

		public DataSet DeleteClassTeachers(int intClassTeacherID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@ClassTeacherID";
				objParameter.Value = intClassTeacherID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("DeleteByIDClassTeachers", objParameterList);
				return dsClassTeachers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassTeachers;
			}
		}
    
		public DataSet DeleteClassTeachers()
		{
			try
			{
				ConnectAndExecute("DeleteAllClassTeachers", new ArrayList()); //no parameter will send to stored procedure
				return dsClassTeachers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassTeachers;
			}
		}
    
		public DataSet ClassTeachersTruncate()
        {
			try
			{
				ConnectAndExecute("ClassTeachersTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsClassTeachers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassTeachers;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
