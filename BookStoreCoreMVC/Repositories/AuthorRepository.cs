using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreCoreMVC.Models;
using BookStoreCoreMVC.Models.Interfaces;
using BookStoreCoreMVC.Data;


namespace BookStoreCoreMVC.Repositories;

public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
{
    public AuthorRepository(ApplicationDBContext context, ILogger logger) : base(context, logger)
    {
    }

    public async Task AddAuthorBooksAsync(IEnumerable<AuthorBook> authorBooks)
    {
        await _context.AuthorBooks.AddRangeAsync(authorBooks);
    }

    public void DeleteAuthorBooks(IEnumerable<AuthorBook> authorBooks)
    {
        _context.AuthorBooks.RemoveRange(authorBooks);
    }
}
