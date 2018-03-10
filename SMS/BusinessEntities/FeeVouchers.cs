using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class FeeVouchers
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intVoucherID;
Int64 intStudentID;
DateTime datDateVoucherIssue;
string strDateVoucherSubmit;
string strCollectedFee;
Int64 intUserID;
bool blnIsEnabled;
string strRemarks;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
public Int64 VoucherID
{
	get
	{
		return intVoucherID;
	}
	set
	{
		intVoucherID = value;
	}
}
public Int64 StudentID
{
	get
	{
		return intStudentID;
	}
	set
	{
		intStudentID = value;
	}
}
public DateTime DateVoucherIssue
{
	get
	{
		return datDateVoucherIssue;
	}
	set
	{
		datDateVoucherIssue = value;
	}
}
public string DateVoucherSubmit
{
	get
	{
		return strDateVoucherSubmit;
	}
	set
	{
		strDateVoucherSubmit = value;
	}
}
public string CollectedFee
{
	get
	{
		return strCollectedFee;
	}
	set
	{
		strCollectedFee = value;
	}
}
public Int64 UserID
{
	get
	{
		return intUserID;
	}
	set
	{
		intUserID = value;
	}
}
public bool IsEnabled
{
	get
	{
		return blnIsEnabled;
	}
	set
	{
		blnIsEnabled = value;
	}
}
public string Remarks
{
	get
	{
		return strRemarks;
	}
	set
	{
		strRemarks = value;
	}
}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}