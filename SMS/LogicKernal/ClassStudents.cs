using System.Data;

namespace LogicKernal
{
	public class ClassStudents
	{
		public static DataTable GetAllClassStudents()
		{
			try
			{
				DataKernal.ClassStudents objClassStudents =  new DataKernal.ClassStudents();
				return objClassStudents.SelectClassStudents().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
        public static DataTable ClassStudent(int ClassID, int SectionID)
        {
            DataTable dtStudents = GetAllClassStudents();
            if(dtStudents.Rows.Count>0)
            {
                DataRow[] rows = dtStudents.Select("ClassID = " + ClassID.ToString());
                dtStudents = new DataTable();
                if (rows.Length > 0)
                    dtStudents = rows.CopyToDataTable();
                if (dtStudents.Rows.Count > 0)
                {
                    DataRow[] row = dtStudents.Select("SectionID = " + SectionID.ToString());
                    dtStudents = new DataTable();
                    if (rows.Length > 0)
                        dtStudents = row.CopyToDataTable();
                    return dtStudents;
                }
                    
            }
            else
            {
                dtStudents = new DataTable();
            }
            return dtStudents;
        }
    
		public static DataTable GetClassStudentsByID(int intClassStudentID)
		{
			try
			{
				DataKernal.ClassStudents objClassStudents = new DataKernal.ClassStudents();
				return objClassStudents.SelectClassStudents(intClassStudentID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable InsertUpdateClassStudents(BusinessEntities.ClassStudents objClassStudents)
		{
            try
            {
                DataKernal.ClassStudents objDClassStudents = new DataKernal.ClassStudents();
                return objDClassStudents.InsertUpdateClassStudents(objClassStudents.ClassStudentID, objClassStudents.ClassID, objClassStudents.SectionID, objClassStudents.StudentID, objClassStudents.UserID, objClassStudents.DateCreated, objClassStudents.IsEnabled, objClassStudents.Remarks, objClassStudents.RollNo).Tables[0];
            }
            catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteClassStudents(int intClassStudentID)
		{
			try
			{
				DataKernal.ClassStudents objClassStudents = new DataKernal.ClassStudents();
				return objClassStudents.DeleteClassStudents(intClassStudentID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteClassStudents()
		{
			try
			{
				DataKernal.ClassStudents objClassStudents = new DataKernal.ClassStudents();
				return objClassStudents.DeleteClassStudents().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateClassStudents()
		{
			try
			{
				DataKernal.ClassStudents objClassStudents = new DataKernal.ClassStudents();
				return objClassStudents.ClassStudentsTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
	}
}