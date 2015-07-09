using System;
using System.Linq;
using System.Runtime.InteropServices;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyRestUnitTests.RestServiceReference;

namespace MyRestUnitTests
{
    [TestClass]
    public class ClientTest  
    {
        JsonResponse response = null;
        RestServiceClient client = new RestServiceClient();

        [TestMethod]
        public void AddClient()
        {
            response = client.ViewAllClients();

            var newClient = new Client
            {
                Name = "Popkawitz GWM",
                Address = "Cnr of the one road and the other road",
                ContactPerson = "Niel",
                ContactPhone = "081654879",
                ContactEmail = "niel@gwm.co.na",
                CreatedDate = DateTime.Now
            };
            response = client.AddClient(newClient);

            Assert.IsTrue(response.IsSuccessFull);
        }

        [TestMethod]
        public void ViewAllClients()
        {
            response = client.ViewAllClients();

            Assert.IsTrue(response.IsSuccessFull);
            Assert.IsNotNull(response.ClientCollection);
            Assert.IsTrue(response.ClientCollection.ToList().Count > 0);
        }
    }
}
