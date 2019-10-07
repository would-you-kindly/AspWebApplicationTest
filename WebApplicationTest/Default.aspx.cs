using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTest
{
    public partial class Default : System.Web.UI.Page
    {
        // Вызывается во время первоначальной загрузки и при поступлении запросов от данной страницы
        protected void Page_Load(object sender, EventArgs e)
        {
            // Относится ли запрос, на который производится ответ, к форме, отправленной обратно серверу
            if (IsPostBack)
            {
                GuestResponse rsvp = new GuestResponse();

                // TryUpdateModel выполняет процесс привязки модели (значений полей формы и значений объекта данных)
                if (TryUpdateModel(rsvp, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    ResponseRepository.GetRepository().AddResponse(rsvp);
                    if (rsvp.WillAttend.HasValue && rsvp.WillAttend.Value)
                    {
                        Response.Redirect("SeeYouThere.html");
                    }
                    else
                    {
                        Response.Redirect("SorryYouCantCome.html");
                    }
                }
            }
        }
    }
}