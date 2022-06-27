using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DessingPatternsAsp.Models.ViewModels;

namespace DessingPatternsAsp.Strategies
{
    public class BeerWithNewBrandStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            var brand = new Brand();
            brand.Name = beerVM.OtherBrand;
            brand.BrandId = Guid.NewGuid();

            var beer = new Beer();
            beer.Name = beerVM.Name;
            beer.Style = beerVM.Style;
            beer.BrandId = brand.BrandId;

            unitOfWork.Brands.Add(brand);
            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}
