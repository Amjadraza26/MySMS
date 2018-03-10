using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class FeeVouchers
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conFeeVouchers;
		SqlCommand comFeeVouchers;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daFeeVouchers;
		DataSet dsFeeVouchers;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public FeeVouchers(string strConnString)
        {
			strConnectionString = strConnString;
			conFeeVouchers = new SqlConnection(strConnectionString);
			comFeeVouchers = new SqlCommand();
			daFeeVouchers = new SqlDataAdapter();
			dsFeeVouchers = new DataSet();
		}//end constructor
    
		public FeeVouchers()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conFeeVouchers = new SqlConnection(strConnectionString);
			comFeeVouchers = new SqlCommand();
			daFeeVouchers = new SqlDataAdapter();
			dsFeeVouchers = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conFeeVouchers.Open();
			comFeeVouchers.Connection = conFeeVouchers;
			comFeeVouchers.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comFeeVouchers.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comFeeVouchers.CommandType = CommandType.StoredProcedure;
			daFeeVouchers.SelectCommand = comFeeVouchers;
			daFeeVouchers.Fill(dsFeeVouchers);
			conFeeVouchers.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsFeeVouchers.Tables.Add(dtErrorTable);
		}

		public DataSet SelectFeeVouchers()
		{
			try
			{
				ConnectAndExecute("FeeVouchersSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsFeeVouchers;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsFeeVouchers;
			}//end try
		}//end function

		public DataSet SelectFeeVouchers(int intVoucherID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@VoucherID";
				objParameter.Value = intVoucherID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("GetFeeVouchersByID", objParameterList);
				return dsFeeVouchers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsFeeVouchers;
			}
		}
		
		public DataSet InsertUpdateFeeVouchers(Int64 intVoucherID, Int64 intStudentID, DateTime datDateVoucherIssue, string strDateVoucherSubmit, string strCollectedFee, Int64 intUserID, bool blnIsEnabled, string strRemarks)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@VoucherID";
objParameter.Value = intVoucherID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@StudentID";
objParameter.Value = intStudentID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@DateVoucherIssue";
objParameter.Value = datDateVoucherIssue;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@DateVoucherSubmit";
objParameter.Value = strDateVoucherSubmit;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@CollectedFee";
objParameter.Value = strCollectedFee;
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
objParameter.ParameterName = "@Remarks";
objParameter.Value = strRemarks;
objParameterList.Add(objParameter);

				//end parameter setting
			
				ConnectAndExecute("InsertUpdateFeeVouchers", objParameterList);
				return dsFeeVouchers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsFeeVouchers;
			}
		}

		public DataSet DeleteFeeVouchers(int intVoucherID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@VoucherID";
				objParameter.Value = intVoucherID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("DeleteByIDFeeVouchers", objParameterList);
				return dsFeeVouchers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsFeeVouchers;
			}
		}
    
		public DataSet DeleteFeeVouchers()
		{
			try
			{
				ConnectAndExecute("DeleteAllFeeVouchers", new ArrayList()); //no parameter will send to stored procedure
				return dsFeeVouchers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsFeeVouchers;
			}
		}
    
		public DataSet FeeVouchersTruncate()
        {
			try
			{
				ConnectAndExecute("FeeVouchersTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsFeeVouchers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsFeeVouchers;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
