using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class DbContextHelper
    {
        public static DbContextOptions<Context> generateOptions(string ConnectionString)
        {
            return new DbContextOptionsBuilder<Context>()
                    .UseSqlServer(ConnectionString)
                    .Options;
        }
    }
}
