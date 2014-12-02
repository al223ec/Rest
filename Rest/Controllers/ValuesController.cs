using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.Models;
using WebService.Models.Repository;

namespace Rest.Controllers
{
    public class ValuesController : ApiController
    {
        private ReservationRepository repo = new ReservationRepository();

        public Reservation CreateReservation(Reservation reservation)
        {
            return repo.Add(reservation);
        }
         // GET api/values
        public IEnumerable<Reservation> Get()
        {
            return repo.GetAll();
        }

        // GET api/values/5
        public Reservation Get(int id)
        {
            return repo.Get(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            repo.Remove(id);
        }
    }
}
