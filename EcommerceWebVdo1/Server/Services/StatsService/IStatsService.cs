namespace EcommerceWebVdo1.Server.Services.StatsService
{
	public interface IStatsService
	{
		Task<int> GetVisits();
		Task IncrementVisits();
	}
}
