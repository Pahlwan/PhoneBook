using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PersonRepository : Repository<Person>,IPersonRepository
    {
        public PersonRepository(PlutoContext context):base(context)
        {

        }


        public PlutoContext PlutoContext { get { return Context as PlutoContext; } }
        
        public IEnumerable<Person> GetPeopleByAddress(string address)
        {
            return PlutoContext.people.Where(item => item.address == address).ToList();
        }

        public IEnumerable<Person> GetPeopleByPhoneNumber(string phone)
        {
            return PlutoContext.people.Where(item => item.phoneNumber == phone).ToList();
        }

        public Person GetPersonByName(string name)
        {
            return PlutoContext.people.Where(item => item.name == name).FirstOrDefault();
        }

    }
}
