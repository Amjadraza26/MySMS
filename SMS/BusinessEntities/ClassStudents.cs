using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class ClassStudents
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intClassStudentID;
Int64 intClassID;
Int64 intSectionID;
Int64 intStudentID;
Int64 intUserID;
DateTime datDateCreated;
bool blnIsEnabled;
string strRemarks;
Int64 intRollNo;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
public Int64 ClassStudentID
{
	get
	{
		return intClassStudentID;
	}
	set
	{
		intClassStudentID = value;
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
public Int64 SectionID
{
	get
	{
		return intSectionID;
	}
	set
	{
		intSectionID = value;
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
public Int64 RollNo
{
	get
	{
		return intRollNo;
	}
	set
	{
		intRollNo = value;
	}
}
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}