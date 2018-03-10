using System.Data;

namespace LogicKernal
{
	public class CollectedDues
	{
		public static DataTable GetAllCollectedDues()
		{
			try
			{
				DataKernal.CollectedDues objCollectedDues =  new DataKernal.CollectedDues();
				return objCollectedDues.SelectCollectedDues().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable GetCollectedDuesByID(int intClassID)
		{
			try
			{
				DataKernal.CollectedDues objCollectedDues = new DataKernal.CollectedDues();
				return objCollectedDues.SelectCollectedDues(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable InsertUpdateCollectedDues(BusinessEntities.CollectedDues objCollectedDues)
		{
			try
			{
				DataKernal.CollectedDues objDCollectedDues = new DataKernal.CollectedDues();
				return objDCollectedDues.InsertUpdateCollectedDues(objCollectedDues.DuesID,objCollectedDues.DuesMonth,objCollectedDues.StudentID,objCollectedDues.ClassID,objCollectedDues.Payment,objCollectedDues.DateCreated,objCollectedDues.IsEnabled,objCollectedDues.Remarks,objCollectedDues.UserID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteCollectedDues(int intClassID)
		{
			try
			{
				DataKernal.CollectedDues objCollectedDues = new DataKernal.CollectedDues();
				return objCollectedDues.DeleteCollectedDues(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteCollectedDues()
		{
			try
			{
				DataKernal.CollectedDues objCollectedDues = new DataKernal.CollectedDues();
				return objCollectedDues.DeleteCollectedDues().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateCollectedDues()
		{
			try
			{
				DataKernal.CollectedDues objCollectedDues = new DataKernal.CollectedDues();
				return objCollectedDues.CollectedDuesTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
	}
}