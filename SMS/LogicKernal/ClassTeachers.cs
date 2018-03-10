using System.Data;

namespace LogicKernal
{
	public class ClassTeachers
	{
		public static DataTable GetAllClassTeachers()
		{
			try
			{
				DataKernal.ClassTeachers objClassTeachers =  new DataKernal.ClassTeachers();
				return objClassTeachers.SelectClassTeachers().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable GetClassTeachersByID(int intClassTeacherID)
		{
			try
			{
				DataKernal.ClassTeachers objClassTeachers = new DataKernal.ClassTeachers();
				return objClassTeachers.SelectClassTeachers(intClassTeacherID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable InsertUpdateClassTeachers(BusinessEntities.ClassTeachers objClassTeachers)
		{
			try
			{
				DataKernal.ClassTeachers objDClassTeachers = new DataKernal.ClassTeachers();
				return objDClassTeachers.InsertUpdateClassTeachers(objClassTeachers.ClassTeacherID,objClassTeachers.ClassID,objClassTeachers.SectionID,objClassTeachers.SubjectID,objClassTeachers.TeacherID,objClassTeachers.UserID,objClassTeachers.IsEnabled,objClassTeachers.DateCreated,objClassTeachers.Remarks).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteClassTeachers(int intClassTeacherID)
		{
			try
			{
				DataKernal.ClassTeachers objClassTeachers = new DataKernal.ClassTeachers();
				return objClassTeachers.DeleteClassTeachers(intClassTeacherID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteClassTeachers()
		{
			try
			{
				DataKernal.ClassTeachers objClassTeachers = new DataKernal.ClassTeachers();
				return objClassTeachers.DeleteClassTeachers().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateClassTeachers()
		{
			try
			{
				DataKernal.ClassTeachers objClassTeachers = new DataKernal.ClassTeachers();
				return objClassTeachers.ClassTeachersTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
	}
}