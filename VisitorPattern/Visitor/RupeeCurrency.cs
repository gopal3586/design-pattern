namespace VisitorPattern
{
    public class RupeeCurrency : ICurrencyVisitor
    {
        public void ConvertCurrency(IFoodItem item)
        {
                Console.WriteLine($"{item.Name} price is Rs.{item.GetPrice()}");
        }
        
    }
}