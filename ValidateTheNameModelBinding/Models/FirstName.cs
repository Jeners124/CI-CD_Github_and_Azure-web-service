using System.Text.RegularExpressions;

namespace ValidateTheNameModelBinding.Models
{
  public class FirstName
  {
    private string _firstName;

    public FirstName(string firstName)
    {
      IsNameValid(firstName);
      _firstName = firstName;
    }

    public string GetValue()
    {
      return _firstName;
    }

    private void IsNameValid(string firstName)
    {
      if (string.IsNullOrEmpty(firstName))
      {
        throw new ArgumentException("name is null");
      }

      if (firstName.Length <= 20 && firstName.Length >= 1)
      {
        var pattern = @"^[a-zA-Z]+$";
        var inputValidation = Regex.IsMatch(firstName, pattern);

        if (!inputValidation)
        {
          throw new ArgumentException("name not valid");
        }
      }
      else
      {
        throw new ArgumentException("name is not within length parameters");
      }
    }
  }
}
