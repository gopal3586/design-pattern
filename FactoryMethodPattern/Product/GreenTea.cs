namespace TeaVendingMachine
{
    public class GreenTea: Tea
    {
        public override  void PrepareTea()
        {
            Console.WriteLine("Order GREEN TEA:");
            Console.WriteLine("     Pouring green tea decoction 50 ml.");            
        }
    }
}