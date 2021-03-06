﻿using System.Web.Http;
using System.Web.Routing;

namespace MobileServiceTest
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register();

            DevExpress.XtraPrinting.Export.Pdf.PdfGraphics.EnableAzureCompatibility = true;
        }
    }
}