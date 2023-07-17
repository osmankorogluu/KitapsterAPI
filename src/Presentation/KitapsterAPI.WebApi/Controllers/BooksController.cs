using KitapsterAPI.Application.Abstractions;
using KitapsterAPI.Application.Repositories;
using KitapsterAPI.Domain.Entites.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

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
        public async Task Get()
        {
            await _bookWriteRepository.AddRangeAsync(new()
            {
                new() {Id = Guid.NewGuid(), BookName= "Book 1",ProductCode = 55,Stock=5, Translator ="ben", Preparer="sen", Publisher="geş", PublicationPlace="ds", Language="df", Skin= "df", ISBN=5555, Situation="sf", Condition="iyi", Cargo="mng" ,CreateDate = DateTime.Now},

            });
           var count = await _bookWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Book book = await _bookReadRepository.GetByIdAsync(id);
            return Ok(book);
        }
    }

   
}