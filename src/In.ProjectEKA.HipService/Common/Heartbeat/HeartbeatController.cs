using System.Threading.Tasks;
using In.ProjectEKA.HipService.Common.Heartbeat.Model;
using Microsoft.AspNetCore.Mvc;

namespace In.ProjectEKA.HipService.Common.Heartbeat

{
    // TODO: This is dummy implementation and actual implementation has to be done by respective HIPs
    [ApiController]
    public class HeartbeatController : ControllerBase
    {
        private readonly Heartbeat heartbeat;

        public HeartbeatController(Heartbeat heartbeat)
        {
            this.heartbeat = heartbeat;
        }
        [Route("v1/heartbeat")]
        [HttpGet]
         public async Task<HeartbeatResponse>  GetProvidersByName()
        {
            return heartbeat.GetHealthStatus();
        }
    }
}