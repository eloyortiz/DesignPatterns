//using DesignPatterns.DependencyInjection;
//using DesignPatterns.FactoryPattern;
using DesignPatterns.Models;
using DesignPatterns.RepositoryPattern;

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

            ////FACTORY METHOD
            //SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            //SaleFactory internetSaleFactory = new InternetSaleFactory(2);

            //ISale sale1 = storeSaleFactory.GetSale();
            //sale1.Sell(15);

            //ISale sale2 = internetSaleFactory.GetSale();
            //sale2.Sell(15);

            ///************************************

            //DEPENDENCY INJECTION
            //var beer = new Beer("Pikantus", "Erlinger");
            //var drinkWithBeer = new DrinkWithBeer(10, 1, beer);
            //drinkWithBeer.Build();

            ///************************************

            //REPOSITORY
            using (var dbContext = new DesignPatternsContext())
            {
                var beerRepo = new BeerRepository(dbContext);
                
                var beer = new Beer();
                beer.Name = "Corona";
                beer.Style = "Pilsner";
                
                beerRepo.Add(beer);
                beerRepo.Save();
                
                foreach(var b in beerRepo.GetAll())
                {
                    Console.WriteLine(b.Name);
                }
            }
        }
    }
}