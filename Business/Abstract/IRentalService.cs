using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentService
    {

        IDataResult<List<Rent>> GetAll();
        IDataResult<Rent> GetById(int rentId);
        IResult Add(Rent rent);
        IResult Update(Rent rent);
        IResult Delete(Rent rent);

        IDataResult<List<RentDetailDto>> GetRentsByCarId(int carId);
        IDataResult<List<RentDetailDto>> GetRentByCustomerId(int customerId);

        IDataResult<List<RentDetailDto>> GetRentDetails(Expression<Func<RentDetailDto, bool>> filter = null);

    }
}
