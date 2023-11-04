

namespace VisitorPattern
{
    public class DollarCurrencyConverter : ICurrencyConverter
    {
        public void ConvertCurrency(decimal price)
        {
            Console.WriteLine($"Price: ${price/80}");
        }
    }
}