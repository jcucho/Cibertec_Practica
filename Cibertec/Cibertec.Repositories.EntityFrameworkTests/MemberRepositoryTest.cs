using Cibertec.Models;
using Cibertec.Repositories.EntityFramework.Credit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;

namespace Cibertec.Repositories.EntityFrameworkTests
{
    public class MemberRepositoryTest
    {
        private readonly DbContext _context;
        private readonly CreditUnitOfWork unit;

        public MemberRepositoryTest()
        {
            _context = new CreditDbContext();
            unit = new CreditUnitOfWork(_context);
        }

        [Fact(DisplayName = "[MemberRepository]Get All")]
        public void Member_Repository_GetAll()
        {
            var result = unit.Members.GetList();
            Assert.True(result.Count() > 0);
        }

        [Fact(DisplayName = "[MemberRepository]Insert")]
        public void Member_Repository_Insert()
        {
            var member = GetNewMember();
            var result = unit.Members.Insert(member);
            Assert.True(result > 0);
        }
        [Fact(DisplayName = "[MemberRepository]Delete")]
        public void Member_Repository_Delete()
        {
            var member = GetNewMember();
            var result = unit.Members.Insert(member);
            Assert.True(unit.Members.Delete(member));
        }

        private Member GetNewMember()
        {
            return new Member
            {
                lastname="cucho",
                firstname = "juan",
                middleinitial = "jc",
                street = "av",
                city = "li",
                state_prov = "li",
                country = "pe",
                mail_code = "aa@go.com",
                phone_no = "55555",
                issue_dt = DateTime.Now,
                expr_dt = DateTime.Now,
                corp_no = 1,
                prev_balance = 0,
                curr_balance = 0,
                Code = "A"
            };
        }

        [Fact(DisplayName = "[MemberRepository]Update")]
        public void Member_Repository_Update()
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
