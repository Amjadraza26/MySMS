using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class Users
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conUsers;
		SqlCommand comUsers;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daUsers;
		DataSet dsUsers;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public Users(string strConnString)
        {
			strConnectionString = strConnString;
			conUsers = new SqlConnection(strConnectionString);
			comUsers = new SqlCommand();
			daUsers = new SqlDataAdapter();
			dsUsers = new DataSet();
		}//end constructor
    
		public Users()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conUsers = new SqlConnection(strConnectionString);
			comUsers = new SqlCommand();
			daUsers = new SqlDataAdapter();
			dsUsers = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conUsers.Open();
			comUsers.Connection = conUsers;
			comUsers.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comUsers.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comUsers.CommandType = CommandType.StoredProcedure;
			daUsers.SelectCommand = comUsers;
			daUsers.Fill(dsUsers);
			conUsers.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsUsers.Tables.Add(dtErrorTable);
		}

		public DataSet SelectUsers()
		{
			try
			{
				ConnectAndExecute("UsersSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsUsers;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsUsers;
			}//end try
		}//end function

		public DataSet SelectUsers(int intClassID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@UserID";
				objParameter.Value = intClassID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("GetUsersByID", objParameterList);
				return dsUsers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsUsers;
			}
		}
		
		public DataSet InsertUpdateUsers(Int64 intUserID, string strUserName, string strEmailAddress, string strUserPassword, bool blnIsEnabled, DateTime datDateCreated, string strRemarks)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@UserID";
objParameter.Value = intUserID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@UserName";
objParameter.Value = strUserName;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@EmailAddress";
objParameter.Value = strEmailAddress;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@UserPassword";
objParameter.Value = strUserPassword;
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
			
				ConnectAndExecute("InsertUpdateUsers", objParameterList);
				return dsUsers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsUsers;
			}
		}

		public DataSet DeleteUsers(int intClassID)
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
			
				ConnectAndExecute("DeleteByIDUsers", objParameterList);
				return dsUsers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsUsers;
			}
		}
    
		public DataSet DeleteUsers()
		{
			try
			{
				ConnectAndExecute("DeleteAllUsers", new ArrayList()); //no parameter will send to stored procedure
				return dsUsers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsUsers;
			}
		}
    
		public DataSet UsersTruncate()
        {
			try
			{
				ConnectAndExecute("UsersTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsUsers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsUsers;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
