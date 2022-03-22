using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso_Booking_API.Data;
using Contoso_Booking_API.Model;

namespace Contoso_Booking_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class BookingController : ControllerBase
    {

        private DataConnection _companyContext;

        public BookingController(DataConnection companyContext)
        {
            _companyContext = companyContext;
        }

        // GET: api/<BookingController>
        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return _companyContext.Bookings;
        }

        // GET api/<BookingController>/
        [HttpGet("{id}")]
        public Booking Get(int id)
        {
            return _companyContext.Bookings.FirstOrDefault(s => s.Booking_Id == id);
        }

        // POST api/<BookingController>
        [HttpPost]
        public void Post([FromBody] Booking value)
        {
            _companyContext.Bookings.Add(value);
            _companyContext.SaveChanges();
        }

        // PUT api/<BookingController>/
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Booking value)
        {
            var BookingDtls = _companyContext.Bookings.FirstOrDefault(s => s.Booking_Id == id);
            if (BookingDtls != null)
            {

                _companyContext.Entry<Booking>(BookingDtls).CurrentValues.SetValues(value);
                _companyContext.SaveChanges();
            }
        }

        // DELETE api/<BookingController>/
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var BookingDtls = _companyContext.Bookings.FirstOrDefault(s => s.Booking_Id == id);
            if (BookingDtls != null)
            {
                _companyContext.Bookings.Remove(BookingDtls);
                _companyContext.SaveChanges();
            }
        }
    }
}
