using System.Data;

namespace LogicKernal
{
	public class ClassSections
	{
		public static DataTable GetAllClassSections()
		{
			try
			{
				DataKernal.ClassSections objClassSections =  new DataKernal.ClassSections();
				return objClassSections.SelectClassSections().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable GetClassSectionsByID(int intClassID)
		{
			try
			{
				DataKernal.ClassSections objClassSections = new DataKernal.ClassSections();
				return objClassSections.SelectClassSections(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
        public static DataTable GetSectionByClassID(int ClassID)
        {
            DataTable dtSetions = GetAllClassSections();
            DataRow[] rows = dtSetions.Select("ClassID = " + ClassID.ToString());
            dtSetions = new DataTable();
            if (rows.Length > 0)
                dtSetions = rows.CopyToDataTable();

            return dtSetions;
        }
    
		public static DataTable InsertUpdateClassSections(BusinessEntities.ClassSections objClassSections)
		{
			try
			{
				DataKernal.ClassSections objDClassSections = new DataKernal.ClassSections();
				return objDClassSections.InsertUpdateClassSections(objClassSections.SectionID,objClassSections.SectionName,objClassSections.ClassID,objClassSections.DateCreated,objClassSections.IsEnabled,objClassSections.Remarks,objClassSections.UserID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteClassSections(int intClassID)
		{
			try
			{
				DataKernal.ClassSections objClassSections = new DataKernal.ClassSections();
				return objClassSections.DeleteClassSections(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteClassSections()
		{
			try
			{
				DataKernal.ClassSections objClassSections = new DataKernal.ClassSections();
				return objClassSections.DeleteClassSections().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateClassSections()
		{
			try
			{
				DataKernal.ClassSections objClassSections = new DataKernal.ClassSections();
				return objClassSections.ClassSectionsTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
	}
}