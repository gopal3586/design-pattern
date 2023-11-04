namespace VisitorPattern
{
    public class Vada :  IFoodItem, IVisitable
    {

        public string Name {get; private set;} = "Vada";
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
