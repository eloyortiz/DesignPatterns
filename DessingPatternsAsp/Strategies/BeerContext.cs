using DesignPatterns.Repository;
using DessingPatternsAsp.Models.ViewModels;

namespace DessingPatternsAsp.Strategies
{
    public class BeerContext : IBeerStrategy
    {
        private IBeerStrategy _strategy;
        public IBeerStrategy Strategy {
            set { _strategy = value; }
        }

        public BeerContext(IBeerStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            _strategy.Add(beerVM, unitOfWork);
        }
    }
}
