using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class Students
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intStudentID;
string strStudentName;
string strFatherName;
bool blnGender;
string strCNIC;
DateTime datDOB;
string strEmail;
string strContactNo;
string strAddress;
string strImage;
bool blnDisability;
bool blnDiscounted;
bool blnIsEnabled;
DateTime datDateCreated;
string strRemarks;
Int64 intUserID;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
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
public string StudentName
{
	get
	{
		return strStudentName;
	}
	set
	{
		strStudentName = value;
	}
}
public string FatherName
{
	get
	{
		return strFatherName;
	}
	set
	{
		strFatherName = value;
	}
}
public bool Gender
{
	get
	{
		return blnGender;
	}
	set
	{
		blnGender = value;
	}
}
public string CNIC
{
	get
	{
		return strCNIC;
	}
	set
	{
		strCNIC = value;
	}
}
public DateTime DOB
{
	get
	{
		return datDOB;
	}
	set
	{
		datDOB = value;
	}
}
public string Email
{
	get
	{
		return strEmail;
	}
	set
	{
		strEmail = value;
	}
}
public string ContactNo
{
	get
	{
		return strContactNo;
	}
	set
	{
		strContactNo = value;
	}
}
public string Address
{
	get
	{
		return strAddress;
	}
	set
	{
		strAddress = value;
	}
}
public string Image
{
	get
	{
		return strImage;
	}
	set
	{
		strImage = value;
	}
}
public bool Disability
{
	get
	{
		return blnDisability;
	}
	set
	{
		blnDisability = value;
	}
}
public bool Discounted
{
	get
	{
		return blnDiscounted;
	}
	set
	{
		blnDiscounted = value;
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