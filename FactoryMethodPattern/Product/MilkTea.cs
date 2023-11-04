namespace TeaVendingMachine
{
    public class MilkTea: Tea
    {
        public override  void PrepareTea()
        {
            Console.WriteLine("Order TEA:");
            Console.WriteLine("     Pouring tea decoction 25 ml.");
            Console.WriteLine("     Pouring milk 25 ml.");
        }
    }
}