using System.ServiceModel;
using System.ServiceModel.Web;
using MyRESTService.Models;
using MyRESTService.Utils;

namespace MyRESTService.ModelServices
{
    [ServiceContract]
    public interface IServiceAdvertisement
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "ViewAllAdvertisements")]
        JsonResponse ViewAllAdvertisements();

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "AddAdvertisement")]
        JsonResponse AddAdvertisement(Advertisement advertisement);
    }
}
