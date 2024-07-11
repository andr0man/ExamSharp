using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Translations;
using Repositories.Words;

namespace ServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationController : ControllerBase
    {
        private readonly ITranslationRep _translationRep;

        public TranslationController(ITranslationRep translationRep)
        {
            _translationRep = translationRep;
        }

        [HttpGet]
        public async Task<IEnumerable<Translation>> GetAllAsync()
        {
            return await _translationRep.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Translation> GetAsync(int id)
        {
            return await _translationRep.GetAsync(id);
        }

        [HttpPost]
        public async Task CreateAsync(Translation entity)
        {
            await _translationRep.CreateAsync(entity);
        }

        [HttpPut]
        public async Task UpdateAsync(Translation entity)
        {
            await _translationRep.UpdateAsync(entity);
        }


        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _translationRep.DeleteAsync(id);

        }
    }
}
