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
public class OrderStatusRepository : GenericRepository<OrderStatus>, IOrderStatusRepository
{
    public OrderStatusRepository(ApplicationDBContext context, ILogger logger) : base(context, logger)
    {
    }
}
