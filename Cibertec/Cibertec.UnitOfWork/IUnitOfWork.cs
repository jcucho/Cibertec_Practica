using Cibertec.Repositories.Credit;

namespace Cibertec.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICorporationRepository Corporations { get; }
        IMemberRepository Members { get; }   
    }
}
