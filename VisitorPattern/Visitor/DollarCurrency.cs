 namespace VisitorPattern
{
    public class DollarCurrency : ICurrencyVisitor

    {
        public void ConvertCurrency(IFoodItem item)
        {
                Console.WriteLine($"{item.Name} price is $.{item.GetPrice()/80}");
        }
        
    }
}