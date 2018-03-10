using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class Subjects
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conSubjects;
		SqlCommand comSubjects;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daSubjects;
		DataSet dsSubjects;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public Subjects(string strConnString)
        {
			strConnectionString = strConnString;
			conSubjects = new SqlConnection(strConnectionString);
			comSubjects = new SqlCommand();
			daSubjects = new SqlDataAdapter();
			dsSubjects = new DataSet();
		}//end constructor
    
		public Subjects()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conSubjects = new SqlConnection(strConnectionString);
			comSubjects = new SqlCommand();
			daSubjects = new SqlDataAdapter();
			dsSubjects = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conSubjects.Open();
			comSubjects.Connection = conSubjects;
			comSubjects.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comSubjects.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comSubjects.CommandType = CommandType.StoredProcedure;
			daSubjects.SelectCommand = comSubjects;
			daSubjects.Fill(dsSubjects);
			conSubjects.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsSubjects.Tables.Add(dtErrorTable);
		}

		public DataSet SelectSubjects()
		{
			try
			{
				ConnectAndExecute("SubjectsSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsSubjects;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsSubjects;
			}//end try
		}//end function

		public DataSet SelectSubjects(int intClassID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@SubjectID";
				objParameter.Value = intClassID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("GetSubjectsByID", objParameterList);
				return dsSubjects;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsSubjects;
			}
		}
		
		public DataSet InsertUpdateSubjects(Int64 intSubjectID, string strSubjectName, Int64 intClassID, bool blnIsEnabled, DateTime datDateCreated, string strRemarks, Int64 intUserID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@SubjectID";
objParameter.Value = intSubjectID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@SubjectName";
objParameter.Value = strSubjectName;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@ClassID";
objParameter.Value = intClassID;
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
			
				ConnectAndExecute("InsertUpdateSubjects", objParameterList);
				return dsSubjects;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsSubjects;
			}
		}

		public DataSet DeleteSubjects(int intClassID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@SubjectID";
				objParameter.Value = intClassID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("DeleteByIDSubjects", objParameterList);
				return dsSubjects;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsSubjects;
			}
		}
    
		public DataSet DeleteSubjects()
		{
			try
			{
				ConnectAndExecute("DeleteAllSubjects", new ArrayList()); //no parameter will send to stored procedure
				return dsSubjects;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsSubjects;
			}
		}
    
		public DataSet SubjectsTruncate()
        {
			try
			{
				ConnectAndExecute("SubjectsTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsSubjects;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsSubjects;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
