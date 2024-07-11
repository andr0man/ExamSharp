using Core.Entities;
using System.Net.Http.Json;

namespace BlazorUI.HttpServices
{
    public class TranslationHttpService
    {
        private readonly HttpClient _httpClient;

        public TranslationHttpService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<List<Translation>> GetAllAsync()
        {
            var items = await _httpClient.GetFromJsonAsync<List<Translation>>("/api/Translation");
            return items;
        }
        public async Task AddAsync(Translation item)
        {
            await _httpClient.PostAsJsonAsync("/api/Translation", item);
        }

        public async Task UpdateAsync(Translation item)
        {
            await _httpClient.PutAsJsonAsync($"/api/Translation", item);
        }

        public async Task<Translation> GetById(int id)
        {
            var result = await _httpClient
                .GetFromJsonAsync<Translation>($"/api/Translation/{id}");
            return result;
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync($"/api/Translation/{id}");
        }
    }
}
