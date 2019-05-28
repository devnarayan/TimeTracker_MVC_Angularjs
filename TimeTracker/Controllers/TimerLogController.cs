using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TimeTracker.Models;
using TimeTracker.Models.Dtos;

namespace TimeTracker.Controllers
{
    public class TimerLogController : ApiController
    {
        private readonly TimeTrackerDBEntities db = new TimeTrackerDBEntities();

        // GET: api/JoggingRecords/5
        [ResponseType(typeof(TimeLogDto))]
        public IHttpActionResult GetTimerLogs(int userId)
        {
            var timerRecords =  db.TimeLogs.Where(st=>st.UserId == userId).ToList();
            if (timerRecords == null)
            {
                return NotFound();
            }

            return Ok(timerRecords);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}