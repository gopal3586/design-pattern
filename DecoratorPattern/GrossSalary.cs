public class GrossSalary: TaxableIncome
{
    decimal grossSalary = 0;
    public GrossSalary(decimal salary)
    {
        this.grossSalary = salary;
    }
    public override decimal GetIncome()
    {
        return grossSalary;
    }

}