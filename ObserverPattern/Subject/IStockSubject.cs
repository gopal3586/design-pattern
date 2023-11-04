namespace ObserverPattern
{
    public interface IStockSubject: ISubject
    {
        decimal GetStockPrice(string ticker);
    }


}