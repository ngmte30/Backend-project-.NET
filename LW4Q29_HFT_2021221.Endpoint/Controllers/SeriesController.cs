using LW4Q29_HFT_2021221.Logic;
using LW4Q29_HFT_2021221.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LW4Q29_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        ISeriesLogic sLogic;
        public SeriesController(ISeriesLogic sLogic)
        {
            this.sLogic = sLogic;
        }
        // GET:series
        [HttpGet]
        public IEnumerable<Series> Get()
        {
            return sLogic.GetAll();
        }

        // GET api/<SeriesController>/5
        [HttpGet("{id}")]
        public Series Get(int id)
        {
            return sLogic.Read(id);
        }

        // POST api/<SeriesController>
        [HttpPost]
        public void Post([FromBody] Series value)
        {
            sLogic.Create(value);
        }

        // PUT api/<SeriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Series value)
        {
            sLogic.Update(value); 
        }

        // DELETE api/<SeriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            sLogic.Delete(id);
        }
    }
}
