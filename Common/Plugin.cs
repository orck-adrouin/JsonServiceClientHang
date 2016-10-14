using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Common
{

    public class GatewayPlugin : IPlugin
    {
        public void Register(IAppHost appHost)
        {
            appHost.RegisterService(typeof(GatewayService));
        }
    }


    public class GatewayService : Service
    {
        public Task<Widget> Any(GetWidgetRequest request)
        {
            return Gateway.SendAsync(request);
        }

        public Task<WidgetsResponse> Any(GetWidgetsRequest request)
        {
            return Gateway.SendAsync(request);
        }
    }
}
