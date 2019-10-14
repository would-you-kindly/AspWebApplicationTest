using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Web.Http;

namespace WebServiceRest
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class TestService : ITestService
    {
        private static List<string> lst = new List<string>
        {
            "Arrays",
            "Queues",
            "Stacks"
        };

        public void AddTutorial(string str)
        {
            lst.Add(str);
        }

        public void DeleteTutorial(string TutorialId)
        {
            int pid;
            if (!int.TryParse(TutorialId, out pid))
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            lst.RemoveAt(pid);
        }

        public string GetAllTutorials()
        {
            return string.Join(",", lst);
        }

        public string GetTutorialByID(string TutorialId)
        {
            int pid;
            if (!int.TryParse(TutorialId, out pid))
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            return lst[pid];
        }
    }
}
