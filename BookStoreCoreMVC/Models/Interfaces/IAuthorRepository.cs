using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreCoreMVC.Models;
using BookStoreCoreMVC.Models.Interfaces;

namespace BookStoreCoreMVC.Models.Interfaces;

public interface IAuthorRepository : IGenericRepository<Author>
{
    Task AddAuthorBooksAsync(IEnumerable<AuthorBook> authorBooks);
    void DeleteAuthorBooks(IEnumerable<AuthorBook> authorBooks);
}
