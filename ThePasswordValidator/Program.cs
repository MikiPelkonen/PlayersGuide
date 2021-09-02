using System;

while (true)
{
    Console.Write("Enter password: ");
    string input = Console.ReadLine();
    PasswordValidator pwValid = new PasswordValidator(input);
    pwValid.ValidatePassword();

}

public class PasswordValidator
{
    private string _pw;

    bool IsValidLength
    {
        get
        {
            if (_pw.Length >= 6 && _pw.Length <= 13)
                return true;
            return false;
        }
    }

    bool ContainsUppercase
    {
        get
        {
            foreach (char c in _pw)
            {
                if (char.IsUpper(c))
                    return true;
            }
            return false;
        }
    }

    bool ContainsLowercase
    {
        get
        {
            foreach (char c in _pw)
            {
                if (char.IsLower(c))
                    return true;
            }
            return false;
        }
    }
    
    bool ContainsNumber
    {
        get
        {
            foreach (char c in _pw)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }
    }

    bool Restriction
    {
        get
        {
            foreach (char c in _pw)
            {
                if (c.Equals('T') || c.Equals('&'))
                    return false;
            }
            return true;
        }
    }

    public PasswordValidator(string password)
    {
        _pw = password;
    }

    public void ValidatePassword()
    {
        if (IsValidLength && ContainsUppercase && ContainsLowercase && ContainsNumber && Restriction)
            Console.WriteLine("Password is valid.");
        else
            Console.WriteLine("Invalid password.");
    }


}
