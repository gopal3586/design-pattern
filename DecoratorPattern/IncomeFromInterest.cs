public class IncomeFromInterest: TaxableIncome
{
    decimal incomeFromInterest = 0;
    public IncomeFromInterest(decimal income)
    {
        this.incomeFromInterest = income;
    }

    public override decimal GetIncome()
    {
        return this.incomeFromInterest;
    }
}