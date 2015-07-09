using System;
using System.Linq;
using System.Runtime.InteropServices;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyRestUnitTests.RestServiceReference;

namespace MyRestUnitTests
{
    [TestClass]
    public class AdvertisementTest  
    {
        JsonResponse response = null;
        RestServiceClient client = new RestServiceClient();

        [TestMethod]
        public void AddAdvertisement()
        {
            response = client.ViewAllClients();
            Assert.IsNotNull(response.ClientCollection);
            Assert.IsTrue(response.ClientCollection.ToList().Count > 0);
            var theClient = response.ClientCollection.FirstOrDefault();

            response = client.ViewAllCatagories();
            Assert.IsNotNull(response.CatagoryCollection);
            Assert.IsTrue(response.CatagoryCollection.ToList().Count > 0);
            var catagory = response.CatagoryCollection.FirstOrDefault();
            
            var advertisement = new Advertisement
            {
                Id = 5,
                Title = "Big Sale on Electronics!",
                Description = "There is a big sale on Electronics just around the corner!",
                ExpiryDate = DateTime.Now.AddDays(30),
                CategoryId = catagory.Id,
                ClientId = theClient.Id,
                CreatedDate = DateTime.Now
            };
            response = client.AddAdvertisement(advertisement);

            Assert.IsTrue(response.IsSuccessFull);
        }

        [TestMethod]
        public void ViewAllAdvertisements()
        {
            response = client.ViewAllAdvertisements();

            Assert.IsTrue(response.IsSuccessFull);
            Assert.IsNotNull(response.AdvertisementCollection);
            Assert.IsTrue(response.AdvertisementCollection.ToList().Count > 0);
        }
    }
}
