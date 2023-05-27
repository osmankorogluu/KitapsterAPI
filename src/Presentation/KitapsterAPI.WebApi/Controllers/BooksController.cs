using KitapsterAPI.Application.Abstractions;
using KitapsterAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
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
        public async void Get()
        {
            await _bookWriteRepository.AddRangeAsync(new()
            {
                new() {Id = Guid.NewGuid(), BookName= "Book 1",CreateDate = DateTime.Now},

            });
           var count = await _bookWriteRepository.SaveAsync();
        }

    }
}