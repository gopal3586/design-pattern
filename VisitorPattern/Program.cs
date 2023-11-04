using VisitorPattern;
// See https://aka.ms/new-console-template for more information
List<IFoodItem> foodList = new List<IFoodItem>();
foodList.Add(new Dosa());
foodList.Add(new Idly());
foodList.Add(new Vada());
foodList.Add(new Pongal());

ICurrencyVisitor dollarVisitor = new RupeeCurrency();

foreach(IVisitable visitable in foodList)
{
    visitable.Accept(dollarVisitor);
}



