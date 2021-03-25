using Core;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentDal: IEntityRepository<Rent>
    {

        List<RentDetailDto> GetRentDetails(Expression<Func<RentDetailDto, bool>> filter = null);
    }
}
