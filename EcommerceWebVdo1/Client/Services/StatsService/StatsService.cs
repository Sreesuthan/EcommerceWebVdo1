using Blazored.LocalStorage;

namespace EcommerceWebVdo1.Client.Services.StatsService
{
	public class StatsService : IStatsService
	{
		private readonly HttpClient _http;
		private readonly ILocalStorageService _localStorage;

		public StatsService(HttpClient http, ILocalStorageService localStorage)
		{
			_http = http;
			_localStorage = localStorage;
		}
		public async Task GetVisits()
		{
			int visits = int.Parse(await _http.GetStringAsync("api/stats"));
			Console.WriteLine($"Visits:" + visits);
		}

		public async Task IncrementVisits()
		{
			DateTime? lastVisit = await _localStorage.GetItemAsync<DateTime?>("LastVisit");
			if(lastVisit==null || ((DateTime)lastVisit).Date != DateTime.Now) 
			{
				await _localStorage.SetItemAsync("lastvisit", DateTime.Now);
				await _http.PostAsync("api/Stats", null);
			}
 		}
	}
}
