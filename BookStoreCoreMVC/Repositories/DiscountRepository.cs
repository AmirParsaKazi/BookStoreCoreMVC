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
public class DiscountRepository : GenericRepository<Discount>, IDiscountRepository
{
    public DiscountRepository(ApplicationDBContext context, ILogger logger) : base(context, logger)
    {
    }
}
