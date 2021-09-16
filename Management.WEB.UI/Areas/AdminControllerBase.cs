//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Routing;

//namespace Management.WEB.UI.Areas
//{
//    public class AdminControllerBase:Controller
//    {
//        protected override void Initialize(RequestContext requestContext)
//        {
//            var IsLogin = false;
//            if (requestContext.HttpContext.Session["AdminLogin"]==null)
//            {
//                //admin girişi yok
//                requestContext.HttpContext.Response.Redirect("/Admin/AdminLogin");
                
//            }
//            else
//            {
//                //admin girdi
//                base.Initialize(requestContext);
//            }
            
//        }
//    }
//}