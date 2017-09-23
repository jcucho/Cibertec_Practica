using Cibertec.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cibertec.Repositories.Credit
{
    public interface IMemberRepository : IRepository<Member>
    {
        //Member SearchByNames(string firstName, string lastName);
    }
}
