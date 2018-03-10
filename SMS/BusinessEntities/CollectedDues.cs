using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class CollectedDues
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intDuesID;
string strDuesMonth;
Int64 intStudentID;
Int64 intClassID;
        Int64 intPayment;
DateTime datDateCreated;
bool blnIsEnabled;
string strRemarks;
Int64 intUserID;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
public Int64 DuesID
{
	get
	{
		return intDuesID;
	}
	set
	{
		intDuesID = value;
	}
}
public string DuesMonth
{
	get
	{
		return strDuesMonth;
	}
	set
	{
		strDuesMonth = value;
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
        public Int64 ClassID
        {
            get
            {
                return intClassID;
            }
            set
            {
                intClassID = value;
            }
        }
        public Int64 Payment
{
	get
	{
		return intPayment;
	}
	set
	{
		intPayment = value;
	}
}
public DateTime DateCreated
{
	get
	{
		return datDateCreated;
	}
	set
	{
		datDateCreated = value;
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
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}