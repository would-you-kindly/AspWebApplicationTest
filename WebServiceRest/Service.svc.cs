using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceRest
{
    public class Service : IService
    {
        public string EchoWithGet(string s)
        {
            return "You said " + s;
        }

        public string EchoWithPost(string s)
        {
            return "You said " + s;
        }
    }
}
