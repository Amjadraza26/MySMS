using System.Data;

namespace LogicKernal
{
	public class Classes
	{
		public static DataTable GetAllClasses()
		{
			try
			{
				DataKernal.Classes objClasses =  new DataKernal.Classes();
				return objClasses.SelectClasses().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable GetClassesByID(int intClassID)
		{
			try
			{
				DataKernal.Classes objClasses = new DataKernal.Classes();
				return objClasses.SelectClasses(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable InsertUpdateClasses(BusinessEntities.Classes objClasses)
		{
			try
			{
				DataKernal.Classes objDClasses = new DataKernal.Classes();
				return objDClasses.InsertUpdateClasses(objClasses.ClassID,objClasses.ClassName,objClasses.NumericName,objClasses.UserID,objClasses.DateCreated,objClasses.IsEnabled,objClasses.Remarks).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteClasses(int intClassID)
		{
			try
			{
				DataKernal.Classes objClasses = new DataKernal.Classes();
				return objClasses.DeleteClasses(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteClasses()
		{
			try
			{
				DataKernal.Classes objClasses = new DataKernal.Classes();
				return objClasses.DeleteClasses().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateClasses()
		{
			try
			{
				DataKernal.Classes objClasses = new DataKernal.Classes();
				return objClasses.ClassesTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
	}
}