using Cibertec.Models;
using Cibertec.Repositories.Credit;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Cibertec.Repositories.EntityFramework.Credit
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        public MemberRepository(DbContext context) : base(context)
        {
        }
    }
}
