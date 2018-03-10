using System.Data;

namespace LogicKernal
{
	public class StudentMarks
	{
		public static DataTable GetAllStudentMarks()
		{
			try
			{
				DataKernal.StudentMarks objStudentMarks =  new DataKernal.StudentMarks();
				return objStudentMarks.SelectStudentMarks().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable GetStudentMarksByID(int intClassID)
		{
			try
			{
				DataKernal.StudentMarks objStudentMarks = new DataKernal.StudentMarks();
				return objStudentMarks.SelectStudentMarks(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable InsertUpdateStudentMarks(BusinessEntities.StudentMarks objStudentMarks)
		{
			try
			{
				DataKernal.StudentMarks objDStudentMarks = new DataKernal.StudentMarks();
				return objDStudentMarks.InsertUpdateStudentMarks(objStudentMarks.MarksID,objStudentMarks.StudentID,objStudentMarks.SubjectID,objStudentMarks.ClassID,objStudentMarks.ObtainedMarks,objStudentMarks.IsEnabled,objStudentMarks.DateCreated,objStudentMarks.Remarks,objStudentMarks.UserID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteStudentMarks(int intClassID)
		{
			try
			{
				DataKernal.StudentMarks objStudentMarks = new DataKernal.StudentMarks();
				return objStudentMarks.DeleteStudentMarks(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteStudentMarks()
		{
			try
			{
				DataKernal.StudentMarks objStudentMarks = new DataKernal.StudentMarks();
				return objStudentMarks.DeleteStudentMarks().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateStudentMarks()
		{
			try
			{
				DataKernal.StudentMarks objStudentMarks = new DataKernal.StudentMarks();
				return objStudentMarks.StudentMarksTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
	}
}