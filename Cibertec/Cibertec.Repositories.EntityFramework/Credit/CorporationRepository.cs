using Cibertec.Models;
using Cibertec.Repositories.Credit;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Cibertec.Repositories.EntityFramework.Credit
{
    public class CorporationRepository : Repository<Corporation>, ICorporationRepository
    {
        public CorporationRepository(DbContext context) : base(context)
        {
        }
    }
}
