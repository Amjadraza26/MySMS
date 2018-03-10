using System.Data;

namespace LogicKernal
{
	public class Teachers
	{
		public static DataTable GetAllTeachers()
		{
			try
			{
				DataKernal.Teachers objTeachers =  new DataKernal.Teachers();
				return objTeachers.SelectTeachers().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable GetTeachersByID(int intClassID)
		{
			try
			{
				DataKernal.Teachers objTeachers = new DataKernal.Teachers();
				return objTeachers.SelectTeachers(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable InsertUpdateTeachers(BusinessEntities.Teachers objTeachers)
		{
			try
			{
				DataKernal.Teachers objDTeachers = new DataKernal.Teachers();
				return objDTeachers.InsertUpdateTeachers(objTeachers.TeacherID,objTeachers.TeacherName,objTeachers.TeacherEmail,objTeachers.TeacherEducation,objTeachers.TeacherSpecialization,objTeachers.TeacherContactNo,objTeachers.TeacherImage,objTeachers.DateCreated,objTeachers.IsEnabled,objTeachers.Remarks,objTeachers.UserID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteTeachers(int intClassID)
		{
			try
			{
				DataKernal.Teachers objTeachers = new DataKernal.Teachers();
				return objTeachers.DeleteTeachers(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteTeachers()
		{
			try
			{
				DataKernal.Teachers objTeachers = new DataKernal.Teachers();
				return objTeachers.DeleteTeachers().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateTeachers()
		{
			try
			{
				DataKernal.Teachers objTeachers = new DataKernal.Teachers();
				return objTeachers.TeachersTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
	}
}