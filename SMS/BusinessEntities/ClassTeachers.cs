using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class ClassTeachers
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intClassTeacherID;
Int64 intClassID;
Int64 intSectionID;
Int64 intSubjectID;
Int64 intTeacherID;
Int64 intUserID;
bool blnIsEnabled;
DateTime datDateCreated;
string strRemarks;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
public Int64 ClassTeacherID
{
	get
	{
		return intClassTeacherID;
	}
	set
	{
		intClassTeacherID = value;
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
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}