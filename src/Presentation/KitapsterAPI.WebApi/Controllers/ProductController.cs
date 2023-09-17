using KitapsterAPI.Application.Abstractions;
using KitapsterAPI.Application.Repositories;
using KitapsterAPI.Application.Validators.Books;
using KitapsterAPI.Application.WiewModels.Books;
using KitapsterAPI.Domain.Entites.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace KitapsterAPI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        public ProductController(IProductReadRepository bookReadRepository, IProductWriteRepository bookWriteRepository)
        {
            _productReadRepository = bookReadRepository;
            _productWriteRepository = bookWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_productReadRepository.GetAll(false).Select(p=> new 
            {
                p.Id,
                p.ProductName,
                p.ProductCode,
                p.Stock,
                p.CreateDate,
                p.UpdatedDate

            }));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _productReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Product model)
        {
            if (ModelState.IsValid)
            {
               
              
            }

            await _productWriteRepository.AddAsync(new()
            {
                ProductName = model.ProductName,
                ProductCode = model.ProductCode,
                Stock = model.Stock,
            });
            await _productWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }



        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Product model)
        {
            Product book = await _productReadRepository.GetByIdAsync(model.Id);
            book.ProductName = model.ProductName;
            book.ProductCode = model.ProductCode;
            book.Stock = model.Stock;
            await _productWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _productWriteRepository.RemoveAsync(id);
            await _productWriteRepository.SaveAsync();
            return Ok();
        }

    }


}