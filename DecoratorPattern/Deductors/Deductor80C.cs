public class Deductor80C : TaxDeductor
{
    TaxableIncome taxableIncome ; 
    Dictionary<string, decimal> deductionFor80C = new Dictionary<string, decimal>();

 
    public Deductor80C(TaxableIncome income, Dictionary<string, decimal> deductionList)
    {
        this.taxableIncome = income;
        this.deductionFor80C = deductionList;
    }

    public override decimal GetIncome()
    {
        decimal totalDeduction = deductionFor80C.Values.Sum();
        decimal income = taxableIncome.GetIncome();
        if (income > totalDeduction)
        {
            income = income - totalDeduction;
        }
        return income;
    }

    
    public override void PrintDeductionKind()
    {
        Console.WriteLine("80 C Deduction");
        decimal totalDeduction = deductionFor80C.Values.Sum();
        decimal income = taxableIncome.GetIncome();

        Console.WriteLine($"Income: {income} ");
        Console.WriteLine($"Deduction: {totalDeduction} ");
        Console.WriteLine($"Taxable Income: {GetIncome()}");
        Console.WriteLine();
    }
}