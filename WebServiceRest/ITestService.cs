using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WebServiceRest
{
    [ServiceContract(Namespace = "")]
    public interface ITestService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Tutorial")]
        string GetAllTutorials();

        [OperationContract]
        [WebGet(UriTemplate = "/Tutorial/{TutorialId}")]
        string GetTutorialByID(string TutorialId);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
             UriTemplate = "/Tutorial", ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Wrapped)]
        void AddTutorial(string str);

        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json,
            UriTemplate = "/Tutorial/{TutorialId}", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        void DeleteTutorial(string TutorialId);
    }
}