using System.ServiceModel;
using System.ServiceModel.Web;
using MyRESTService.Models;
using MyRESTService.Utils;

namespace MyRESTService.ModelServices
{
    [ServiceContract]
    public interface IServiceCatagory
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "ViewAllCatagories")]
        JsonResponse ViewAllCatagories();
        
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "AddCatagory")]
        JsonResponse AddCatagory(Catagory catagory);
    }
}
