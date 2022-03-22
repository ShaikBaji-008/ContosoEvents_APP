using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Contoso_Events_API.Model;

namespace Contoso_Events_API.Data
{
    public class DataConnection
      : DbContext
    {
        public DataConnection(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Event> Events { get; set; }



    }
}
