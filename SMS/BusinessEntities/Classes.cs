using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class Classes
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intClassID;
string strClassName;
string strNumericName;
Int64 intUserID;
DateTime datDateCreated;
bool blnIsEnabled;
string strRemarks;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
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
public string ClassName
{
	get
	{
		return strClassName;
	}
	set
	{
		strClassName = value;
	}
}
public string NumericName
{
	get
	{
		return strNumericName;
	}
	set
	{
		strNumericName = value;
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
		///////////////////////////////////////////////////////////////////////////////////////////
	}
}