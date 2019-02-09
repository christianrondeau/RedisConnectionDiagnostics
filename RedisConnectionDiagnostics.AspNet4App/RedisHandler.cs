using System;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace RedisConnectionDiagnostics.AspNet4App
{
	public class RedisHandler : HttpTaskAsyncHandler
	{
		public override async Task ProcessRequestAsync(HttpContext httpContext)
		{
            httpContext.Response.Write(await RedisLib.RedisDiagnosticHelper.Run());
		}
	}
}
