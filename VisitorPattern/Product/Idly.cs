namespace VisitorPattern
{
    public class Idly :  IFoodItem, IVisitable
    {

        public string Name {get; private set;} = "Idly";
        public decimal GetPrice()
        {
            return 10;
        }
        public void Accept(ICurrencyVisitor visitor)
        {
            visitor.ConvertCurrency(this);
        }


    }
}