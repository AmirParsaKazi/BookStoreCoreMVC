using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookStoreCoreMVC.Models;
using BookStoreCoreMVC.Models.Interfaces;

namespace BookStoreCoreMVC.Models.Interfaces;

public interface IOrderRepository:IGenericRepository<Order>
{
    Task AddOrderBooksAsync(IEnumerable<OrderBook> orderBooks);

    void DeleteOrderBooks(IEnumerable<OrderBook> orderBooks);
}
