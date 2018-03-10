using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class ClassSections
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intSectionID;
string strSectionName;
Int64 intClassID;
DateTime datDateCreated;
bool blnIsEnabled;
string strRemarks;
Int64 intUserID;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
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
public string SectionName
{
	get
	{
		return strSectionName;
	}
	set
	{
		strSectionName = value;
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