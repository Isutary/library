using AutoMapper;
using Library.Data;
using Library.Infrastructure;
using Library.Infrastructure.Context;
using Library.Models;
using Library.Models.Authors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : BaseController
    {
        private readonly LibraryDbContext _context;

        public AuthorsController(LibraryDbContext context, IMapper mapper) : base(mapper) => _context = context;

        [HttpGet]
        [CustomAuthorize(Constants.Permissions.Authors.Search)]
        public async Task<IActionResult> GetAuthors()
        {
            List<AuthorModel> authors = await _context.Authors.Include(x => x.Books).ToListAsync();

            return Ok(authors);
        }

        [HttpGet("{id}")]
        [CustomAuthorize(Constants.Permissions.Authors.Search)]
        public async Task<IActionResult> GetAuthor(Guid id)
        {
            AuthorModel author = await _context.Authors.Where(x => x.Id == id).Include(x => x.Books).FirstOrDefaultAsync();
            if (author == null) return NotFound(new ErrorModel($"Author with id: {id} does not exist."));
            
            return Ok(author);
        }

        [HttpPost]
        [CustomAuthorize(Constants.Permissions.Authors.Add)]
        public async Task<IActionResult> AddAuthor(AddAuthorModel model)
        {
            AuthorModel author = await _context.Authors.Where(x => x.FirstName == model.FirstName && x.LastName == model.LastName).FirstOrDefaultAsync();
            if (author != null) return BadRequest(new ErrorModel($"Author {author.FirstName} {author.LastName} already exists."));
            
            author = _mapper.Map<AuthorModel>(model);
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();

            return Created("", author);
        }

        [HttpDelete("{id}")]
        [CustomAuthorize(Constants.Permissions.Authors.Delete)]
        public async Task<IActionResult> DeleteAuthor(Guid id)
        {
            AuthorModel author = await _context.Authors.Where(x => x.Id == id).Include(x => x.Books).FirstOrDefaultAsync();
            if (author == null) return NotFound(new ErrorModel($"Author with id: {id} does not exist."));
            
            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();

            return Ok(author);
        }

        [HttpPut("{id}")]
        [CustomAuthorize(Constants.Permissions.Authors.Edit)]
        public async Task<IActionResult> EditAuthor(Guid id, AddAuthorModel model)
        {
            AuthorModel author = await _context.Authors.Include(x => x.Books).Where(x => x.Id == id).FirstOrDefaultAsync();
            if (author == null) return NotFound(new ErrorModel($"Author with id: {id} does not exist."));

            author = _mapper.Map(model, author);
            await _context.SaveChangesAsync();

            return Ok(author);
        }
    }
}