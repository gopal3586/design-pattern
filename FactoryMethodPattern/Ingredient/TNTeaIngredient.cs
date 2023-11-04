namespace TeaVendingMachine
{
    public class TNTeaIngredient: ITeaIngredient
    {
         public IMilk GetMilk()
         {
            return new CowMilk();
         }
         public List<string> GetHerbalExtract() 
         {
            List<string> herbals = new List<string>();
            herbals.Add("Ginger");
            return herbals;
         }
    }
}