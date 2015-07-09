using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRESTService.Models;

namespace MyRESTService.Utils
{
    public class JsonResponse
    {
        public JsonResponse()
        {
            Exception = null;
            Message = string.Empty;
            IsSuccessFull = false;
        }

        public Exception Exception { get; set; }
        public string Message { get; set; }
        public bool IsSuccessFull { get; set; }

        #region Collections
        public List<Person> PersonCollection { get; set; }
        public List<Advertisement> AdvertisementCollection { get; set; }
        public List<Vehicle> VehicleCollection { get; set; }
        public List<Client> ClientCollection { get; set; }
        public List<Catagory> CatagoryCollection { get; set; }
        #endregion
    }
}
