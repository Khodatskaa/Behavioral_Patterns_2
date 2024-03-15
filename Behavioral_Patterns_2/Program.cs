namespace Behavioral_Patterns_2
{
    public class Program
    {
        static void Main()
        {
            var stockMarket = new StockMarket();

            var appleStock = new Stock("AAPL", 150.00);
            var teslaStock = new Stock("TSLA", 700.00);

            stockMarket.AddStock(appleStock);
            stockMarket.AddStock(teslaStock);

            var investor1 = new Investor("John", "AAPL");
            var investor2 = new Investor("Alice", "TSLA");

            stockMarket.Attach(investor1);
            stockMarket.Attach(investor2);

            stockMarket.UpdateStockPrice("AAPL", 155.00); 
            stockMarket.UpdateStockPrice("TSLA", 710.00);
        }
    }
}
