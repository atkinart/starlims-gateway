using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Web.Http;

//using System.Web.Http;


namespace StarLims.Gateway.Controllers
{
    
//    [RoutePrefix("people")]
//    [Route("api/v{version:apiVersion}/{controller}/{id}")]
    public class TestController : ApiController
    {
        /// <summary>
        /// Echo method for test
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ApiVersion("1.0")]
        [HttpGet]
        public HttpResponseMessage echo(string id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, id);
        }
        
        // V2 Descrp
        /// <summary>
        /// ECHO V2 METHOD
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <returns>echo v2</returns>
        [ApiVersion("2.0")]
        [Route("api/v{version:apiVersion}/test/{id}")]
        [HttpGet]
        public HttpResponseMessage echov2(string id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, id + id);
        }
    }
    
    
}
