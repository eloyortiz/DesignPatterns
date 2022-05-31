using DesignPatterns.FactoryPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ////SINGLETON
            //var log = Singleton.Log.Instance;

            //log.Save("a");
            //log.Save("b");

            //var a = Singleton.Singleton.Instance;
            //var b = Singleton.Singleton.Instance;

            //Console.WriteLine(a == b);

            ///************************************

            //FACTORY METHOD
            SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            SaleFactory internetSaleFactory = new InternetSaleFactory(2);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);

            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);
        }
    }
}