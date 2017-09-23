using Cibertec.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cibertec.Repositories.Credit
{
    public interface ICorporationRepository : IRepository<Corporation>
    {
        //Corporation SearchByNames(string firstName, string lastName);
    }
}
