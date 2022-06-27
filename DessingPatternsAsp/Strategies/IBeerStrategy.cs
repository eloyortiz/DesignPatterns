using DesignPatterns.Repository;
using DessingPatternsAsp.Models.ViewModels;

namespace DessingPatternsAsp.Strategies
{
    public interface IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork);
    }
}
