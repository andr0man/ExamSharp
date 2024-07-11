using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Dictionaries;
using Repositories.Words;

namespace ServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly IWordRep _wordRep;

        public WordController(IWordRep wordRep)
        {
            _wordRep = wordRep;
        }

        [HttpGet]
        public async Task<IEnumerable<Word>> GetAllAsync()
        {
            return await _wordRep.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Word> GetAsync(int id)
        {
            return await _wordRep.GetAsync(id);
        }

        [HttpPost]
        public async Task CreateAsync(Word entity)
        {
            await _wordRep.CreateAsync(entity);
        }

        [HttpPut]
        public async Task UpdateAsync(Word entity)
        {
            await _wordRep.UpdateAsync(entity);
        }


        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _wordRep.DeleteAsync(id);

        }
    }
}
