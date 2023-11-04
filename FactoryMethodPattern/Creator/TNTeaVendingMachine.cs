namespace TeaVendingMachine
{
    public  class TNTeaVendingMachine: TeaVendingMachine
    {
         public override void OrderTea(string teaType)
        {
            Tea? tea = null;
            switch(teaType)
            {
                case "TEA":
                    tea =  new MilkTea();
                    break;
                
                case "SPECIAL TEA":
                    tea =  new SpecialTea(new TNTeaIngredient());
                    break;
             
            }
            tea =  tea == null ? new MilkTea() : tea;
            tea.PrepareTea();

        }
        
    }

}