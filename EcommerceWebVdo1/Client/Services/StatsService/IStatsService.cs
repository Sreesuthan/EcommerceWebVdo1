namespace EcommerceWebVdo1.Client.Services.StatsService
{
	public interface IStatsService
	{
		Task GetVisits();
		Task IncrementVisits();
	}
}
