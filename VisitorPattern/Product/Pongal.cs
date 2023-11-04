namespace VisitorPattern
{
    public class Pongal : IFoodItem,IVisitable
    {

        public string Name {get; private set;} = "Pongal";
        public decimal GetPrice()
        {
            return 50;
        }

        public void Accept(ICurrencyVisitor visitor)
        {
            visitor.ConvertCurrency(this);
        }


    }
}