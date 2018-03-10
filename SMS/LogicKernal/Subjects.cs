using System.Data;

namespace LogicKernal
{
	public class Subjects
	{
		public static DataTable GetAllSubjects()
		{
			try
			{
				DataKernal.Subjects objSubjects =  new DataKernal.Subjects();
				return objSubjects.SelectSubjects().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
        public static DataTable GetSubjectByClassID(int ClassID)
        {
            DataTable dtSubjects = GetAllSubjects();
            DataRow[] rows = dtSubjects.Select("ClassID = " + ClassID.ToString());
            dtSubjects = new DataTable();
            if (rows.Length > 0)
                dtSubjects = rows.CopyToDataTable();

            return dtSubjects;
        }
    
		public static DataTable GetSubjectsByID(int intClassID)
		{
			try
			{
				DataKernal.Subjects objSubjects = new DataKernal.Subjects();
				return objSubjects.SelectSubjects(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable InsertUpdateSubjects(BusinessEntities.Subjects objSubjects)
		{
			try
			{
				DataKernal.Subjects objDSubjects = new DataKernal.Subjects();
				return objDSubjects.InsertUpdateSubjects(objSubjects.SubjectID,objSubjects.SubjectName,objSubjects.ClassID,objSubjects.IsEnabled,objSubjects.DateCreated,objSubjects.Remarks,objSubjects.UserID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteSubjects(int intClassID)
		{
			try
			{
				DataKernal.Subjects objSubjects = new DataKernal.Subjects();
				return objSubjects.DeleteSubjects(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteSubjects()
		{
			try
			{
				DataKernal.Subjects objSubjects = new DataKernal.Subjects();
				return objSubjects.DeleteSubjects().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateSubjects()
		{
			try
			{
				DataKernal.Subjects objSubjects = new DataKernal.Subjects();
				return objSubjects.SubjectsTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
	}
}