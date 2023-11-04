namespace TeaVendingMachine
{
    public interface ITeaIngredient
    {
         IMilk GetMilk();       
         List<string> GetHerbalExtract() ; 
    }
}