using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace UI.HttpServices
{
    public class DictionaryHttpService
    {
        private readonly HttpClient _httpClient;

        public DictionaryHttpService(HttpClient httpClient)
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
