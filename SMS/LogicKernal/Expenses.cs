using System.Data;

namespace LogicKernal
{
	public class Expenses
	{
		public static DataTable GetAllExpenses()
		{
			try
			{
				DataKernal.Expenses objExpenses =  new DataKernal.Expenses();
				return objExpenses.SelectExpenses().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable GetExpensesByID(int intClassID)
		{
			try
			{
				DataKernal.Expenses objExpenses = new DataKernal.Expenses();
				return objExpenses.SelectExpenses(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable InsertUpdateExpenses(BusinessEntities.Expenses objExpenses)
		{
			try
			{
				DataKernal.Expenses objDExpenses = new DataKernal.Expenses();
				return objDExpenses.InsertUpdateExpenses(objExpenses.ExpensesID,objExpenses.ExpenseName,objExpenses.ExpenseType,objExpenses.DateCreated,objExpenses.IsEnabled,objExpenses.Remarks,objExpenses.UserID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteExpenses(int intClassID)
		{
			try
			{
				DataKernal.Expenses objExpenses = new DataKernal.Expenses();
				return objExpenses.DeleteExpenses(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteExpenses()
		{
			try
			{
				DataKernal.Expenses objExpenses = new DataKernal.Expenses();
				return objExpenses.DeleteExpenses().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateExpenses()
		{
			try
			{
				DataKernal.Expenses objExpenses = new DataKernal.Expenses();
				return objExpenses.ExpensesTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
	}
}