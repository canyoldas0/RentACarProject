using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal :EfEntityRepositoryBase<User, DummyContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {

            using (var context = new DummyContext())
            {
                var result = from OperationClaim in context.OperationClaims
                    join UserOperationClaim in context.UserOperationClaims
                        on OperationClaim.Id equals UserOperationClaim.operationClaimId
                    where UserOperationClaim.userId == user.userId
                    select new OperationClaim
                    {
                        Id = OperationClaim.Id,
                        Name = OperationClaim.Name
                    };

                return result.ToList();
            }



            
        }
    }
}
