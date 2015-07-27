using System.Net.Http;
using System.Web.Http;
using ReportSample;

namespace WebAppTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            return ReportGen.Generate();
        }
    }
}
