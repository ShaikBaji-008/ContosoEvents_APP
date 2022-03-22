using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Contoso_Booking_API.Model;

namespace Contoso_Booking_API.Data
{
    public class DataConnection
        : DbContext
    {
        public DataConnection(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Booking> Bookings { get; set; }



    }
}
