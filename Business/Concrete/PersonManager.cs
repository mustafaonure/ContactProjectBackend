using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
//using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;
        

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;

        }

        //[SecuredOperation("admin")]
        [ValidationAspect(typeof(PersonValidator))]
        //[CacheRemoveAspect("IPersonService.Get")]
        public IResult Add(Person person)
        {


            _personDal.Add(person);
            return new SuccessResult(Messages.PersonAdded);


        }

        //[CacheAspect]
        public IDataResult<List<Person>> GetAll()
        {
            //İş kodları
            return new SuccessDataResult<List<Person>>(_personDal.GetAll(p=>p.BlockedNumber==false || p.BlockedNumber==null), Messages.PersonListed);
        }
        public IDataResult<List<Person>> Favorites()
        {
            //İş kodları
            return new SuccessDataResult<List<Person>>(_personDal.GetAll(p=>p.Favorites==true), Messages.Favorites);
        }
        public IDataResult<List<Person>> BlockedNumber()
        {
            //İş kodları
            return new SuccessDataResult<List<Person>>(_personDal.GetAll(p => p.BlockedNumber == true), Messages.Blocked);
        }


        public IDataResult<Person> GetById(int id)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.Id == id));
        }

        [CacheAspect]
        public IDataResult<Person> GetByMail(string mail)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.Mail == mail));
        }

        public IDataResult<Person> GetByName(string name)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.Name == name));
        }

        public IDataResult<Person> GetByPhoneNumber(string phoneNumber)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.PhoneNumber == phoneNumber));
        }

        public IDataResult<Person> GetBySurname(string surname)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.Surname == surname));
        }

        [ValidationAspect(typeof(PersonValidator))]
        [CacheRemoveAspect("IPersonService.Get")]
        public IResult Update(Person person)
        {
            _personDal.Update(person);
            return new SuccessResult(Messages.PersonUpdated);
        }


        [ValidationAspect(typeof(PersonValidator))]
        [CacheRemoveAspect("IPersonService.Get")]
        public IResult DeleteById(Person person)
        {
            _personDal.Delete(person);
            return new SuccessResult(Messages.PersonDeleted);
        }
        //[TransactionScopeAspect]
        //public IResult AddTransactionalTest(Person person)
        //{
        //    throw new NotImplementedException();
        //}
    }

}
