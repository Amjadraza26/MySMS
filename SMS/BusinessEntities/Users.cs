using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class Users
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intUserID;
string strUserName;
string strEmailAddress;
string strUserPassword;
bool blnIsEnabled;
DateTime datDateCreated;
string strRemarks;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
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
public string UserName
{
	get
	{
		return strUserName;
	}
	set
	{
		strUserName = value;
	}
}
public string EmailAddress
{
	get
	{
		return strEmailAddress;
	}
	set
	{
		strEmailAddress = value;
	}
}
public string UserPassword
{
	get
	{
		return strUserPassword;
	}
	set
	{
		strUserPassword = value;
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