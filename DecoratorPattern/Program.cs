// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tax calculator");

TaxableIncome income = new GrossSalary(1200000);

Dictionary<string, decimal> exemption_80C = new Dictionary<string, decimal>();
exemption_80C.Add("PF", 50000);
exemption_80C.Add("LIC", 50000);

TaxDeductor post80C_Deduction =  new Deductor80C(income, exemption_80C);
post80C_Deduction.PrintDeductionKind();

TaxDeductor postHRA_Deduction = new HRADeductor(post80C_Deduction, 60000);
postHRA_Deduction.PrintDeductionKind();

TaxCalculator calculator = new TaxCalculator(postHRA_Deduction.GetIncome());
calculator.GetTaxPayable();
Console.ReadLine();


