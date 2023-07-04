using BookStoreCoreMVC.Models.ViewModels.Book;

namespace BookStoreCoreMVC.Models.Interfaces.IServices;

public interface IBookServices
{
    Task<string?> CreatBookAsync(BookCreate bookCreate);
    Task UpdateBookAsync(BookUpdate bookUpdate);
    Task DeleteBookAsync(BookDelete bookDelete);
}
