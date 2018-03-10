using System.Data;

namespace LogicKernal
{
	public class FeeVouchers
	{
		public static DataTable GetAllFeeVouchers()
		{
			try
			{
				DataKernal.FeeVouchers objFeeVouchers =  new DataKernal.FeeVouchers();
				return objFeeVouchers.SelectFeeVouchers().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable GetFeeVouchersByID(int intVoucherID)
		{
			try
			{
				DataKernal.FeeVouchers objFeeVouchers = new DataKernal.FeeVouchers();
				return objFeeVouchers.SelectFeeVouchers(intVoucherID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
        public static DataTable GetUpaidVoucher(string IsEnabled="True")
        {
            try
            {
                DataTable dtVouchers = GetAllFeeVouchers();
                DataRow[] rows = dtVouchers.Select("IsEnabled = " + IsEnabled);
                dtVouchers = new DataTable();
                if (rows.Length > 0)
                    dtVouchers = rows.CopyToDataTable();
                return dtVouchers;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        public static DataTable InsertUpdateFeeVouchers(BusinessEntities.FeeVouchers objFeeVouchers)
		{
			try
			{
				DataKernal.FeeVouchers objDFeeVouchers = new DataKernal.FeeVouchers();
				return objDFeeVouchers.InsertUpdateFeeVouchers(objFeeVouchers.VoucherID,objFeeVouchers.StudentID,objFeeVouchers.DateVoucherIssue,objFeeVouchers.DateVoucherSubmit,objFeeVouchers.CollectedFee,objFeeVouchers.UserID,objFeeVouchers.IsEnabled,objFeeVouchers.Remarks).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}

		public static DataTable DeleteFeeVouchers(int intVoucherID)
		{
			try
			{
				DataKernal.FeeVouchers objFeeVouchers = new DataKernal.FeeVouchers();
				return objFeeVouchers.DeleteFeeVouchers(intVoucherID).Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
		public static DataTable DeleteFeeVouchers()
		{
			try
			{
				DataKernal.FeeVouchers objFeeVouchers = new DataKernal.FeeVouchers();
				return objFeeVouchers.DeleteFeeVouchers().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
    
		public static DataTable TruncateFeeVouchers()
		{
			try
			{
				DataKernal.FeeVouchers objFeeVouchers = new DataKernal.FeeVouchers();
				return objFeeVouchers.FeeVouchersTruncate().Tables[0];
			}
			catch (System.Exception ex)
			{
				return null;
			}
		}
	}
}