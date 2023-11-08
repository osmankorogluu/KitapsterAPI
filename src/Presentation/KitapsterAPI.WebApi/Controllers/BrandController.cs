using KitapsterAPI.Application.Repositories;
using KitapsterAPI.Application.WiewModels.Books;
using KitapsterAPI.Domain.Entites.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace KitapsterAPI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        readonly private IBrandReadRepository _brandReadRepository;
        readonly private IBrandWriteRepository _brandWriteRepository;

        public BrandController(IBrandReadRepository brandReadRepository, IBrandWriteRepository brandWriteRepository)
        {
            _brandReadRepository = brandReadRepository;
            _brandWriteRepository = brandWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_brandReadRepository.GetAll(false).Select(p => new
            {
                p.Id,
                p.BrandName,
                p.CreateDate,
                p.UpdatedDate

            }));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _brandReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Brand model)
        {
            if (ModelState.IsValid)
            {


            }

            await _brandWriteRepository.AddAsync(new()
            {
                BrandName = model.BrandName,
                
            });
            await _brandWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _brandWriteRepository.RemoveAsync(id);
            await _brandWriteRepository.SaveAsync();
            return Ok();
        }
    }
}
