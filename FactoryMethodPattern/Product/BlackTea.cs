namespace TeaVendingMachine
{
    public class BlackTea: Tea
    {
        public override void PrepareTea()
        {
            Console.WriteLine("Order BLACK TEA");
            Console.WriteLine("     Pouring tea decoction 50 ml.");            
        }
    }
}