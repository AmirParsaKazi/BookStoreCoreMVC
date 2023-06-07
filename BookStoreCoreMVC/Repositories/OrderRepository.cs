using Microsoft.EntityFrameworkCore;
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
public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(ApplicationDBContext context, ILogger logger) : base(context, logger)
    {
    }

    public async Task AddOrderBooksAsync(IEnumerable<OrderBook> orderBooks)
    {
        await _context.OrderBooks.AddRangeAsync(orderBooks);
        _context.OrderStatuses.AsNoTrackingWithIdentityResolution();

    }

    public void DeleteOrderBooks(IEnumerable<OrderBook> orderBooks)
    {
        _context.OrderBooks.RemoveRange(orderBooks);
    }
}
