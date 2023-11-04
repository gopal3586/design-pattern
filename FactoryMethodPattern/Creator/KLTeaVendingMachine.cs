namespace TeaVendingMachine
{
    public  class KLTeaVendingMachine: TeaVendingMachine
    {
         public  override void OrderTea(string teaType)
        {
            Tea? tea = null;
            switch(teaType)
            {
                case "TEA":
                    tea =  new BlackTea();
                    break;
                
                case "SPECIAL TEA":
                    tea =  new SpecialTea(new KLTeaIngredient());
                    break;
             
            }
            tea =  tea == null ? new MilkTea() : tea;
            tea.PrepareTea();

        }
        
    }

}