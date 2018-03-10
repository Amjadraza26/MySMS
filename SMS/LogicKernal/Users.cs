using System.Data;

namespace LogicKernal
{
	public class Users
	{
		public static DataTable GetAllUsers()
		{
			try
			{
				DataKernal.Users objUsers =  new DataKernal.Users();
				return objUsers.SelectUsers().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable GetUsersByID(int intClassID)
		{
			try
			{
				DataKernal.Users objUsers = new DataKernal.Users();
				return objUsers.SelectUsers(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable InsertUpdateUsers(BusinessEntities.Users objUsers)
		{
			try
			{
				DataKernal.Users objDUsers = new DataKernal.Users();
				return objDUsers.InsertUpdateUsers(objUsers.UserID,objUsers.UserName,objUsers.EmailAddress,objUsers.UserPassword,objUsers.IsEnabled,objUsers.DateCreated,objUsers.Remarks).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteUsers(int intClassID)
		{
			try
			{
				DataKernal.Users objUsers = new DataKernal.Users();
				return objUsers.DeleteUsers(intClassID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteUsers()
		{
			try
			{
				DataKernal.Users objUsers = new DataKernal.Users();
				return objUsers.DeleteUsers().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateUsers()
		{
			try
			{
				DataKernal.Users objUsers = new DataKernal.Users();
				return objUsers.UsersTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
        public static class LoginInfo
        {
            public static int UserID;
        }
        public static  int Login(string Email, string Password)
        {
            DataTable dtUsers = GetAllUsers();
            foreach (DataRow dr in dtUsers.Rows)
            {
                if (dr["EmailAddress"].ToString() == Email)
                {
                    if (dr["UserPassword"].ToString() == Password)
                        return int.Parse(dr["UserID"].ToString());
                }
            }

            return 0;
        }

    }
}