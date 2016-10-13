using Common;
using Funq;
using ServiceStack;
using ServiceStack.Web;

namespace WebApplication1
{
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("GatewayService !", typeof(AppHost).Assembly) { }

        public override void Configure(Funq.Container container)
        {
            this.Plugins.Add(new GatewayPlugin());
            container.Register<IServiceGatewayFactory>(x => new GatewayFactory());
        }
    }
}