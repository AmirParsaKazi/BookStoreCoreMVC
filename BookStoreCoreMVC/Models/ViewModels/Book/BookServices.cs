using BookStoreCoreMVC.Configuration;
using BookStoreCoreMVC.Models.Interfaces.IServices;
using BookStoreCoreMVC.Models.ViewModels.Category;
using Microsoft.EntityFrameworkCore;

namespace BookStoreCoreMVC.Models.ViewModels.Book;

public class BookServices: IBookServices
{
    private readonly IUnitOfWork _unitOfWork;
    public BookServices(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void BindSubCategories(TreeViewCategoryViewModel category)
    {
        //var subCategories = (from c in _context.Categories
        //where (category.CategoryId == c.ParentCategoryId)
        //                     select new TreeViewCategoryViewModel()
        //                     {
        //                         CategoryId = c.CategoryId,
        //                         CategoryName = c.CategoryName,
        //                     }).ToList();

        //foreach (var item in subCategories)
        //{
        //    BindSubCategories(item);
        //    category.SubCategories.Add(item);
        //}

    }

    public Task<string?> CreatBookAsync(BookCreate bookCreate)
    {
        //ViewBag.LanguageID = new SelectList(_context.Languages.ToList(), "LanguageId", "LanguageName");
        //ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherId", "PublisherName");
        //ViewBag.AuthorID = new SelectList(_context.Authors.Select(p => new AuthorList { AuthorId = p.AuthorId, NameFamily = p.FirstName + " " + p.LastName }), "AuthorId", "NameFamily");

        //var categories = (from c in _context.Categories
        //                  where (c.ParentCategoryId == null)
        //                  select new TreeViewCategoryViewModel()
        //                  {
        //                      CategoryId = c.CategoryId,
        //                      CategoryName = c.CategoryName,
        //                  }).ToList();

        //foreach (var item in categories)
        //{
        //    _booksRepository.BindSubCategories(item);
        //}

        //var BooksViewModel = new BooksViewModel(categories);

        throw new NotImplementedException();
    }

    public Task DeleteBookAsync(BookDelete bookDelete)
    {
        throw new NotImplementedException();
    }

    public Task UpdateBookAsync(BookUpdate bookUpdate)
    {
        throw new NotImplementedException();
    }
}
