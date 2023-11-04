namespace TeaVendingMachine

{
    public class Program
    {
        public static void Main(string[] args)
        {
            TeaVendingMachine vendingMachine = new KLTeaVendingMachine();
            vendingMachine.OrderTea("TEA");
            vendingMachine.OrderTea("SPECIAL TEA");
            Console.ReadLine();
        }
    }
} 