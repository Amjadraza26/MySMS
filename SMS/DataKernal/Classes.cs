using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class Classes
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conClasses;
		SqlCommand comClasses;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daClasses;
		DataSet dsClasses;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public Classes(string strConnString)
        {
			strConnectionString = strConnString;
			conClasses = new SqlConnection(strConnectionString);
			comClasses = new SqlCommand();
			daClasses = new SqlDataAdapter();
			dsClasses = new DataSet();
		}//end constructor
    
		public Classes()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conClasses = new SqlConnection(strConnectionString);
			comClasses = new SqlCommand();
			daClasses = new SqlDataAdapter();
			dsClasses = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conClasses.Open();
			comClasses.Connection = conClasses;
			comClasses.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comClasses.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comClasses.CommandType = CommandType.StoredProcedure;
			daClasses.SelectCommand = comClasses;
			daClasses.Fill(dsClasses);
			conClasses.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsClasses.Tables.Add(dtErrorTable);
		}

		public DataSet SelectClasses()
		{
			try
			{
				ConnectAndExecute("ClassesSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsClasses;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsClasses;
			}//end try
		}//end function

		public DataSet SelectClasses(int intClassID)
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
			
				ConnectAndExecute("GetClassesByID", objParameterList);
				return dsClasses;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClasses;
			}
		}
		
		public DataSet InsertUpdateClasses(Int64 intClassID, string strClassName, string strNumericName, Int64 intUserID, DateTime datDateCreated, bool blnIsEnabled, string strRemarks)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@ClassID";
objParameter.Value = intClassID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@ClassName";
objParameter.Value = strClassName;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@NumericName";
objParameter.Value = strNumericName;
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

				//end parameter setting
			
				ConnectAndExecute("InsertUpdateClasses", objParameterList);
				return dsClasses;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClasses;
			}
		}

		public DataSet DeleteClasses(int intClassID)
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
			
				ConnectAndExecute("DeleteByIDClasses", objParameterList);
				return dsClasses;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClasses;
			}
		}
    
		public DataSet DeleteClasses()
		{
			try
			{
				ConnectAndExecute("DeleteAllClasses", new ArrayList()); //no parameter will send to stored procedure
				return dsClasses;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClasses;
			}
		}
    
		public DataSet ClassesTruncate()
        {
			try
			{
				ConnectAndExecute("ClassesTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsClasses;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsClasses;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
