public class HRADeductor : TaxDeductor
{
    TaxableIncome taxableIncome ;
    decimal hraDeduction = 0;

    public HRADeductor(TaxableIncome income, decimal hra)
    {
        taxableIncome = income;
        hraDeduction = hra;
    }
    public override decimal GetIncome()
    {
        decimal income = taxableIncome.GetIncome();
        if (income > hraDeduction)
        {
            income = income - hraDeduction;
        }
        return income;
    }

    public override void PrintDeductionKind()
    {
        Console.WriteLine("HRA Dedcution:");
        Console.WriteLine($"Income: {taxableIncome.GetIncome()}");
        Console.WriteLine($"HRA Deduction: {hraDeduction}");
        Console.WriteLine($"Taxable Income: {GetIncome()}");
        Console.WriteLine();
    }
}