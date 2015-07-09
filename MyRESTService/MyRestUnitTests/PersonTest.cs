using System;
using System.Linq;
using System.Runtime.InteropServices;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyRestUnitTests.RestServiceReference;

namespace MyRestUnitTests
{
    [TestClass]
    public class PersonTest
    {
        JsonResponse response = null;
        RestServiceClient client = new RestServiceClient();

        [TestMethod]
        public void AddPerson()
        {
            var person = new Person
            {
                Name = "Ben",
                Surname = "Joubert",
                CellNo = "081568975481",
                RegistrationId = "asdflkjwer879234lkjdf",
                CanSendNotification = true,
                CreatedDate = DateTime.Now
            };
            response = client.AddPerson(person);
            
            var person2 = new Person
            {
                Name = "Robert",
                Surname = "Kleinhans",
                CellNo = "0815689745481",
                RegistrationId = "asdj395wer879234lkjdf",
                CanSendNotification = true,
                CreatedDate = DateTime.Now
            };
            response = client.AddPerson(person2);

            Assert.IsTrue(response.IsSuccessFull);
        }

        [TestMethod]
        public void ViewAllPersons()
        {
            response = client.ViewAllPersons();

            Assert.IsTrue(response.IsSuccessFull);
            Assert.IsNotNull(response.PersonCollection);
            Assert.IsTrue(response.PersonCollection.ToList().Count > 0);
        }
    }
}
