using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
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
        public void Add(Person entity)
        {
            PlutoContext.people.Add(entity);
        }

        public void AddRange(IEnumerable<Person> entities)
        {
            throw new NotImplementedException();
        }

        public Person Find(Expression<Func<Person, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            return Context.Set<Person>().AsNoTracking();
        }

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

        public void Remove(Person entity)
        {
            PlutoContext.people.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Person> entities)
        {
            base.RemoveRange(entities);
        }
    }
}
