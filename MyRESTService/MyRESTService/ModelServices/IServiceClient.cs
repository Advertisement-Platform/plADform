using System.ServiceModel;
using System.ServiceModel.Web;
using MyRESTService.Models;
using MyRESTService.Utils;

namespace MyRESTService.ModelServices
{
    [ServiceContract]
    public interface IServiceClient
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "ViewAllClients")]
        JsonResponse ViewAllClients();
        
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "AddClient")]
        JsonResponse AddClient(Client client);
    }
}
