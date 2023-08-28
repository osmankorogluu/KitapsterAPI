using KitapsterAPI.Application.Abstractions;
using KitapsterAPI.Application.Repositories;
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
    public class BooksController : ControllerBase
    {
        readonly private IBookReadRepository _bookReadRepository;
        readonly private IBookWriteRepository _bookWriteRepository;

        public BooksController(IBookReadRepository bookReadRepository, IBookWriteRepository bookWriteRepository)
        {
            _bookReadRepository = bookReadRepository;
            _bookWriteRepository = bookWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_bookReadRepository.GetAll(false));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _bookReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Book model) 
        {
            if (ModelState.IsValid)
            {

            }
            await _bookWriteRepository.AddAsync(new()
            {
                BookName = model.BookName,
                ProductCode = model.ProductCode,
                Stock = model.Stock,
            });
            await _bookWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Book model)
        {
            Book book = await _bookReadRepository.GetByIdAsync(model.Id);
            book.BookName = model.BookName;
            book.ProductCode = model.ProductCode;
            book.Stock = model.Stock;
            await _bookWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _bookWriteRepository.RemoveAsync(id);
            await _bookWriteRepository.SaveAsync();
            return Ok();
        }

    }


}