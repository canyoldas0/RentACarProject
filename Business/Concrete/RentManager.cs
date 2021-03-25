using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class RentManager : IRentService
    {

        IRentDal _rentDal;

        public RentManager(IRentDal rentDal)
        {
            _rentDal = rentDal;

        }




        public IResult Add(Rent rent)
        {
            if (rent.returnDate== null)
            {
                return new ErrorResult(Messages.rentInvalid);
            }

            _rentDal.Add(rent);
            return new SuccessResult(Messages.rentCompleted);
        }

        public IResult Delete(Rent rent)
        {
            _rentDal.Add(rent);
            return new SuccessResult(Messages.rentCompleted);

        }

        public IDataResult<List<Rent>> GetAll()
        {
            return new SuccessDataResult<List<Rent>>(_rentDal.GetAll());
        }

        public IDataResult<Rent> GetById(int rentId)
        {
            return new SuccessDataResult<Rent>(_rentDal.Get(r => r.id == rentId));

        }

        public IDataResult<List<RentDetailDto>> GetRentByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<RentDetailDto>>(_rentDal.GetRentDetails(r=>r.customerId==customerId));
        }

        public IDataResult<List<RentDetailDto>> GetRentDetails(Expression<Func<RentDetailDto, bool>> filter = null)
        {
            return new SuccessDataResult<List<RentDetailDto>>(_rentDal.GetRentDetails(filter));
        }

        public IDataResult<List<RentDetailDto>> GetRentsByCarId(int carId)
        {
            return new SuccessDataResult<List<RentDetailDto>>(_rentDal.GetRentDetails(r => r.carId == carId));
        }

        public IResult Update(Rent rent)
        {
            _rentDal.Update(rent);
            return new SuccessResult(Messages.rentUpdated);

        }
    }
}
