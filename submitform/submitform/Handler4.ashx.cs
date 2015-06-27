using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace submitform
{
    /// <summary>
    /// Handler4 的摘要说明
    /// </summary>
    public class Handler4 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string result = "Hello World" + Environment.NewLine + "xx'x<>?\"\\//";
            context.Response.Write(result);
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