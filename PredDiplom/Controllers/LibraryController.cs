using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Entities.DataTransferObjects;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Entities.Models;
using Entities.DataTransferObjects;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

namespace PredDiplom.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IRepositoryManager _repository; 
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BooksController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_repository.Book.GetAllBooks(false));
        }
        [HttpGet("{id}", Name = "BookById")]
        public IActionResult GetBook(Guid id)
        {
            var book = _repository.Book.GetBook(id, trackChanges: false); 
            if (book == null)
            {
                _logger.LogInfo($"Book with id: {id} doesn't exist in the database."); 
                return NotFound();
            }
            else
            {
                var bookDto = _mapper.Map<BookDto>(book); 
                return Ok(bookDto);
            }
        }

        [HttpPost]
        public IActionResult CreateBook([FromBody] BookForCreationDto book)
        {
            if (book == null)
            {
                _logger.LogError("CompanyForCreationDto object sent from client is null.");
                return BadRequest("CompanyForCreationDto object is null");
            }

            var bookEntity = _mapper.Map<Book>(book);

            _repository.Book.CreateBook(bookEntity);
            _repository.Save();

            var bookToReturn = _mapper.Map<BookDto>(bookEntity);

            return CreatedAtRoute("BookById", new { id = bookToReturn.Id }, bookToReturn);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(Guid id)
        {
            var book = _repository.Book.GetBook(id, trackChanges: false);
            if (book == null)
            {
                _logger.LogInfo($"Book with id: {id} doesn't exist in the database."); 
                return NotFound();
            }

            _repository.Book.DeleteBook(book);
            _repository.Save();

            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateBook(Guid id, [FromBody] BookForUpdateDto book)
        {
            if (book == null)
            {
                _logger.LogError("BookForUpdateDto object sent from client is null."); 
                return BadRequest("BookForUpdateDto object is null");
            }

            var bookEntity = _repository.Book.GetBook(id, trackChanges: true); 
            if (bookEntity == null)
            {
                _logger.LogInfo($"Book with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(book, bookEntity);
            _repository.Save();

            return NoContent();
        }
        [HttpPatch("{id}")]
        public IActionResult PartiallyUpdateBook(Guid id, 
            [FromBody] JsonPatchDocument<BookForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from client is null."); 
                return BadRequest("patchDoc object is null");
            }

            var bookEntity = _repository.Book.GetBook(id, trackChanges: true);
            if (bookEntity == null)
            {
                _logger.LogInfo($"Employee with id: {id} doesn't exist in the database."); 
                return NotFound();
            }

            var bookToPatch = _mapper.Map<BookForUpdateDto>(bookEntity); 
            patchDoc.ApplyTo(bookToPatch);
            _mapper.Map(bookToPatch, bookEntity);
            _repository.Save(); 
            return NoContent();
        }


    }

}
