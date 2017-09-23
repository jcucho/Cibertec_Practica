using Cibertec.Models;
using Cibertec.Repositories.EntityFramework.Credit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;

namespace Cibertec.Repositories.EntityFrameworkTests
{
    public class CorporationRepositoryTest
    {
        private readonly DbContext _context;
        private readonly CreditUnitOfWork unit;

        public CorporationRepositoryTest()
        {
            _context = new CreditDbContext();
            unit = new CreditUnitOfWork(_context);
        }

        [Fact(DisplayName = "[CorporationRepository]Get All")]
        public void Corporation_Repository_GetAll()
        {
            var result = unit.Corporations.GetList();
            Assert.True(result.Count() > 0);
        }

        [Fact(DisplayName = "[CorporationRepository]Insert")]
        public void Corporation_Repository_Insert()
        {
            var corporation = GetNewCorporation();
            var result = unit.Corporations.Insert(corporation);
            Assert.True(result > 0);
        }
        [Fact(DisplayName = "[CorporationRepository]Delete")]
        public void Customer_Repository_Delete()
        {
            var customer = GetNewCorporation();
            var result = unit.Corporations.Insert(customer);
            Assert.True(unit.Corporations.Delete(customer));
        }

        private Corporation GetNewCorporation()
        {
            return new Corporation
            {
                corp_name = "NM",
                street = "Celedon 555",
                city = "Lima",
                state_prov = "LI",
                country = "PE",
                mail_code = "nm@aa.com",
                phone_no = "5555555",
                expr_dt = DateTime.Now,
                corp_code = "01"
            };
        }

        [Fact(DisplayName = "[CorporationRepository]Update")]
        public void Corporation_Repository_Update()
        {
            var corporation = unit.Corporations.GetById(10);
            Assert.True(corporation != null);
            corporation.corp_name = "AA";
            Assert.True(unit.Corporations.Update(corporation));
        }

        //[Fact(DisplayName = "[CustomerRepository]Get By Id")]
        //public void Customer_Repository_Get_By_Id()
        //{
        //    var customer = unit.Corporations.GetById(10);
        //    Assert.True(customer != null);
        //}
    }
}
