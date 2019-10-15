using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAsWindowsService
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Add/{n1}/{n2}")]
        string Add(string n1, string n2);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped)]
        double Subtract(double n1, double n2);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped)]
        double Multiply(double n1, double n2);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped)]
        double Divide(double n1, double n2);
    }
}
