using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IPersonRepository:IRepository<Person> 
    {
        Person GetPersonByName(string name);
        IEnumerable<Person> GetPeopleByAddress(string address);
        IEnumerable<Person> GetPeopleByPhoneNumber(string phone);
    }
}
