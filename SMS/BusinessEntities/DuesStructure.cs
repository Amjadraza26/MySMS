using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class DuesStructure
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intDueAmountID;
Int64 intClassID;
Int64 intTotalFee;
DateTime datDateCreated;
bool blnIsEnabled;
string strRemarks;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
public Int64 DueAmountID
{
	get
	{
		return intDueAmountID;
	}
	set
	{
		intDueAmountID = value;
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
public Int64 TotalFee
{
	get
	{
		return intTotalFee;
	}
	set
	{
		intTotalFee = value;
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