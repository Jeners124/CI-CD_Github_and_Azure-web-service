namespace ValidateTheNameModelBinding.Models
{
  public class Person
  {
    private FirstName firstName;
    private LastName lastName;

    public Person(FirstName firstName, LastName lastName)
    {
      isNotNull(firstName);
      isNotNull(lastName);

      this.firstName = firstName;
      this.lastName = lastName;
    }

    private void isNotNull(object name)
    {
      if (name is not null)
      {
        throw new ArgumentException("name is null");
      }


    }
  }
}
