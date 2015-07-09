using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using MyRESTService.Models;
using MyRESTService.ModelServices;
using MyRESTService.Utils;

namespace MyRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductRESTService" in both code and config file together.
    [ServiceContract]
    public interface IRestService : IServicePerson, IServiceAdvertisement, IServiceClient, IServiceCatagory
    {
    }
}
