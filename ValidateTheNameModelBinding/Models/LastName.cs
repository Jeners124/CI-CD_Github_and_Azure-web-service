using System.Text.RegularExpressions;

namespace ValidateTheNameModelBinding.Models
{
  public class LastName
  {
    private string _lastName;
    public LastName(string lastName)
    {
      IsNameValid(lastName);
      _lastName = lastName;
    }

    public string GetValue()
    {
      return _lastName;
    }

    private void IsNameValid(string lastName)
    {
      if (string.IsNullOrEmpty(lastName))
      {
        throw new ArgumentException("name is null");
      }

      if (lastName.Length <= 20 && lastName.Length >= 1)
      {
        var pattern = @"^[a-zA-Z]+$";
        var inputValidation = Regex.IsMatch(lastName, pattern);

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