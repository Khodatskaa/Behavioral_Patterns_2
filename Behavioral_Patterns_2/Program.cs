namespace Behavioral_Patterns_2
{
    public class Program
    {
        static void Main()
        {
            StockMarket stockMarket = new StockMarket();

            Investor investor1 = new Investor("Alex");
            Investor investor2 = new Investor("Elizabeth");

            stockMarket.Attach(investor1);
            stockMarket.Attach(investor2);

            stockMarket.StockPrice = 500;
            stockMarket.StockPrice = 550;

            stockMarket.Detach(investor2);

            stockMarket.StockPrice = 660;
        }
    }
}
