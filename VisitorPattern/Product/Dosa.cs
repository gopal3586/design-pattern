namespace VisitorPattern
{
    public class Dosa : IFoodItem, IVisitable
    {


        public string Name {get; private set;} = "Dosa";

        public void Accept(ICurrencyVisitor visitor)
        {
            visitor.ConvertCurrency(this);
        }

        public decimal GetPrice()
        {
            return 80;
        }
        

    }
}