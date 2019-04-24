using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NetCoreOdataExample.Models;
using NetCoreOdataExample.Repository;

namespace NetCoreOdataExample.Controllers
{
    [EnableCors()]
    public class PersonsController : ODataController
    {
        private readonly IPersonRepository _repository;

        public PersonsController(IPersonRepository repository)
        {
            _repository = repository;
        }

        [EnableQuery]
        public IActionResult Get()
        {
            var result = _repository.GetCoolestPerson();
            return Ok(result);
        }


        [EnableQuery]
        public IActionResult Get(int key)
        {
            var result = _repository.GetById(key);
            return Ok(result);
        }

        public IActionResult Post([FromBody]Person person)
        {
            _repository.Create(person);
            return Created(person);
        }

        //Put
        //Patch
        //Delete
        //.
        //.
        //.
    }

}