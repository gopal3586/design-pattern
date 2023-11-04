namespace TeaVendingMachine
{
    public class KLTeaIngredient: ITeaIngredient
    {
         public IMilk GetMilk()
         {
            return new BuffaloMilk();
         }
         public List<string> GetHerbalExtract() 
         {
            List<string> herbals = new List<string>();
            herbals.Add("Cardamom");
            return herbals;
         }
    }
}