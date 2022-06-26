//using DesignPatterns.DependencyInjectionPattern;
//using DesignPatterns.FactoryPattern;
using DesignPatterns.Models;
using DesignPatterns.RepositoryPattern;
using DesignPatterns.UnitOfWorkPattern;

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
            ///FACTORY METHOD
            //SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            //SaleFactory internetSaleFactory = new InternetSaleFactory(2);

            //ISale sale1 = storeSaleFactory.GetSale();
            //sale1.Sell(15);

            //ISale sale2 = internetSaleFactory.GetSale();
            //sale2.Sell(15);

            ///************************************
            ///DEPENDENCY INJECTION
            //var beer = new Beer("Pikantus", "Erlinger");
            //var drinkWithBeer = new DrinkWithBeer(10, 1, beer);
            //drinkWithBeer.Build();

            ///************************************
            ///REPOSITORY
            //using (var dbContext = new DesignPatternsContext())
            //{
            //    var beerRepo = new BeerRepository(dbContext);

            //    var beer = new Beer();
            //    beer.Name = "Corona";
            //    beer.Style = "Pilsner";

            //    beerRepo.Add(beer);
            //    beerRepo.Save();

            //    foreach(var b in beerRepo.GetAll())
            //    {
            //        Console.WriteLine(b.Name);
            //    }
            //}

            ///-----------------------------------
            ///REPOSITORY GENERICS
            //using (var dbContext = new DesignPatternsContext())
            //{
            //    var beerRepository = new Repository<Beer>(dbContext);

            //    var beer = new Beer() { Name = "Fuller", Style = "Strong Ale" };
            //    beerRepository.Add(beer);
            //    beerRepository.Save();

            //    Console.WriteLine($"BEERS");
            //    foreach (var b in beerRepository.GetAll())
            //    {
            //        Console.WriteLine($"#{b.BeerId} -> {b.Name}");
            //    }

            //    var brandRepository = new Repository<Brand>(dbContext);

            //    var brand = new Brand() { Name = "Erdinger" };
            //    brandRepository.Add(brand);
            //    brandRepository.Save();

            //    Console.WriteLine($"BRANDS");
            //    foreach (var b in brandRepository.GetAll())
            //    {
            //        Console.WriteLine($"#{b.BrandId} -> {b.Name}");
            //    }
            //}

            ///************************************
            ///UNIT OF WORK
            
            using( var context = new DesignPatternsContext())
            {
                var unitOfWork = new UnitOfWork(context);

                var beers = unitOfWork.Beers;
                var beer = new Beer() { Name = "Mahou", Style = "Porter" };
                beers.Add(beer);

                var brands = unitOfWork.Brands;
                var brand = new Brand() { Name = "Mahou" };
                brands.Add(brand);

                unitOfWork.Save();
            }

        }
    }
}