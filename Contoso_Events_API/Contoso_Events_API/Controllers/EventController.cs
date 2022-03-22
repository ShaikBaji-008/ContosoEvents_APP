using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso_Events_API.Data;
using Contoso_Events_API.Model;

namespace Contoso_Events_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {

        private DataConnection _databaseContext;

        public EventController(DataConnection companyContext)
        {
            _databaseContext = companyContext;
        }

        // GET: api/<EventController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _databaseContext.Events;
        }

        // GET api/<EventController>/
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return _databaseContext.Events.FirstOrDefault(s => s.Event_ID == id);
        }

        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] Event value)
        {
            _databaseContext.Events.Add(value);
            _databaseContext.SaveChanges();
        }

        // PUT api/<EventController>/
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event value)
        {
            var EventDtls = _databaseContext.Events.FirstOrDefault(s => s.Event_ID == id);
            if (EventDtls != null)
            {

                _databaseContext.Entry<Event>(EventDtls).CurrentValues.SetValues(value);
                _databaseContext.SaveChanges();
            }
        }

        // DELETE api/<EventController>/
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var EventDtls = _databaseContext.Events.FirstOrDefault(s => s.Event_ID == id);
            if (EventDtls != null)
            {
                _databaseContext.Events.Remove(EventDtls);
                _databaseContext.SaveChanges();
            }
        }
    }
}


