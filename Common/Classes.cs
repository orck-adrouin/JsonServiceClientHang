using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Common
{
    public class Widget
    {
        public string Name { get; set; }
    }

    [Route("/widgets/list")]
    public class GetWidgetsRequest : IReturn<WidgetsResponse>
    {
    }

    [Route("/widget/{Name}")]
    public class GetWidgetRequest : IReturn<Widget>
    {
        public string Name { get; set; }
    }

    public class WidgetsResponse
    {
        public Widget[] Items { get; set; }
    }
}
