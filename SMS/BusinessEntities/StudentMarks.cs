using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class StudentMarks
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intMarksID;
Int64 intStudentID;
Int64 intSubjectID;
Int64 intClassID;
Int64 intObtainedMarks;
bool blnIsEnabled;
DateTime datDateCreated;
string strRemarks;
Int64 intUserID;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
public Int64 MarksID
{
	get
	{
		return intMarksID;
	}
	set
	{
		intMarksID = value;
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
public Int64 SubjectID
{
	get
	{
		return intSubjectID;
	}
	set
	{
		intSubjectID = value;
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
public Int64 ObtainedMarks
{
	get
	{
		return intObtainedMarks;
	}
	set
	{
		intObtainedMarks = value;
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