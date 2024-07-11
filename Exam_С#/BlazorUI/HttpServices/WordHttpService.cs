using Core.Entities;
using System.Net.Http.Json;

namespace BlazorUI.HttpServices
{
    public class WordHttpService
    {
        private readonly HttpClient _httpClient;

        public WordHttpService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<List<Word>> GetAllAsync()
        {
            var items = await _httpClient.GetFromJsonAsync<List<Word>>("/api/Word");
            return items;
        }
        public async Task AddAsync(Word item)
        {
            await _httpClient.PostAsJsonAsync("/api/Word", item);
        }

        public async Task UpdateAsync(Word item)
        {
            await _httpClient.PutAsJsonAsync($"/api/Word", item);
        }

        public async Task<Word> GetById(int id)
        {
            var result = await _httpClient
                .GetFromJsonAsync<Word>($"/api/Word/{id}");
            return result;
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync($"/api/Word/{id}");
        }
    }
}
