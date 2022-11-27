using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
public class RegexMessage
{
    public string FirstName(string firstName)
    {
        var regex = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
        bool matchRes = regex.IsMatch(firstName);
        if (matchRes == true)
        {
            return firstName;
        }
        else
        {
            Console.WriteLine($"\n{firstName} is invalid.");
            return null;
        }
    }

    public string FullName(string fullName)
    {
        var regex = new Regex(@"^[A-Z]{1}[a-z]{2,}\s[A-Z]{1}[a-z]{2,}$");
        bool matchRes = regex.IsMatch(fullName);
        if (matchRes == true)
        {
            return fullName;
        }
        else
        {
            Console.WriteLine($"\n{fullName} is invalid.");
            return null;
        }
    }

    public string PhoneNumber(string phoneNumber)
    {
        var regex = new Regex(@"^\+[1-9]{1}[0-9]{0,2}[\-][1-9]{1}[0-9]{9}");
        bool matchRes = regex.IsMatch(phoneNumber);
        if (matchRes == true)
        {
            return phoneNumber;
        }
        else
        {
            Console.WriteLine($"\n{phoneNumber} is invalid.");
            return null;
        }
    }

    public string Date(string date)
    {
        var regex = new Regex(@"^[\d]{2}/[\d]{2}/[\d]{4}$");
        bool matchRes = regex.IsMatch(date);
        if (matchRes == true)
        {
            return date;
        }
        else
        {
            Console.WriteLine($"\n{date} is invalid.");
            return null;
        }
    }
}