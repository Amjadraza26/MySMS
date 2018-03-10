using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class StudentMarks
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conStudentMarks;
		SqlCommand comStudentMarks;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daStudentMarks;
		DataSet dsStudentMarks;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public StudentMarks(string strConnString)
        {
			strConnectionString = strConnString;
			conStudentMarks = new SqlConnection(strConnectionString);
			comStudentMarks = new SqlCommand();
			daStudentMarks = new SqlDataAdapter();
			dsStudentMarks = new DataSet();
		}//end constructor
    
		public StudentMarks()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conStudentMarks = new SqlConnection(strConnectionString);
			comStudentMarks = new SqlCommand();
			daStudentMarks = new SqlDataAdapter();
			dsStudentMarks = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conStudentMarks.Open();
			comStudentMarks.Connection = conStudentMarks;
			comStudentMarks.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comStudentMarks.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comStudentMarks.CommandType = CommandType.StoredProcedure;
			daStudentMarks.SelectCommand = comStudentMarks;
			daStudentMarks.Fill(dsStudentMarks);
			conStudentMarks.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsStudentMarks.Tables.Add(dtErrorTable);
		}

		public DataSet SelectStudentMarks()
		{
			try
			{
				ConnectAndExecute("StudentMarksSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsStudentMarks;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsStudentMarks;
			}//end try
		}//end function

		public DataSet SelectStudentMarks(int intClassID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@ClassID";
				objParameter.Value = intClassID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("GetStudentMarksByID", objParameterList);
				return dsStudentMarks;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsStudentMarks;
			}
		}
		
		public DataSet InsertUpdateStudentMarks(Int64 intMarksID, Int64 intStudentID, Int64 intSubjectID, Int64 intClassID, Int64 intObtainedMarks, bool blnIsEnabled, DateTime datDateCreated, string strRemarks, Int64 intUserID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@MarksID";
objParameter.Value = intMarksID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@StudentID";
objParameter.Value = intStudentID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@SubjectID";
objParameter.Value = intSubjectID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@ClassID";
objParameter.Value = intClassID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@ObtainedMarks";
objParameter.Value = intObtainedMarks;
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
			
				ConnectAndExecute("InsertUpdateStudentMarks", objParameterList);
				return dsStudentMarks;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsStudentMarks;
			}
		}

		public DataSet DeleteStudentMarks(int intClassID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@ClassID";
				objParameter.Value = intClassID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("DeleteByIDStudentMarks", objParameterList);
				return dsStudentMarks;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsStudentMarks;
			}
		}
    
		public DataSet DeleteStudentMarks()
		{
			try
			{
				ConnectAndExecute("DeleteAllStudentMarks", new ArrayList()); //no parameter will send to stored procedure
				return dsStudentMarks;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsStudentMarks;
			}
		}
    
		public DataSet StudentMarksTruncate()
        {
			try
			{
				ConnectAndExecute("StudentMarksTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsStudentMarks;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsStudentMarks;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
