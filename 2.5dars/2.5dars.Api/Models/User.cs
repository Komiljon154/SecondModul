using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5dars.Api.Models;

public class User
{
	private string _firstName;

	public string FirstName
	{
		get { return _firstName; }
		set { _firstName = value; }
	}

    private string _lastName

    public string LastName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
	private int _age;

	public int Age
	{
		get { return _age; }
		set { _age = value; }
	}

	private string _passwordd;

	public string Password
	{
		get { return _passwordd; }
		set { _passwordd = value; }
	}

	private int _email;

	public int Email
	{
		get { return _email; }
		set { _email = value; }
	}

	private string _phoneNumber;

	public string PhoneNumber
	{
		get { return _phoneNumber; }
		set { _phoneNumber = value; }
	}









}
