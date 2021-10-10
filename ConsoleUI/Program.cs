using Business.CCS;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //SOLİD
    
    class Program
    {
        static void Main(string[] args)
        {
            PersonTest();
            PersonManager personManager = new PersonManager(new EfPersonDal());

            Console.ReadLine();
        }

        private static void PersonTest()
        {
            PersonManager personManager = new PersonManager(new EfPersonDal());
            var result = personManager.GetAll();

            if (result.Success == true)
            {
                foreach (var person in result.Data)

                {
                    Console.WriteLine(person.Id + " " + person.Name + " " + person.Surname + " " + person.PhoneNumber);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
    
}
