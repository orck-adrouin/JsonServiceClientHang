using System.Collections.Generic;
using Common;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack;

namespace Backend.Web
{
    public class ApplicationService : Service
    {
        public async Task<WidgetsResponse> Any(GetWidgetsRequest request)
        {
            await Task.Delay(100).ConfigureAwait(false);
            return new WidgetsResponse
            {
                Items = Enumerable.Range(0, 5000).Select(i => new Widget { Name = i.ToString() }).ToArray()
            };
        }
    }
}