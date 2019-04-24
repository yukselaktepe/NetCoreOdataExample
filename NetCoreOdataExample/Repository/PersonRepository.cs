using NetCoreOdataExample.Migrations;
using NetCoreOdataExample.Models;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreOdataExample.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {

        public PersonRepository(DataContext dbContext)
            : base(dbContext)
        {
        }
        public List<Person> GetCoolestPerson()
        {
            return GetAll()
                .OrderByDescending(c => c.Name)
                .ToList();
        }

    }
}
