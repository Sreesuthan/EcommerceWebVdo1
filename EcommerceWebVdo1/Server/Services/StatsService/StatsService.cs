using EcommerceWebVdo1.Server.Data;
using EcommerceWebVdo1.Shared;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWebVdo1.Server.Services.StatsService
{
	public class StatsService : IStatsService
	{
		private readonly DataContext _context;

		public StatsService(DataContext context)
		{
			_context = context;
		}
		public async Task<int> GetVisits()
		{
			var stats = await _context.Stats.FirstOrDefaultAsync();
			if (stats == null)
			{
				return 0;
			}
			return stats.Visits;
		}

		public async Task IncrementVisits()
		{
			var stats = await _context.Stats.FirstOrDefaultAsync();
			if (stats == null)
			{
				_context.Stats.Add(new Stats { Visits = 1, LastVisits = DateTime.Now });
			}
			else
			{
				stats.Visits++;
				stats.LastVisits = DateTime.Now;
			}
			await _context.SaveChangesAsync();
		}
	}
}
