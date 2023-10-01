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
            var vendingMachine = new Vending(true);
            vendingMachine.CurrentInputText = "drink";

            // Act
            vendingMachine.Vend();

            // Assert
            StringAssert.Contains("Would you like a cold drink or a hot drink?", vendingMachine.CurrentOutputText);
        }

        [TestMethod]
        public void TestCallSnack() 
        {
            // Arrange
            var vendingMachine = new Vending(true);
            vendingMachine.CurrentInputText = "snack";

            // Act
            vendingMachine.Vend();

            // Assert
            StringAssert.Contains("Choose your snack:", vendingMachine.CurrentInputText);
        }

        [TestMethod]
        public void TestReturnCorrectSnack()
        {
            // Arrange
            var vendingMachine = new Vending(true);
            vendingMachine.CurrentInputText = "Potato Chips";
            // Act
            vendingMachine.Snack();

            // Assert
            StringAssert.Contains("You got potato chips!", vendingMachine.CurrentOutputText);
        }

        [TestMethod]
        public void TestCallColdDrink()
        {
            // Arrange
            var vendingMachine = new Vending(true);
            vendingMachine.CurrentInputText = "cold";

            // Act
            vendingMachine.Drink();

            // Assert
            StringAssert.Contains("Choose your cold drink:", vendingMachine.CurrentOutputText);
        }

        [TestMethod]
        public void TestReturnCorrectColdDrink()
        {
            // Arrange
            var vendingMachine = new Vending(true);
            vendingMachine.CurrentInputText = "Cola";

            // Act
            vendingMachine.ColdDrink();

            // Assert
            StringAssert.Contains("You got cola!", vendingMachine.CurrentOutputText);
        }

        [TestMethod]
        public void TestReturnCorrectHotDrink()
        {
            // Arrange
            var vendingMachine = new Vending(true);
            vendingMachine.CurrentInputText = "Espresso";

            // Act
            vendingMachine.HotDrink();

            // Assert
            StringAssert.Contains("You got espresso!", vendingMachine.CurrentOutputText);
        }
    }
}