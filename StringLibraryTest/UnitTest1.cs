using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;
namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
  
   [TestMethod]
    public void Test_Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        decimal number1 = 3.5m;
        decimal number2 = 4.2m;
        decimal expectedSum = 7.7m;

        // Act
        decimal actualSum = StringLibrary.Add(number1, number2);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }
 [TestMethod]
    public void Test_Add_TwoNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        decimal number1 = -3.5m;
        decimal number2 = -4.2m;
        decimal expectedSum = -7.7m;

        // Act
        decimal actualSum = StringLibrary.Add(number1, number2);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }
  [TestMethod]
    public void Test_Add_PositiveAndNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        decimal number1 = 3.5m;
        decimal number2 = -4.2m;
        decimal expectedSum = -0.7m;

        // Act
        decimal actualSum = StringLibrary.Add(number1, number2);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }
  [TestMethod]
    public void Test_Add_TwoZeroes_ReturnsZero()
    {
        // Arrange
        decimal number1 = 0m;
        decimal number2 = 0m;
        decimal expectedSum = 0m;

        // Act
        decimal actualSum = StringLibrary.Add(number1, number2);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }
 [TestMethod]
    public void Test_Add_DecimalAndInteger_ReturnsCorrectSum()
    {
        // Arrange
        decimal number1 = 3.5m;
        decimal number2 = 4;
        decimal expectedSum = 7.5m;

        // Act
        decimal actualSum = StringLibrary.Add(number1, number2);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    } 
 [TestMethod]
    public void Test_Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        decimal number1 = 5.5m;
        decimal number2 = 2.3m;
        decimal expectedDifference = 3.2m;

        // Act
        decimal actualDifference = StringLibrary.Subtract(number1, number2);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
    }
    

}