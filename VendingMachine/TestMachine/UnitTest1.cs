using VendingMachine;
using static System.Console;

namespace TestMachine
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVendDrink()
        {
            // Arrange
            var vendingMachine = new Vending();
            var input = new StringReader("drink\n");
            SetIn(input);
            var output = new StringWriter();
            SetOut(output);

            // Act
            vendingMachine.Vend();

            // Assert
            StringAssert.Contains("Would you like a cold drink or a hot drink?", output.ToString());
        }

        [TestMethod]
        public void TestCallSnack() 
        {
            // Arrange
            var vendingMachine = new Vending();
            var input = new StringReader("snack\n");
            SetIn(input);
            var output = new StringWriter();    
            SetOut(output);

            // Act
            vendingMachine.Vend();

            // Assert
            StringAssert.Contains("Choose your snack:", output.ToString());
        }

        [TestMethod]
        public void TestReturnCorrectSnack()
        {
            // Arrange
            var vendingMachine = new Vending();
            var input = new StringReader("Potato Chips\n");
            SetIn(input);
            var output = new StringWriter();
            SetOut(output);

            // Act
            vendingMachine.Snack();

            // Assert
            StringAssert.Contains("You got potato chips!", output.ToString());
        }

        [TestMethod]
        public void TestCallColdDrink()
        {
            // Arrange
            var vendingMachine = new Vending();
            var input = new StringReader("cold\n");
            SetIn(input);
            var output = new StringWriter();
            SetOut(output);

            // Act
            vendingMachine.Drink();

            // Assert
            StringAssert.Contains("Choose your cold drink:", output.ToString());
        }

        [TestMethod]
        public void TestReturnCorrectColdDrink()
        {
            // Arrange
            var vendingMachine = new Vending();
            var input = new StringReader("Cola\n");
            SetIn(input);
            var output = new StringWriter();
            SetOut(output);

            // Act
            vendingMachine.ColdDrink();

            // Assert
            StringAssert.Contains("You got cola!", output.ToString());
        }

        [TestMethod]
        public void TestReturnCorrectHotDrink()
        {
            // Arrange
            var vendingMachine = new Vending();
            var input = new StringReader("Espresso\n");
            SetIn(input);
            var output = new StringWriter();
            SetOut(output);

            // Act
            vendingMachine.HotDrink();

            // Assert
            StringAssert.Contains("You got espresso!", output.ToString());
        }
    }
}