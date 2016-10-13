using ServiceStack;
using ServiceStack.Web;
using System;

namespace WebApplication1
{
    public class GatewayFactory : ServiceGatewayFactoryBase
    {
        private static JsonServiceClient client = new JsonServiceClient("http://localhost:20690/");
        //private static JsonHttpClient client = new JsonHttpClient("http://localhost:20690/");

        public override IServiceGateway GetServiceGateway(IRequest request)
        {
            if (request.AbsoluteUri.Contains("widgets"))
                return client;
            return base.GetServiceGateway(request);
        }

        public override IServiceGateway GetGateway(Type requestType)
        {
            return base.localGateway;
        }
    }
}