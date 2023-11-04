public class HouseRentIncome: TaxableIncome
{
    decimal houseRentIncome = 0;
    public HouseRentIncome(decimal income)
    {
        this.houseRentIncome = income;
    }

    public override decimal GetIncome()
    {
        return houseRentIncome;
    }
}