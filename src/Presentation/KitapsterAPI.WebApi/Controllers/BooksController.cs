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
        public async Task<IActionResult> Get()
        {
            return Ok(_bookReadRepository.GetAll());

        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }

    }


}