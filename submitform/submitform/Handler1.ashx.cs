using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace submitform
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string inputName = context.Request.Form["inputName"];
            string inputAddress = context.Request.Form["inputAddress"];
            context.Response.ContentType = "text/plain";
            string responseData = String.Format("data:{0} {1}", inputName, inputAddress);
            context.Response.Write(responseData);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}