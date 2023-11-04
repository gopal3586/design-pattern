using ObserverPattern;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to stock exchange");
int j= args.Length;
Console.WriteLine (j);
StockExchange stockExchange = new  StockExchange();
IObserver yahooFinance = new StockTracker(stockExchange,"Yahoo finance");
IObserver zerodha = new StockTracker(stockExchange, "Zerodha");

int i = 1;
while (i<4)
{
    stockExchange.BuyStock("ABC", 5 + i);
    Console.WriteLine();
    stockExchange.SellStock("XYZ", 5-i);
    Console.WriteLine();
    System.Threading.Thread.Sleep(500);   
    i = i +1;
    if (i==3)
    {
        zerodha.Dispose();
        Console.WriteLine();
    }
    
}


//The above statements are called top-level statement and it will be wrapped 
//inside the main method automatically by the compiler
