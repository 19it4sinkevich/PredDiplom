using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Repository.BookRepository;

namespace Repository
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
        public IEnumerable<Book> GetAllBooks(bool trackChanges) => FindAll(trackChanges).OrderBy(c => c.Name).ToList();
        public void CreateBook(Book book) => Create(book);
        public Book GetBook(Guid bookId, bool trackChanges) => 
            FindByCondition(c => c.Id.Equals(bookId), trackChanges).SingleOrDefault();
        public void DeleteBook(Book book)
        {
            Delete(book);
        }


    }
}
