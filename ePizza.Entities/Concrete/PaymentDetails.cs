﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Entities.Concrete
{
    public class PaymentDetails
    {
        public string Id { get; set; }
        public string  TransactionId { get; set; }
        public decimal Tax { get; set; }//vergi
        public string Currency { get; set; }
        public decimal  Total { get; set; }
        public string  Email{ get; set; }
        public string  Status { get; set; }
        public Guid CartId { get; set; }
        public int UserId { get; set; }
        public decimal  GrandTotal { get; set; }
    }
}
