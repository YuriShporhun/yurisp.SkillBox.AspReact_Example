using NUnit.Framework;
using RestSharp;
using System.Diagnostics;
using System.Net;

namespace API.Test
{
    public class TicketsCrudTests
    {
        private IRestClient restClient;
        private IRestRequest restRequest;
        readonly string endpointUrl = "http://localhost:5000/api";

        [SetUp]
        public void Setup()
        {
            restClient = new RestClient();
        }

        [Test]
        public void Tickets_Get_ReturnsStatusCode200()
        {
            restRequest = new RestRequest(endpointUrl + "/tickets");
            IRestResponse restResponse = restClient.Get(restRequest);

            Debug.WriteLine(restResponse.StatusCode);
            Assert.AreEqual(restResponse.StatusCode, HttpStatusCode.OK);
        }
    }
}