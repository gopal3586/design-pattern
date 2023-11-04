namespace   ObserverPattern
{
    public class StockTracker: IObserver
    {
        private IStockSubject StockExchange {get;}
        private string Tracker {get;}
        public StockTracker(IStockSubject stockExchange, string instanceName)
        {
            StockExchange = stockExchange;
            StockExchange.Subscribe(this);
            Tracker = instanceName;
            Console.WriteLine($"{Tracker} has subscribed to stock exchange");
        }

        public void UpdateStockPrice(string ticker, decimal price)
        {
            Console.WriteLine($"{Tracker}: new price for the ticker {ticker} is {price}");
        }

        public void Dispose()
        {
            StockExchange.UnSubscribe(this);
            Console.WriteLine($"{Tracker} has unsubscribed from stock exchange");
        }
    }
}