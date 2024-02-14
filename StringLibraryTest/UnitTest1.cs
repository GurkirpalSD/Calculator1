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
     [TestMethod]
     
    public void Test_Subtract_PositiveAndNegativeNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        decimal number1 = 5.5m;
        decimal number2 = -2.3m;
        decimal expectedDifference = 7.8m;

        // Act
        decimal actualDifference = StringLibrary.Subtract(number1, number2);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
    }
  [TestMethod]
    public void Test_Subtract_TwoNegativeNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        decimal number1 = -5.5m;
        decimal number2 = -2.3m;
        decimal expectedDifference = -3.2m;

        // Act
        decimal actualDifference = StringLibrary.Subtract(number1, number2);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
    }
 [TestMethod]
    public void Test_Subtract_FromZero_ReturnsNegativeOfSecondNumber()
    {
        // Arrange
        decimal number1 = 0m;
        decimal number2 = 7.9m;
        decimal expectedDifference = -7.9m;

        // Act
        decimal actualDifference = StringLibrary.Subtract(number1, number2);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
    }
  [TestMethod]
    public void Test_Subtract_TwoZeroes_ReturnsZero()
    {
        // Arrange
        decimal number1 = 0m;
        decimal number2 = 0m;
        decimal expectedDifference = 0m;

        // Act
        decimal actualDifference = StringLibrary.Subtract(number1, number2);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
    }
      [TestMethod]
    public void Test_Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        decimal number1 = 2.5m;
        decimal number2 = 3.2m;
        decimal expectedProduct = 8.0m;

        // Act
        decimal actualProduct = StringLibrary.Multiply(number1, number2);

        // Assert
        Assert.AreEqual(expectedProduct, actualProduct);
    }
 [TestMethod]
    public void Test_Multiply_PositiveAndNegativeNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        decimal number1 = 2.5m;
        decimal number2 = -3.2m;
        decimal expectedProduct = -8.0m;

        // Act
        decimal actualProduct = StringLibrary.Multiply(number1, number2);

        // Assert
        Assert.AreEqual(expectedProduct, actualProduct);
    }
  [TestMethod]
    public void Test_Multiply_TwoNegativeNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        decimal number1 = -2.5m;
        decimal number2 = -3.2m;
        decimal expectedProduct = 8.0m;

        // Act
        decimal actualProduct = StringLibrary.Multiply(number1, number2);

        // Assert
        Assert.AreEqual(expectedProduct, actualProduct);
    }
  [TestMethod]
    public void Test_Multiply_OneZero_ReturnsZero()
    {
        // Arrange
        decimal number1 = 0m;
        decimal number2 = 7.9m;
        decimal expectedProduct = 0m;

        // Act
        decimal actualProduct = StringLibrary.Multiply(number1, number2);

        // Assert
        Assert.AreEqual(expectedProduct, actualProduct);
    }
[TestMethod]
    public void Test_Multiply_TwoZeroes_ReturnsZero()
    {
        // Arrange
        decimal number1 = 0m;
        decimal number2 = 0m;
        decimal expectedProduct = 0m;

        // Act
        decimal actualProduct = StringLibrary.Multiply(number1, number2);

        // Assert
        Assert.AreEqual(expectedProduct, actualProduct);
    }
 [TestMethod]
    public void Test_Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        decimal number1 = 10.0m;
        decimal number2 = 2.0m;
        decimal expectedQuotient = 5.0m;

        // Act
        decimal actualQuotient = StringLibrary.Divide(number1, number2);

        // Assert
        Assert.AreEqual(expectedQuotient, actualQuotient);
    }
    [TestMethod]
    public void Test_Divide_PositiveDividendAndNegativeDivisor_ReturnsCorrectQuotient()
    {
        // Arrange
        decimal number1 = 10.0m;
        decimal number2 = -2.0m;
        decimal expectedQuotient = -5.0m;

        // Act
        decimal actualQuotient = StringLibrary.Divide(number1, number2);

        // Assert
        Assert.AreEqual(expectedQuotient, actualQuotient);
    }
 [TestMethod]
    public void Test_Divide_NegativeDividendAndPositiveDivisor_ReturnsCorrectQuotient()
    {
        // Arrange
        decimal number1 = -10.0m;
        decimal number2 = 2.0m;
        decimal expectedQuotient = -5.0m;

        // Act
        decimal actualQuotient = StringLibrary.Divide(number1, number2);

        // Assert
        Assert.AreEqual(expectedQuotient, actualQuotient);
    }
   [TestMethod]
    public void Test_Divide_ZeroDividend_ReturnsZero()
    {
        // Arrange
        decimal number1 = 0m;
        decimal number2 = 10.0m;
        decimal expectedQuotient = 0m;

        // Act
        decimal actualQuotient = StringLibrary.Divide(number1, number2);

        // Assert
        Assert.AreEqual(expectedQuotient, actualQuotient);
    }
   [TestMethod]
public void Test_Divide_TwoNegativeNumbers_ReturnsCorrectQuotient()
{
    // Arrange
    decimal number1 = -10.0m;
    decimal number2 = -2.0m;
    decimal expectedQuotient = 5.0m;

    // Act
    decimal actualQuotient = StringLibrary.Divide(number1, number2);

    // Assert
    Assert.AreEqual(expectedQuotient, actualQuotient);
}
}