using System;
using ServiceStack;

namespace Backend.Web
{
    public class Global : System.Web.HttpApplication
    {
        public class AppHost : AppHostBase
        {
            public AppHost() : base("ApplicationService", typeof(ApplicationService).Assembly) { }

            public override void Configure(Funq.Container container)
            {
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            new AppHost().Init();
        }
    }
}