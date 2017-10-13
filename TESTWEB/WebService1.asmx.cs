using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TESTWEB
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private static ILog log = log4net.LogManager.GetLogger(typeof(WebService1));

        [WebMethod]
        public string HelloWorld(string mensaje, string usuario, string monto)
        {
          
            log.Info(mensaje);
            return usuario + " tiene " + monto;
            
        }
    }
}
