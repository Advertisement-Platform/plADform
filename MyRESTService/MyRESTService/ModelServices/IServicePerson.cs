using System.ServiceModel;
using System.ServiceModel.Web;
using MyRESTService.Models;
using MyRESTService.Utils;

namespace MyRESTService.ModelServices
{
    [ServiceContract]
    public interface IServicePerson
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "ViewAllPersons")]
        JsonResponse ViewAllPersons();
        
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "AddPerson")]
        JsonResponse AddPerson(Person person);
    }
}
