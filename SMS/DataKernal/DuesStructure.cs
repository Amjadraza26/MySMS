using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class DuesStructure
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conDuesStructure;
		SqlCommand comDuesStructure;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daDuesStructure;
		DataSet dsDuesStructure;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public DuesStructure(string strConnString)
        {
			strConnectionString = strConnString;
			conDuesStructure = new SqlConnection(strConnectionString);
			comDuesStructure = new SqlCommand();
			daDuesStructure = new SqlDataAdapter();
			dsDuesStructure = new DataSet();
		}//end constructor
    
		public DuesStructure()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conDuesStructure = new SqlConnection(strConnectionString);
			comDuesStructure = new SqlCommand();
			daDuesStructure = new SqlDataAdapter();
			dsDuesStructure = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conDuesStructure.Open();
			comDuesStructure.Connection = conDuesStructure;
			comDuesStructure.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comDuesStructure.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comDuesStructure.CommandType = CommandType.StoredProcedure;
			daDuesStructure.SelectCommand = comDuesStructure;
			daDuesStructure.Fill(dsDuesStructure);
			conDuesStructure.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsDuesStructure.Tables.Add(dtErrorTable);
		}

		public DataSet SelectDuesStructure()
		{
			try
			{
				ConnectAndExecute("DuesStructureSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsDuesStructure;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsDuesStructure;
			}//end try
		}//end function

		public DataSet SelectDuesStructure(int intDueAmountID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@DueAmountID";
				objParameter.Value = intDueAmountID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("GetDuesStructureByID", objParameterList);
				return dsDuesStructure;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsDuesStructure;
			}
		}
		
		public DataSet InsertUpdateDuesStructure(Int64 intDueAmountID, Int64 intClassID, Int64 intTotalFee, DateTime datDateCreated, bool blnIsEnabled, string strRemarks)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@DueAmountID";
objParameter.Value = intDueAmountID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@ClassID";
objParameter.Value = intClassID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@TotalFee";
objParameter.Value = intTotalFee;
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
			
				ConnectAndExecute("InsertUpdateDuesStructure", objParameterList);
				return dsDuesStructure;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsDuesStructure;
			}
		}

		public DataSet DeleteDuesStructure(int intDueAmountID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@DueAmountID";
				objParameter.Value = intDueAmountID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("DeleteByIDDuesStructure", objParameterList);
				return dsDuesStructure;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsDuesStructure;
			}
		}
    
		public DataSet DeleteDuesStructure()
		{
			try
			{
				ConnectAndExecute("DeleteAllDuesStructure", new ArrayList()); //no parameter will send to stored procedure
				return dsDuesStructure;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsDuesStructure;
			}
		}
    
		public DataSet DuesStructureTruncate()
        {
			try
			{
				ConnectAndExecute("DuesStructureTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsDuesStructure;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsDuesStructure;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
