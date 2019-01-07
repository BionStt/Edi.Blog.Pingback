using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Edi.Blog.Pingback.MvcExtensions
{
    public class AddPingbackHeaderAttribute : ResultFilterAttribute
    {
        private readonly string _pingbackEndpoint;

        public AddPingbackHeaderAttribute(string pingbackEndpoint)
        {
            _pingbackEndpoint = pingbackEndpoint;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("x-pingback",
                new[]
                {
                    $"{context.HttpContext.Request.Scheme}://{context.HttpContext.Request.Host}/{_pingbackEndpoint}"
                });

            base.OnResultExecuting(context);
        }
    }
}
