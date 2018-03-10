using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class CollectedDues
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conCollectedDues;
		SqlCommand comCollectedDues;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daCollectedDues;
		DataSet dsCollectedDues;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public CollectedDues(string strConnString)
        {
			strConnectionString = strConnString;
			conCollectedDues = new SqlConnection(strConnectionString);
			comCollectedDues = new SqlCommand();
			daCollectedDues = new SqlDataAdapter();
			dsCollectedDues = new DataSet();
		}//end constructor
    
		public CollectedDues()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conCollectedDues = new SqlConnection(strConnectionString);
			comCollectedDues = new SqlCommand();
			daCollectedDues = new SqlDataAdapter();
			dsCollectedDues = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conCollectedDues.Open();
			comCollectedDues.Connection = conCollectedDues;
			comCollectedDues.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comCollectedDues.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comCollectedDues.CommandType = CommandType.StoredProcedure;
			daCollectedDues.SelectCommand = comCollectedDues;
			daCollectedDues.Fill(dsCollectedDues);
			conCollectedDues.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsCollectedDues.Tables.Add(dtErrorTable);
		}

		public DataSet SelectCollectedDues()
		{
			try
			{
				ConnectAndExecute("CollectedDuesSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsCollectedDues;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsCollectedDues;
			}//end try
		}//end function

		public DataSet SelectCollectedDues(int intClassID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@DuesID";
				objParameter.Value = intClassID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("GetCollectedDuesByID", objParameterList);
				return dsCollectedDues;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsCollectedDues;
			}
		}
		
		public DataSet InsertUpdateCollectedDues(Int64 intDuesID, string strDuesMonth, Int64 intStudentID,Int64 intClassID, Int64 intPayment, DateTime datDateCreated, bool blnIsEnabled, string strRemarks, Int64 intUserID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@DuesID";
objParameter.Value = intDuesID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@DuesMonth";
objParameter.Value = strDuesMonth;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@StudentID";
objParameter.Value = intStudentID;
objParameterList.Add(objParameter);
                objParameter = new SqlParameter();
                objParameter.ParameterName = "@ClassID";
                objParameter.Value = intClassID;
                objParameterList.Add(objParameter);
                objParameter = new SqlParameter();
objParameter.ParameterName = "@Payment";
objParameter.Value = intPayment;
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
			
				ConnectAndExecute("InsertUpdateCollectedDues", objParameterList);
				return dsCollectedDues;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsCollectedDues;
			}
		}

		public DataSet DeleteCollectedDues(int intClassID)
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
			
				ConnectAndExecute("DeleteByIDCollectedDues", objParameterList);
				return dsCollectedDues;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsCollectedDues;
			}
		}
    
		public DataSet DeleteCollectedDues()
		{
			try
			{
				ConnectAndExecute("DeleteAllCollectedDues", new ArrayList()); //no parameter will send to stored procedure
				return dsCollectedDues;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsCollectedDues;
			}
		}
    
		public DataSet CollectedDuesTruncate()
        {
			try
			{
				ConnectAndExecute("CollectedDuesTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsCollectedDues;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsCollectedDues;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
