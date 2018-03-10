using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class Teachers
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intTeacherID;
string strTeacherName;
string strTeacherEmail;
string strTeacherEducation;
string strTeacherSpecialization;
string strTeacherContactNo;
string strTeacherImage;
DateTime datDateCreated;
bool blnIsEnabled;
string strRemarks;
Int64 intUserID;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
public Int64 TeacherID
{
	get
	{
		return intTeacherID;
	}
	set
	{
		intTeacherID = value;
	}
}
public string TeacherName
{
	get
	{
		return strTeacherName;
	}
	set
	{
		strTeacherName = value;
	}
}
public string TeacherEmail
{
	get
	{
		return strTeacherEmail;
	}
	set
	{
		strTeacherEmail = value;
	}
}
public string TeacherEducation
{
	get
	{
		return strTeacherEducation;
	}
	set
	{
		strTeacherEducation = value;
	}
}
public string TeacherSpecialization
{
	get
	{
		return strTeacherSpecialization;
	}
	set
	{
		strTeacherSpecialization = value;
	}
}
public string TeacherContactNo
{
	get
	{
		return strTeacherContactNo;
	}
	set
	{
		strTeacherContactNo = value;
	}
}
public string TeacherImage
{
	get
	{
		return strTeacherImage;
	}
	set
	{
		strTeacherImage = value;
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