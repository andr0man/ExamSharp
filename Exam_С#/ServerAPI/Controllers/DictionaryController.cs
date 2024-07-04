using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories.Dictionaries;

namespace ServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictionaryController : ControllerBase
    {
        private readonly IDictionaryRep _dictionaryRep;

        public DictionaryController(IDictionaryRep dictionaryRep)
        {
            _dictionaryRep = dictionaryRep;
        }

        [HttpGet]
        public async Task<IEnumerable<MyDictionary>> GetAllAsync()
        {
            return await _dictionaryRep.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<MyDictionary> GetAsync(int id)
        {
            return await _dictionaryRep.GetAsync(id);
        }

        [HttpPost]
        public async Task CreateAsync(MyDictionary entity)
        {
            await _dictionaryRep.CreateAsync(entity);
        }

        [HttpPut]
        public async Task UpdateAsync(MyDictionary entity)
        {
            await _dictionaryRep.UpdateAsync(entity);
        }


        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _dictionaryRep.DeleteAsync(id);

        }
    }
}
