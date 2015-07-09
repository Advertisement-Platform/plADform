using System;
using System.Linq;
using MyRESTService.Models;
using MyRESTService.ModelServices;
using MyRESTService.Utils;

namespace MyRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RestService : ServiceBase, IRestService
    {
        #region Person

        /// <summary>
        /// Views all persons.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public JsonResponse ViewAllPersons()
        {
            try
            {
                var personCollection = DatabaseContext.PersonCollection.ToList();

                if (personCollection.FirstOrDefault() == null)
                    return new JsonResponse { Message = "No Persons in the database!", IsSuccessFull = true };

                return new JsonResponse
                {
                    IsSuccessFull = true,
                    Message = string.Format("Found {0} entries in the database!", personCollection.Count),
                    PersonCollection = personCollection
                };
            }
            catch (Exception e)
            {
                return new JsonResponse { Message = e.Message, Exception = e };
            }
        }

        /// <summary>
        /// Adds the person.
        /// </summary>
        /// <param name="person">The person.</param>
        /// <returns></returns>
        public JsonResponse AddPerson(Person person)
        {
            if (person == null)
                return new JsonResponse { IsSuccessFull = false, Message = "Person to add was empty!" };

            try
            {
                var validationResult = DatabaseContext.Entry(person).GetValidationResult();
                if (!validationResult.IsValid)
                {
                    var entityValidationMessage = validationResult.ValidationErrors.FirstOrDefault();
                    return new JsonResponse
                    {
                        IsSuccessFull = false,
                        Message = entityValidationMessage != null
                                ? entityValidationMessage.ErrorMessage
                                : "The entity you are trying to save is NOT valid!"
                    };
                }

                DatabaseContext.PersonCollection.Add(person);
                var result = DatabaseContext.SaveChanges();

                if (result < 1)
                    return new JsonResponse { IsSuccessFull = false, Message = "Error while saving new person!" };
            }
            catch (Exception e) { return new JsonResponse { IsSuccessFull = false, Message = e.Message, Exception = e }; }
            return new JsonResponse { IsSuccessFull = true };
        }

        #endregion

        #region Advertisement

        /// <summary>
        /// Views all advertisements.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public JsonResponse ViewAllAdvertisements()
        {
            try
            {
                var advertisementCollection = DatabaseContext.AdvertisementCollection.ToList();

                if (advertisementCollection.FirstOrDefault() == null)
                    return new JsonResponse { Message = "No Advertisements in the database!", IsSuccessFull = true };

                return new JsonResponse
                {
                    IsSuccessFull = true,
                    Message = string.Format("Found {0} entries in the database!", advertisementCollection.Count),
                    AdvertisementCollection = advertisementCollection
                };
            }
            catch (Exception e)
            {
                return new JsonResponse { Message = e.Message, Exception = e };
            }
        }

        /// <summary>
        /// Adds the advertisement.
        /// </summary>
        /// <param name="advertisement">The advertisement.</param>
        /// <returns></returns>
        public JsonResponse AddAdvertisement(Advertisement advertisement)
        {
            if (advertisement == null)
                return new JsonResponse { IsSuccessFull = false, Message = "Advertisement to add was empty!" };

            try
            {
                var validationResult = DatabaseContext.Entry(advertisement).GetValidationResult();
                if (!validationResult.IsValid)
                {
                    var entityValidationMessage = validationResult.ValidationErrors.FirstOrDefault();
                    return new JsonResponse
                    {
                        IsSuccessFull = false,
                        Message = entityValidationMessage != null
                                ? entityValidationMessage.ErrorMessage
                                : "The entity you are trying to save is NOT valid!"
                    };
                }
                
                DatabaseContext.AdvertisementCollection.Add(advertisement);
                var result = DatabaseContext.SaveChanges();

                if (result < 1)
                    return new JsonResponse { IsSuccessFull = false, Message = "Error while saving new advertisement!" };
            }
            catch (Exception e) { return new JsonResponse { IsSuccessFull = false, Message = e.Message, Exception = e }; }
            return new JsonResponse { IsSuccessFull = true };
        }

        #endregion

        #region Client

        /// <summary>
        /// Views all clients.
        /// </summary>
        /// <returns></returns>
        public JsonResponse ViewAllClients()
        {
            try
            {
                var clientCollection = DatabaseContext.ClientCollection.ToList();

                if (clientCollection.FirstOrDefault() == null)
                    return new JsonResponse { Message = "No Clients in the database!", IsSuccessFull = true };

                return new JsonResponse
                {
                    IsSuccessFull = true,
                    Message = string.Format("Found {0} entries in the database!", clientCollection.Count),
                    ClientCollection = clientCollection
                };
            }
            catch (Exception e)
            {
                return new JsonResponse { Message = e.Message, Exception = e };
            }
        }

        /// <summary>
        /// Adds the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns></returns>
        public JsonResponse AddClient(Client client)
        {
            if (client == null)
                return new JsonResponse { IsSuccessFull = false, Message = "Client to add was empty!" };

            try
            {
                var validationResult = DatabaseContext.Entry(client).GetValidationResult();
                if (!validationResult.IsValid)
                {
                    var entityValidationMessage = validationResult.ValidationErrors.FirstOrDefault();
                    return new JsonResponse
                    {
                        IsSuccessFull = false,
                        Message = entityValidationMessage != null
                                ? entityValidationMessage.ErrorMessage
                                : "The entity you are trying to save is NOT valid!"
                    };
                }

                DatabaseContext.ClientCollection.Add(client);
                var result = DatabaseContext.SaveChanges();

                if (result < 1)
                    return new JsonResponse { IsSuccessFull = false, Message = "Error while saving new client!" };
            }
            catch (Exception e) { return new JsonResponse { IsSuccessFull = false, Message = e.Message, Exception = e }; }
            return new JsonResponse { IsSuccessFull = true };
        }

        #endregion

        #region Catagory

        /// <summary>
        /// Views all catagories.
        /// </summary>
        /// <returns></returns>
        public JsonResponse ViewAllCatagories()
        {
            try
            {
                var catagoryCollection = DatabaseContext.CategoryCollection.ToList();

                if (catagoryCollection.FirstOrDefault() == null)
                    return new JsonResponse { Message = "No Catagories in the database!", IsSuccessFull = true };

                return new JsonResponse
                {
                    IsSuccessFull = true,
                    Message = string.Format("Found {0} entries in the database!", catagoryCollection.Count),
                    CatagoryCollection = catagoryCollection
                };
            }
            catch (Exception e)
            {
                return new JsonResponse { Message = e.Message, Exception = e};
            }
        }

        /// <summary>
        /// Adds the catagory.
        /// </summary>
        /// <param name="catagory">The catagory.</param>
        /// <returns></returns>
        public JsonResponse AddCatagory(Catagory catagory)
        {
            if (catagory == null)
                return new JsonResponse { IsSuccessFull = false, Message = "Catagory to add was empty!" };

            try
            {
                var validationResult = DatabaseContext.Entry(catagory).GetValidationResult();
                if (!validationResult.IsValid)
                {
                    var entityValidationMessage = validationResult.ValidationErrors.FirstOrDefault();
                    return new JsonResponse
                    {
                        IsSuccessFull = false,
                        Message = entityValidationMessage != null
                                ? entityValidationMessage.ErrorMessage
                                : "The entity you are trying to save is NOT valid!"
                    };
                }

                DatabaseContext.CategoryCollection.Add(catagory);
                var result = DatabaseContext.SaveChanges();

                if (result < 1)
                    return new JsonResponse { IsSuccessFull = false, Message = "Error while saving new client!" };
            }
            catch (Exception e) { return new JsonResponse { IsSuccessFull = false, Message = e.Message, Exception = e }; }
            return new JsonResponse { IsSuccessFull = true };
        }

        #endregion
    }
}
