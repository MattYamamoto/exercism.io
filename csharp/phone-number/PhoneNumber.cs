using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
  public const string pattern = @"^\D*1?\D*([2-9]\d{2})\D*([2-9]\d{2})\D*(\d{4})$";
  public static string Clean(string phoneNumber)
  {

    Match m = Regex.Match(phoneNumber.Trim(), pattern);

    if (!m.Success)
    {
      throw new ArgumentException("Not a valid NANP phone number");
    }

    string cleanNumber = m.Groups[1].Value + m.Groups[2].Value + m.Groups[3].Value;

    return cleanNumber;
  }
}
