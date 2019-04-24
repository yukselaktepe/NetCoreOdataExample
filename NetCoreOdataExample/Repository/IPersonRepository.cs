using NetCoreOdataExample.Migrations;
using NetCoreOdataExample.Models;
using System.Collections.Generic;

namespace NetCoreOdataExample.Repository
{
    public interface IPersonRepository : IGenericRepository<Person> 
    {
        List<Person> GetCoolestPerson();

    }
}
