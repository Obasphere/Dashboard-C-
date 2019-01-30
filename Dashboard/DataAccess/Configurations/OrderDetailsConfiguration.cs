using Dashboard.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashboard.DataAccess.Configurations
{
    public class OrderDetailsConfiguration : EntityConfiguration<OrderDetails>
    {
        public OrderDetailsConfiguration()
        {
            Property(o => o.Quantity).IsRequired();
        }
    }
}