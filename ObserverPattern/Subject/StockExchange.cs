namespace ObserverPattern
{
    public class StockExchange:IStockSubject
    {

        private List<IObserver> Observers {get;}

        private Dictionary<string, decimal> stockPrice  = new Dictionary<string, decimal>();
        public StockExchange()
        {
            Observers = new  List<IObserver>();
            stockPrice.Add("ABC", 5);
            stockPrice.Add("XYZ", 5);
        }


        public void BuyStock(string ticker, decimal newPrice)
        {
            stockPrice[ticker] = newPrice;
            Console.WriteLine($"The buy order completed for the ticker {ticker}" );
            StockPriceChanged(ticker, newPrice);
        }

        public void SellStock(string ticker, decimal newPrice)
        {
            stockPrice[ticker] = newPrice;
            Console.WriteLine($"The sell order completed for the ticker {ticker}" );
            StockPriceChanged(ticker, newPrice);
        }


        public void Subscribe(IObserver observer)
        {
            if (!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
        }

        public void UnSubscribe(IObserver observer)
        {
            if (Observers.Contains(observer))
            {
                Observers.Remove(observer);
            }
        }

        public decimal GetStockPrice(string ticker)
        {
            return stockPrice[ticker];
        }

        private void StockPriceChanged(string  ticker, decimal price)
        {
            foreach(IObserver observer in Observers)
            {
                observer.UpdateStockPrice(ticker,price);
            }
        }
    }
}