using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class Expenses
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conExpenses;
		SqlCommand comExpenses;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daExpenses;
		DataSet dsExpenses;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public Expenses(string strConnString)
        {
			strConnectionString = strConnString;
			conExpenses = new SqlConnection(strConnectionString);
			comExpenses = new SqlCommand();
			daExpenses = new SqlDataAdapter();
			dsExpenses = new DataSet();
		}//end constructor
    
		public Expenses()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conExpenses = new SqlConnection(strConnectionString);
			comExpenses = new SqlCommand();
			daExpenses = new SqlDataAdapter();
			dsExpenses = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conExpenses.Open();
			comExpenses.Connection = conExpenses;
			comExpenses.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comExpenses.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comExpenses.CommandType = CommandType.StoredProcedure;
			daExpenses.SelectCommand = comExpenses;
			daExpenses.Fill(dsExpenses);
			conExpenses.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsExpenses.Tables.Add(dtErrorTable);
		}

		public DataSet SelectExpenses()
		{
			try
			{
				ConnectAndExecute("ExpensesSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsExpenses;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsExpenses;
			}//end try
		}//end function

		public DataSet SelectExpenses(int intClassID)
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
			
				ConnectAndExecute("GetExpensesByID", objParameterList);
				return dsExpenses;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsExpenses;
			}
		}
		
		public DataSet InsertUpdateExpenses(Int64 intExpensesID, string strExpenseName, string strExpenseType, DateTime datDateCreated, bool blnIsEnabled, string strRemarks, Int64 intUserID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@ExpensesID";
objParameter.Value = intExpensesID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@ExpenseName";
objParameter.Value = strExpenseName;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@ExpenseType";
objParameter.Value = strExpenseType;
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
			
				ConnectAndExecute("InsertUpdateExpenses", objParameterList);
				return dsExpenses;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsExpenses;
			}
		}

		public DataSet DeleteExpenses(int intClassID)
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
			
				ConnectAndExecute("DeleteByIDExpenses", objParameterList);
				return dsExpenses;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsExpenses;
			}
		}
    
		public DataSet DeleteExpenses()
		{
			try
			{
				ConnectAndExecute("DeleteAllExpenses", new ArrayList()); //no parameter will send to stored procedure
				return dsExpenses;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsExpenses;
			}
		}
    
		public DataSet ExpensesTruncate()
        {
			try
			{
				ConnectAndExecute("ExpensesTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsExpenses;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsExpenses;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
