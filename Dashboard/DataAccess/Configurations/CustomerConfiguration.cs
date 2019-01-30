using Dashboard.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashboard.DataAccess.Configurations
{
    public class CustomerConfiguration : EntityConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            property(c => c.CustomerName).IsRequired().HasMaxLength(100);
            property(c => c.CustomerEmail).IsRequired().HasMaxLength(60);
            property(c => c.CustomerPhone).IsRequired().HasMaxLength(100);
            property(c => c.CustomerCountry).IsRequired().HasMaxLength(100);
            property(c => c.CustomerImage).IsOptional();
        }
    }
}