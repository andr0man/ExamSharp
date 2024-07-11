using Core.Entities;
using System.Net.Http.Json;

namespace BlazorUI.HttpServices
{
    public class DictionaryService
    {
        private readonly HttpClient _httpClient;

        public DictionaryService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<List<MyDictionary>> GetAllAsync()
        {
            var items = await _httpClient.GetFromJsonAsync<List<MyDictionary>>("/api/Dictionary");
            return items;
        }
        public async Task AddAsync(MyDictionary item)
        {
            await _httpClient.PostAsJsonAsync("/api/Dictionary", item);
        }

        public async Task UpdateAsync(MyDictionary item)
        {
            await _httpClient.PutAsJsonAsync($"/api/Dictionary", item);
        }

        public async Task<MyDictionary> GetById(int id)
        {
            var result = await _httpClient
                .GetFromJsonAsync<MyDictionary>($"/api/Dictionary/{id}");
            return result;
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync($"/api/Dictionary/{id}");
        }
    }
}
