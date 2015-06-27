using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace submitform
{
    /// <summary>
    /// Handler3 的摘要说明
    /// </summary>
    public class Handler3 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string bigtext = context.Request.Form["bigtext"];

            context.Response.ContentType = "text/plain";
            context.Response.Write(bigtext);
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