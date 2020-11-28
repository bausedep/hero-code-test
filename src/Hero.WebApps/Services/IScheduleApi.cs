using Hero.Service.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public interface IScheduleApi
    {
        [Get("/schedule/{productId}/{startDate}")]
        Task<IEnumerable<ScheduleDTO>> GetSchedulesAsync(string productId, string startDate);
    }
}
