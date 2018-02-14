using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DomainObjects;
using GitMetricsapp.Library;

namespace GitMetricsApp.Controllers
{
    public class CommitsController : ApiController
    {
        private Commits commits;
        public CommitsController()
        {
            commits = new Commits();
        }
        // GET api/values
        [Route("api/commits/")]
        [HttpGet]
        public List<CommitDetails> Get()
        {
            var commitDetails = commits.GetCommitDetails();
            return commitDetails;
        }

        // GET api/values/5
        [Route("api/commits/{userId}")]
        [HttpGet]
        public IEnumerable<CommitDetails> Get(string userId)
        {
            var userSpecificCommitDetails = commits.GetUserSpecificCommitDetails(userId.ToString());
            return userSpecificCommitDetails;
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
        }
    }
}
