using AutoMapper;
using Library.Data;
using Library.Infrastructure;
using Library.Infrastructure.Context;
using Library.Models;
using Library.Models.Books;
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
    public class BooksController : BaseController
    {
        private readonly LibraryDbContext _context;

        public BooksController(LibraryDbContext context, IMapper mapper) : base(mapper) => _context = context;

        [HttpGet]
        [CustomAuthorize(Constants.Permissions.Books.Search)]
        public async Task<IActionResult> GetBooks()
        {
            List<BookModel> books = await _context.Books.Include(x => x.Author).ToListAsync();

            return Ok(books);
        }

        [HttpGet("{id}")]
        [CustomAuthorize(Constants.Permissions.Books.Search)]
        public async Task<IActionResult> GetBook(Guid id)
        {
            BookModel book = await _context.Books.Where(x => x.Id == id).Include(x => x.Author).FirstOrDefaultAsync();
            if (book == null) return NotFound(new ErrorModel($"Book with id: {id} does not exist."));

            return Ok(book);
        }

        [HttpPost]
        [CustomAuthorize(Constants.Permissions.Books.Add)]
        public async Task<IActionResult> AddBook(AddBookModel model)
        {
            AuthorModel author = await _context.Authors.Where(x => x.Id == model.AuthorId).Include(x => x.Books).FirstOrDefaultAsync();
            if (author == null) return NotFound(new ErrorModel($"Author with id: {model.AuthorId} does not exist."));

            BookModel book = author.Books.Where(x => x.Name == model.Name).FirstOrDefault();
            if (book != null) return BadRequest(new ErrorModel($"Book {model.Name}, written by {author.FirstName} {author.LastName}, already exists."));
            
            book = _mapper.Map<BookModel>(model);
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            return Created("", book);
        }

        [HttpDelete("{id}")]
        [CustomAuthorize(Constants.Permissions.Books.Delete)]
        public async Task<IActionResult> DeleteBook(Guid id)
        {
            BookModel book = await _context.Books.Where(x => x.Id == id).Include(x => x.Author).FirstOrDefaultAsync();
            if (book == null) return NotFound(new ErrorModel($"Book with id: {id} does not exist."));

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return Ok(book);
        }

        [HttpPut("{id}")]
        [CustomAuthorize(Constants.Permissions.Books.Edit)]
        public async Task<IActionResult> EditBook(Guid id, AddBookModel model)
        {
            AuthorModel author = await _context.Authors.FindAsync(model.AuthorId);
            if (author == null) return NotFound(new ErrorModel($"Author with id: {model.AuthorId} does not exist."));

            BookModel book = await _context.Books.Include(x => x.Author).Where(x => x.Id == id).FirstOrDefaultAsync();
            if (book == null) return NotFound(new ErrorModel($"Book with id: {id} does not exist."));

            book = _mapper.Map(model, book);
            await _context.SaveChangesAsync();

            return Ok(book);
        }
    }
}

