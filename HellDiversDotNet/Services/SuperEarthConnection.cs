using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Http;
using HellDiversDotNet.Models;
using System.Net.Http.Json;

namespace HellDiversDotNet.Services
{
    public class SuperEarthConnection
    {
        ServiceCollection serviceCollection = new ServiceCollection();

        ServiceProvider serviceProvider;

        private HttpClient BaseClient { get
            {
                var builder = serviceProvider.GetRequiredService<IHttpClientFactory>();

                return builder.CreateClient("Base");
            } }

        public async Task<BaseContent?> GetBaseContentAsync(HttpClient? httpClient = null)
        {
            if (httpClient == null)
            {
                httpClient = BaseClient;
            }

            return await httpClient.GetFromJsonAsync<BaseContent>(httpClient.BaseAddress!.ToString());
        }

        public async Task<List<Event>?> GetEventsAsync(uint? warId = null)
        {
            if (warId == null)
            {
                warId = (await GetBaseContentAsync()).CurrentSeason;
            }

            HttpClient client = BaseClient;
            var response = await client.GetFromJsonAsync<List<Event>>
                (new Uri(string.Join('/', 
                client.BaseAddress, warId, "events")));

            return response;
        }

        public async Task<Event?> GetLatestEventAsync(uint? warId = null)
        {
            if (warId == null)
            {
                warId = (await GetBaseContentAsync()).CurrentSeason;
            }

            HttpClient client = BaseClient;
            var response = await client.GetFromJsonAsync<Event>
                (new Uri(string.Join('/',
                client.BaseAddress, warId, "events", "latest")));

            return response;
        }

        public async Task<War?> GetWarAsync(uint? warId = null)
        {
            if (warId == null)
            {
                warId = (await GetBaseContentAsync()).CurrentSeason;
            }

            HttpClient client = BaseClient;
            var response = await client.GetFromJsonAsync<War>
                (new Uri(string.Join('/',
                client.BaseAddress, warId, "info")));

            return response;
        }

        public async Task<Planet?> GetPlanetAsync(uint planetId, uint? warId = null)
        {
            if (warId == null)
            {
                warId = (await GetBaseContentAsync()).CurrentSeason;
            }

            HttpClient client = BaseClient;
            var response = await client.GetFromJsonAsync<Planet>
                (new Uri(string.Join('/',
                client.BaseAddress, warId, "planets", planetId)));

            return response;
        }

        public async Task<List<Planet>?> GetPlanetsAsync(uint? warId = null)
        {
            if (warId == null)
            {
                warId = (await GetBaseContentAsync()).CurrentSeason;
            }

            HttpClient client = BaseClient;
            var response = await client.GetFromJsonAsync<List<Planet>>
                (new Uri(string.Join('/',
                client.BaseAddress, warId, "planets")));

            return response;
        }

        public async Task<PlanetWarStatus?> GetPlanetWarStatusAsync(uint planetId, uint? warId = null)
        {
            if (warId == null)
            {
                warId = (await GetBaseContentAsync()).CurrentSeason;
            }

            HttpClient client = BaseClient;
            PlanetWarStatus? response = await client.GetFromJsonAsync<PlanetWarStatus?>
                (new Uri(string.Join('/',
                client.BaseAddress, warId, "planets", planetId, "status")));

            return response;
        }

        public async Task<WarStatus?> GetWarStatusAsync(uint? warId = null)
        {
            if (warId == null)
            {
                warId = (await GetBaseContentAsync()).CurrentSeason;
            }

            HttpClient client = BaseClient;
            WarStatus? response = await client.GetFromJsonAsync<WarStatus?>
                (new Uri(string.Join('/',
                client.BaseAddress, warId, "status")));

            return response;
        }


        public SuperEarthConnection()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddHttpClient("Base", client =>
            {
                client.BaseAddress = new Uri("https://helldivers-2.fly.dev/api");
                // Configure other settings as needed
            });
            
            serviceCollection.AddLogging();

            serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
