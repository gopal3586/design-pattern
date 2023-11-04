namespace TeaVendingMachine
{
    public class SpecialTea: Tea
    {
        IMilk milk;
        List<string> herbals ;
        public SpecialTea(ITeaIngredient ingredient)
        {
            milk = ingredient.GetMilk();;
            herbals = ingredient.GetHerbalExtract();
        }
        public override  void PrepareTea()
        {
            Console.WriteLine("Order SPECIAL TEA:");
            Console.WriteLine("     Pouring tea decoction 25 ml.");
            if (herbals != null && herbals.Count > 0)
            {
                Console.WriteLine(" with the following extracts ");
                foreach(string herb in herbals)
                {
                    Console.Write( string.Format("{0} ", herb));
                }
            }
            milk.PourMilk();
        }
    }
}