using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class Subjects
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intSubjectID;
string strSubjectName;
Int64 intClassID;
bool blnIsEnabled;
DateTime datDateCreated;
string strRemarks;
Int64 intUserID;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
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
public string SubjectName
{
	get
	{
		return strSubjectName;
	}
	set
	{
		strSubjectName = value;
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