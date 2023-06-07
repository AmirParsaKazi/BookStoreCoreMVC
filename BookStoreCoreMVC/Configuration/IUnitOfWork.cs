using BookStoreCoreMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreCoreMVC.Configuration;

public interface IUnitOfWork
{
    IAuthorRepository Author { get; }
    IBookRepository Book { get; }
    ICategoryRepository Category { get; }
    ICityRepository City { get; }
    ICustomerRepository Customer { get; }
    IDiscountRepository Discount { get; }
    ILanguageRepository Language { get; }
    IOrderRepository Order { get; }
    IOrderStatusRepository OrderStatus { get; }
    IProvinceRepository Province { get; }

    Task CompleteAsync();

    Task Dispose();
}
