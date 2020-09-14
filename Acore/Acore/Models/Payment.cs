using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Acore.Models
{
    public class Payment
    {
        public int ID { get; set; }
        public string Name { get; set; }
      
    }
    public class PaymentDBContext : DbContext
    {
        public DbSet<Payment> Payments { get; set; }
    }

}