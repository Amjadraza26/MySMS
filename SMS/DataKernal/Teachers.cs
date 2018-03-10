using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace DataKernal
{
	public class Teachers
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		SqlConnection conTeachers;
		SqlCommand comTeachers;
		string strConnectionString  = string.Empty;
		SqlDataAdapter daTeachers;
		DataSet dsTeachers;
		int intRecords;
		///////////////////////////////////////////////////////////////////////////////////////////


		//Constructor//////////////////////////////////////////////////////////////////////////////
		public Teachers(string strConnString)
        {
			strConnectionString = strConnString;
			conTeachers = new SqlConnection(strConnectionString);
			comTeachers = new SqlCommand();
			daTeachers = new SqlDataAdapter();
			dsTeachers = new DataSet();
		}//end constructor
    
		public Teachers()
        {
			strConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
			conTeachers = new SqlConnection(strConnectionString);
			comTeachers = new SqlCommand();
			daTeachers = new SqlDataAdapter();
			dsTeachers = new DataSet();
		}
		///////////////////////////////////////////////////////////////////////////////////////////

		//Private Methods///////////////////////////////////////////////////////////////////////////
		private void ConnectAndExecute(string strCommandText, ArrayList objParameterList)
		{
			conTeachers.Open();
			comTeachers.Connection = conTeachers;
			comTeachers.CommandText = strCommandText;
			//Adding parameters if required
			if (objParameterList.Count > 0) 
			{
				for (int intCounter = 0; intCounter < objParameterList.Count; intCounter++)
				{
					SqlParameter objParameter = new SqlParameter();
					objParameter = (SqlParameter) objParameterList[intCounter];
					comTeachers.Parameters.AddWithValue(objParameter.ParameterName, objParameter.Value);
				}
			}
			comTeachers.CommandType = CommandType.StoredProcedure;
			daTeachers.SelectCommand = comTeachers;
			daTeachers.Fill(dsTeachers);
			conTeachers.Close();
		}
		
		private void SetError(string strErrorMessage)
		{
			DataColumn colErrorMessage = new DataColumn("ErrorMessage");
			DataTable dtErrorTable = new DataTable();
			dtErrorTable.Columns.Add(colErrorMessage);
			DataRow drErrorRow = dtErrorTable.NewRow();
			drErrorRow[0] = strErrorMessage;
			dtErrorTable.Rows.Add(drErrorRow);
			dsTeachers.Tables.Add(dtErrorTable);
		}

		public DataSet SelectTeachers()
		{
			try
			{
				ConnectAndExecute("TeachersSelectAll", new ArrayList()); //no parameter will send to stored procedure
				return dsTeachers;
			}
			catch (Exception ex) 
			{
				SetError(ex.Message);
				return dsTeachers;
			}//end try
		}//end function

		public DataSet SelectTeachers(int intClassID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter = new SqlParameter();
				objParameter.ParameterName = "@TeacherID";
				objParameter.Value = intClassID;
				objParameterList.Add(objParameter);
				//end parameter setting
			
				ConnectAndExecute("GetTeachersByID", objParameterList);
				return dsTeachers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsTeachers;
			}
		}
		
		public DataSet InsertUpdateTeachers(Int64 intTeacherID, string strTeacherName, string strTeacherEmail, string strTeacherEducation, string strTeacherSpecialization, string strTeacherContactNo, string strTeacherImage, DateTime datDateCreated, bool blnIsEnabled, string strRemarks, Int64 intUserID)
		{
			try
			{
				//parameter setting
				ArrayList objParameterList = new ArrayList();
				SqlParameter objParameter;
				objParameter = new SqlParameter();
objParameter.ParameterName = "@TeacherID";
objParameter.Value = intTeacherID;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@TeacherName";
objParameter.Value = strTeacherName;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@TeacherEmail";
objParameter.Value = strTeacherEmail;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@TeacherEducation";
objParameter.Value = strTeacherEducation;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@TeacherSpecialization";
objParameter.Value = strTeacherSpecialization;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@TeacherContactNo";
objParameter.Value = strTeacherContactNo;
objParameterList.Add(objParameter);
objParameter = new SqlParameter();
objParameter.ParameterName = "@TeacherImage";
objParameter.Value = strTeacherImage;
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
			
				ConnectAndExecute("InsertUpdateTeachers", objParameterList);
				return dsTeachers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsTeachers;
			}
		}

		public DataSet DeleteTeachers(int intClassID)
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
			
				ConnectAndExecute("DeleteByIDTeachers", objParameterList);
				return dsTeachers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsTeachers;
			}
		}
    
		public DataSet DeleteTeachers()
		{
			try
			{
				ConnectAndExecute("DeleteAllTeachers", new ArrayList()); //no parameter will send to stored procedure
				return dsTeachers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsTeachers;
			}
		}
    
		public DataSet TeachersTruncate()
        {
			try
			{
				ConnectAndExecute("TeachersTruncate", new ArrayList()); //no parameter will send to stored procedure
				return dsTeachers;
			}
			catch (Exception ex)
			{
				SetError(ex.Message);
				return dsTeachers;
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}
