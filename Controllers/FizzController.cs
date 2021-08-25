using FizzBuzz.BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FizzBuzz.Controllers
{
    [Route("api/fizzbuzz")]
    [ApiController]
    public class FizzController : ControllerBase
    {
        private readonly IFizz _fizzService;

        public FizzController(IFizz fizz)
        {
            _fizzService = fizz;
        }

        // GET: api/<FizzController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FizzController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FizzController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FizzController>/5
        [HttpPut("{n}")]
        public List<string> Put(int n)
        {
            //Fizz fizz = new Fizz();
            //return fizz.FizzBuzz(n);
            return _fizzService.FizzBuzz(n);
        }

        // DELETE api/<FizzController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
