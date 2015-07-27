using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Security;
using ReportSample;

namespace MobileServiceTest.Controllers
{
    [AuthorizeLevel(AuthorizationLevel.Anonymous)]
    public class TestCustomMobileController : ApiController
    {
        public ApiServices Services { get; set; }

        // GET api/TestCustomMobile
        public HttpResponseMessage Get()
        {
            return ReportGen.Generate();
        }

    }
}
