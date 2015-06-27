using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace submitform
{
    /// <summary>
    /// Handler2 的摘要说明
    /// </summary>
    public class Handler2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string abcValue1 = context.Request.Form["abc"];


            context.Response.ContentType = "text/plain";
            context.Response.Write(abcValue1);
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