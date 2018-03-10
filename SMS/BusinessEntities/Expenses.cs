using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
	public class Expenses
	{
		//Private Variables////////////////////////////////////////////////////////////////////////
		Int64 intExpensesID;
string strExpenseName;
string strExpenseType;
DateTime datDateCreated;
bool blnIsEnabled;
string strRemarks;
Int64 intUserID;

		///////////////////////////////////////////////////////////////////////////////////////////
		
		//Public Properties////////////////////////////////////////////////////////////////////////
		
public Int64 ExpensesID
{
	get
	{
		return intExpensesID;
	}
	set
	{
		intExpensesID = value;
	}
}
public string ExpenseName
{
	get
	{
		return strExpenseName;
	}
	set
	{
		strExpenseName = value;
	}
}
public string ExpenseType
{
	get
	{
		return strExpenseType;
	}
	set
	{
		strExpenseType = value;
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