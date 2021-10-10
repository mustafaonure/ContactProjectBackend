using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonService
    {
        IDataResult<List<Person>> GetAll();
        IDataResult<List<Person>> Favorites();
        IDataResult<List<Person>> BlockedNumber();


        IDataResult<Person> GetById(int id);

        IDataResult<Person> GetByName(string name);
        IDataResult<Person> GetBySurname(string surname);
        IDataResult<Person> GetByPhoneNumber(string phoneNumber);
        IDataResult<Person> GetByMail(string mail);
        


        IResult Add(Person person);

        IResult Update(Person person);

        IResult DeleteById(Person person);
        //IResult AddTransactionalTest(Person person);





    }
}
