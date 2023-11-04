public class TaxCalculator
{
    decimal income = 0;
    const decimal TEN_LAKH = 1000000;
    const decimal FIVE_LAKH = 500000;
    const decimal TWOANDHALF_LAKH = 250000; 
    public TaxCalculator(decimal taxableIncome)
    {
        this .income = taxableIncome;
    }

    public void GetTaxPayable()
    {
        decimal taxPayable = 0;
        decimal tempIncome = income;
        Console.WriteLine($"Taxable income {tempIncome}");

        if (tempIncome >TEN_LAKH )
        {
            taxPayable = (tempIncome - TEN_LAKH) * (30M/100M);
            tempIncome = TEN_LAKH;
            Console.WriteLine($"Tax out of 30% slab {taxPayable}");
        }
        if (tempIncome > FIVE_LAKH)
        {            
            taxPayable += (tempIncome - FIVE_LAKH) * (20M/100M);
            Console.WriteLine($"Tax out of 20% slab {(tempIncome - FIVE_LAKH) * (20M/100M)}");
            tempIncome = FIVE_LAKH;
            
        }
        if (tempIncome > TWOANDHALF_LAKH)
        {
            taxPayable += (tempIncome - TWOANDHALF_LAKH) * (5M/100M);
            Console.WriteLine($"Tax out of 5% slab {(tempIncome - TWOANDHALF_LAKH) * (5M/100)}");
            tempIncome = FIVE_LAKH;   
            
        }

        Console.WriteLine($"Tax payable: {taxPayable}");
    }
}