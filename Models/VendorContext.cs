using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Rental.Models
{
    public class VendorContext : DbContext
    {
        public VendorContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Vendor> Vendors { get; set; }

    }
}
