namespace ObserverPattern
{
    public interface IObserver: IDisposable
    {
        void UpdateStockPrice(string ticker, decimal price);
    }
}