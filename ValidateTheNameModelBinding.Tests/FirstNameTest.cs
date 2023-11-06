using ValidateTheNameModelBinding.Models;

namespace ValidateTheNameModelBinding.Tests;

public class FirstNameTest
{
  [Theory]
  [InlineData("Bo")]
  [InlineData("Magnus")]
  [InlineData("HejMedDigDetteSkulleGerneVaereEtLangtNavn")]
  public void NameLenghtTest(string name)
  {
    //FirstName firstName = new FirstName(name);
  }

  [Theory]
  [InlineData("")]
  [InlineData("123")]
  [InlineData("זרו")]
  [InlineData("<>'/")]
  public void NameCharacterTest(string name)
  {
    //FirstName firstName = new FirstName(name);
  }

  [Fact]
  public void NameNullTest()
  {
    //FirstName firstName = new FirstName(null);
  }
}