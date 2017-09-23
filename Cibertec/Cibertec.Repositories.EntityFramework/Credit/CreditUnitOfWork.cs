using Cibertec.Repositories.Credit;
using Cibertec.UnitOfWork;
using Microsoft.EntityFrameworkCore;


namespace Cibertec.Repositories.EntityFramework.Credit
{
    public class CreditUnitOfWork: IUnitOfWork
    {
        public CreditUnitOfWork(DbContext context)
        {
            Corporations = new CorporationRepository(context);
            Members = new MemberRepository(context);
        }

        public ICorporationRepository Corporations { get; private set; }

        public IMemberRepository Members { get; private set; }
    }
}
