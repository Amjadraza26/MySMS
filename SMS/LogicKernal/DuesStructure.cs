using System.Data;

namespace LogicKernal
{
	public class DuesStructure
	{
		public static DataTable GetAllDuesStructure()
		{
			try
			{
				DataKernal.DuesStructure objDuesStructure =  new DataKernal.DuesStructure();
				return objDuesStructure.SelectDuesStructure().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable GetDuesStructureByID(int intDueAmountID)
		{
			try
			{
				DataKernal.DuesStructure objDuesStructure = new DataKernal.DuesStructure();
				return objDuesStructure.SelectDuesStructure(intDueAmountID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable InsertUpdateDuesStructure(BusinessEntities.DuesStructure objDuesStructure)
		{
			try
			{
				DataKernal.DuesStructure objDDuesStructure = new DataKernal.DuesStructure();
				return objDDuesStructure.InsertUpdateDuesStructure(objDuesStructure.DueAmountID,objDuesStructure.ClassID,objDuesStructure.TotalFee,objDuesStructure.DateCreated,objDuesStructure.IsEnabled,objDuesStructure.Remarks).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteDuesStructure(int intDueAmountID)
		{
			try
			{
				DataKernal.DuesStructure objDuesStructure = new DataKernal.DuesStructure();
				return objDuesStructure.DeleteDuesStructure(intDueAmountID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteDuesStructure()
		{
			try
			{
				DataKernal.DuesStructure objDuesStructure = new DataKernal.DuesStructure();
				return objDuesStructure.DeleteDuesStructure().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateDuesStructure()
		{
			try
			{
				DataKernal.DuesStructure objDuesStructure = new DataKernal.DuesStructure();
				return objDuesStructure.DuesStructureTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
	}
}