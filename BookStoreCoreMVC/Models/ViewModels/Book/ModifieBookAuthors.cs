﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreCoreMVC.Models.ViewModels.Book;

public record ModifieBookAuthors(string BookId, IEnumerable<string> AuthorsId);
