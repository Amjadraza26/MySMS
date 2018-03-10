using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class ClassSections
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conClassSections;
		SqlCommand comClassSections;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daClassSections;
		DataSet dsClassSections;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public ClassSections(string strConnString)
        {
			strConnectionString = strConnString;
			conClassSections = new SqlConnection(strConnectionString);
			comClassSections = new SqlCommand();
			daClassSections = new SqlDataAdapter();
			dsClassSections = new DataSet();
		}//end constructor
    
		public ClassSections()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conClassSections = new SqlConnection(strConnectionString);
			comClassSections = new SqlCommand();
			daClassSections = new SqlDataAdapter();
			dsClassSections = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conClassSections.Open();
			comClassSections.Connection = conClassSections;
			comClassSections.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comClassSections.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comClassSections.CommandType = CommandType.StoredProcedure;
			daClassSections.SelectCommand = comClassSections;
			daClassSections.Fill(dsClassSections);
			conClassSections.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsClassSections.Tables.Add(dtErrorTable);
		}

		public DataSet SelectClassSections()
		{
			try
			{
				ConnectAndExecute("ClassSectionsSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsClassSections;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsClassSections;
			}//end try
		}//end function

		public DataSet SelectClassSections(int intClassID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@SectionID";
				objParameter.Value = intClassID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("GetClassSectionsByID", objParameterList);
				return dsClassSections;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassSections;
			}
		}
		
		public DataSet InsertUpdateClassSections(Int64 intSectionID, string strSectionName, Int64 intClassID, DateTime datDateCreated, bool blnIsEnabled, string strRemarks, Int64 intUserID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@SectionID";
objParameter.Value = intSectionID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@SectionName";
objParameter.Value = strSectionName;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@ClassID";
objParameter.Value = intClassID;
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
objParameter.ParameterName = "@UserID";
objParameter.Value = intUserID;
objParameterList.Add(objParameter);

				//end parameter setting
			
				ConnectAndExecute("InsertUpdateClassSections", objParameterList);
				return dsClassSections;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassSections;
			}
		}

		public DataSet DeleteClassSections(int intClassID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@SectionID";
				objParameter.Value = intClassID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("DeleteByIDClassSections", objParameterList);
				return dsClassSections;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassSections;
			}
		}
    
		public DataSet DeleteClassSections()
		{
			try
			{
				ConnectAndExecute("DeleteAllClassSections", new ArrayList()); //no parameter will send to stored procedure
				return dsClassSections;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassSections;
			}
		}
    
		public DataSet ClassSectionsTruncate()
        {
			try
			{
				ConnectAndExecute("ClassSectionsTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsClassSections;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClassSections;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
