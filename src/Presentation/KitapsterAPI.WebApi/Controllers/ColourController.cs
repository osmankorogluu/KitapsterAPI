using KitapsterAPI.Application.Repositories;
using KitapsterAPI.Domain.Entites.Models;
using KitapsterAPI.Persistence.Repositeries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace KitapsterAPI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColourController : ControllerBase
    {
        private readonly IColourReadRepository _colourReadRepository;
        private readonly IColourWriteRepository _colourWriteRepository;

        public ColourController(IColourReadRepository colourReadRepository, IColourWriteRepository colourWriteRepository)
        {
            _colourReadRepository = colourReadRepository;
            _colourWriteRepository = colourWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_colourReadRepository.GetAll(false).Select(p => new
            {
                p.Id,
                p.ColourName,
                p.CreateDate,
                p.UpdatedDate

            }));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _colourReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Colour model)
        {
            if (ModelState.IsValid)
            {


            }

            await _colourWriteRepository.AddAsync(new()
            {
                ColourName = model.ColourName,

            });
            await _colourWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _colourWriteRepository.RemoveAsync(id);
            await _colourWriteRepository.SaveAsync();
            return Ok();
        }
    }
}
