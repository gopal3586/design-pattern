namespace VisitorPattern
{
    public class RupeeCurrencyConverter: ICurrencyConverter
    {
        public void ConvertCurrency(decimal price)
        {
            Console.WriteLine($"Price: Rs.{price}");
        }
    }
}