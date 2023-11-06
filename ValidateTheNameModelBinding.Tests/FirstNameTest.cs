using ValidateTheNameModelBinding.Models;

namespace ValidateTheNameModelBinding.Tests;

public class FirstNameTest
{
  [Theory]
  [InlineData("Bo")]
  [InlineData("Magnus")]
  // [InlineData("HejMedDigDetteSkulleGerneVaereEtLangtNavn")]
  public void NameLenghtTest(string name)
  {
    FirstName firstName = new FirstName(name);
  }

  [Theory]
  [InlineData("")]
  [InlineData("123")]
  [InlineData("���")]
  [InlineData("<>'/")]
  public void NameCharacterTest(string name)
  {
    Assert.Throws<ArgumentException>(() => new FirstName(name));
    
  }

  [Fact]
  public void NameNullTest()
  {
    Assert.Throws<ArgumentException>(() => new FirstName(null));
  }
}