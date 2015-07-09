using System;
using System.Linq;
using System.Runtime.InteropServices;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyRestUnitTests.RestServiceReference;

namespace MyRestUnitTests
{
    [TestClass]
    public class CatagoryTest  
    {
        JsonResponse response = null;
        RestServiceClient client = new RestServiceClient();

        [TestMethod]
        public void AddCatagory()
        {
            var catagory = new Catagory
            {
                CatagoryName= "Vehicles",
                CreatedDate = DateTime.Now
            };
            response = client.AddCatagory(catagory);

            Assert.IsTrue(response.IsSuccessFull);
        }

        [TestMethod]
        public void ViewAllClients()
        {
            response = client.ViewAllCatagories();

            Assert.IsTrue(response.IsSuccessFull);
            Assert.IsNotNull(response.CatagoryCollection);
            Assert.IsTrue(response.CatagoryCollection.ToList().Count > 0);
        }
    }
}
