using System.Linq;
using System.Web.Services;

namespace AspNetWebServices.Services
{
    /// <summary>
    /// Summary description for ClientServices
    /// </summary>
    [WebService(Description = "Web Services that is return Client details.", Name = "ASP.NET Web Services", Namespace = "https://aspnetwebservices.azurewebsites.net")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ClientServices : System.Web.Services.WebService
    {

        [WebMethod(Description = "Return all Client's details")]
        public AspNetWebServicesLib.DTO.Client[] Get()
        {
            return new AspNetWebServicesLib.Services.Client().Get().ToArray();
        }
    }
}
