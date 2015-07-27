using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;

namespace ReportSample
{
    public static class ReportGen
    {
        public static HttpResponseMessage Generate()
        {
            SampleDS dataSource = GetSampleData();
            SampleReport report = new SampleReport { DataSource = dataSource };
            MemoryStream memoryStream = new MemoryStream();
            report.ExportToPdf(memoryStream);
            memoryStream.Position = 0;
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            result.Content = new StreamContent(memoryStream);
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            {
                FileName = "report.pdf"
            };
            return result;
        }

        private static SampleDS GetSampleData()
        {
            SampleDS ds = new SampleDS();
            ds.USState.AddUSStateRow("Alabama", "AL");
            ds.USState.AddUSStateRow("Alaska", "AK");
            ds.USState.AddUSStateRow("Arizona", "AZ");
            ds.USState.AddUSStateRow("Arkansas", "AR");
            ds.USState.AddUSStateRow("California", "CA");
            ds.USState.AddUSStateRow("Colorado", "CO");
            ds.USState.AddUSStateRow("Connecticut", "CT");
            ds.USState.AddUSStateRow("Delaware", "DE");
            ds.USState.AddUSStateRow("Florida", "FL");
            ds.USState.AddUSStateRow("Georgia", "GA");
            ds.USState.AddUSStateRow("Hawaii", "HI");
            ds.USState.AddUSStateRow("Idaho", "ID");
            ds.USState.AddUSStateRow("Illinois", "IL");
            ds.USState.AddUSStateRow("Indiana", "IN");
            ds.USState.AddUSStateRow("Iowa", "IA");
            ds.USState.AddUSStateRow("Kansas", "KS");
            ds.USState.AddUSStateRow("Kentucky", "KY");
            ds.USState.AddUSStateRow("Louisiana", "LA");
            ds.USState.AddUSStateRow("Maine", "ME");
            ds.USState.AddUSStateRow("Maryland", "MD");
            ds.USState.AddUSStateRow("Massachusetts", "MA");
            ds.USState.AddUSStateRow("Michigan", "MI");
            ds.USState.AddUSStateRow("Minnesota", "MN");
            ds.USState.AddUSStateRow("Mississippi", "MS");
            ds.USState.AddUSStateRow("Missouri", "MO");
            ds.USState.AddUSStateRow("Montana", "MT");
            ds.USState.AddUSStateRow("Nebraska", "NE");
            ds.USState.AddUSStateRow("Nevada", "NV");
            ds.USState.AddUSStateRow("New Hampshire", "NH");
            ds.USState.AddUSStateRow("New Jersey", "NJ");
            ds.USState.AddUSStateRow("New Mexico", "NM");
            ds.USState.AddUSStateRow("New York", "NY");
            ds.USState.AddUSStateRow("North Carolina", "NC");
            ds.USState.AddUSStateRow("North Dakota", "ND");
            ds.USState.AddUSStateRow("Ohio", "OH");
            ds.USState.AddUSStateRow("Oklahoma", "OK");
            ds.USState.AddUSStateRow("Oregon", "OR");
            ds.USState.AddUSStateRow("Pennsylvania", "PA");
            ds.USState.AddUSStateRow("Rhode Island", "RI");
            ds.USState.AddUSStateRow("South Carolina", "SC");
            ds.USState.AddUSStateRow("South Dakota", "SD");
            ds.USState.AddUSStateRow("Tennessee", "TN");
            ds.USState.AddUSStateRow("Texas", "TX");
            ds.USState.AddUSStateRow("Utah", "UT");
            ds.USState.AddUSStateRow("Vermont", "VT");
            ds.USState.AddUSStateRow("Virginia", "VA");
            ds.USState.AddUSStateRow("Washington", "WA");
            ds.USState.AddUSStateRow("West Virginia", "WV");
            ds.USState.AddUSStateRow("Wisconsin", "WI");
            ds.USState.AddUSStateRow("Wyoming", "WY");
            ds.AcceptChanges();
            return ds;
        }
    }
}
