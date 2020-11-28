using Hero.Service.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public class FakeScheduleApi : IScheduleApi
    {

        public async Task<IEnumerable<ScheduleDTO>> GetSchedulesAsync(string productId, string startDate)
        {
            await Task.CompletedTask;
            return new List<ScheduleDTO>()
            {
                new ScheduleDTO{
                     Id= 19950,
                   ScheduleId=123,
                   Start = DateTime.UtcNow
                },
                new ScheduleDTO{
                     Id= 19950,
                   ScheduleId=124,
                   Start = DateTime.UtcNow
                },
            };
        }
    }
}
