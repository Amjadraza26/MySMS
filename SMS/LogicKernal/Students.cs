using System.Data;

namespace LogicKernal
{
	public class Students
	{
		public static DataTable GetAllStudents()
		{
			try
			{
				DataKernal.Students objStudents =  new DataKernal.Students();
				return objStudents.SelectStudents().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable GetStudentsByID(int intClassID)
		{
			try
			{
				DataKernal.Students objStudents = new DataKernal.Students();
				return objStudents.SelectStudents(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable InsertUpdateStudents(BusinessEntities.Students objStudents)
		{
            try
            {
                DataKernal.Students objDStudents = new DataKernal.Students();
                return objDStudents.InsertUpdateStudents(objStudents.StudentID, objStudents.StudentName, objStudents.FatherName, objStudents.Gender, objStudents.CNIC, objStudents.DOB, objStudents.Email, objStudents.ContactNo, objStudents.Address, objStudents.Image, objStudents.Disability, objStudents.Discounted, objStudents.IsEnabled, objStudents.DateCreated, objStudents.Remarks, objStudents.UserID).Tables[0];
            }
            catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteStudents(int intClassID)
		{
			try
			{
				DataKernal.Students objStudents = new DataKernal.Students();
				return objStudents.DeleteStudents(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteStudents()
		{
			try
			{
				DataKernal.Students objStudents = new DataKernal.Students();
				return objStudents.DeleteStudents().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateStudents()
		{
			try
			{
				DataKernal.Students objStudents = new DataKernal.Students();
				return objStudents.StudentsTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
	}
}