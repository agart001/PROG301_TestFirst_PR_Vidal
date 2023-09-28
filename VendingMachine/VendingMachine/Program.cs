using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using static System.Console;

namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vending vendingMachine = new Vending();
            vendingMachine.Vend();
        }

    }
}