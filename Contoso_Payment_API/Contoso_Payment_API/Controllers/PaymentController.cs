using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso_Payment_API.Data;
using Contoso_Payment_API.Model;



namespace Contoso_Payment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class PaymentController : ControllerBase
    {

        private DataConnection _companyContext;

        public PaymentController(DataConnection companyContext)
        {
            _companyContext = companyContext;
        }

        // GET: api/<PaymentController>
        [HttpGet]
        public IEnumerable<Payment> Get()
        {
            return _companyContext.Payments;
        }

        // GET api/<PaymentController>/
        [HttpGet("{id}")]
        public Payment Get(int id)
        {
            return _companyContext.Payments.FirstOrDefault(s => s.Payment_Id == id);
        }

        // POST api/<PaymentController>
        [HttpPost]
        public void Post([FromBody] Payment value)
        {
            _companyContext.Payments.Add(value);
            _companyContext.SaveChanges();
        }

        // PUT api/<PaymentController>/
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Payment value)
        {
            var BookingDtls = _companyContext.Payments.FirstOrDefault(s => s.Payment_Id == id);
            if (BookingDtls != null)
            {

                _companyContext.Entry<Payment>(BookingDtls).CurrentValues.SetValues(value);
                _companyContext.SaveChanges();
            }
        }

        // DELETE api/<PaymentController>/
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var BookingDtls = _companyContext.Payments.FirstOrDefault(s => s.Payment_Id == id);
            if (BookingDtls != null)
            {
                _companyContext.Payments.Remove(BookingDtls);
                _companyContext.SaveChanges();
            }
        }
    }
}
