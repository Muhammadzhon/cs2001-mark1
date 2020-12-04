using System;
using System.Collections.Generic;
using System.Text;

namespace Mark1DataAccessLibrary
{
    public class Products
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }

        public int customerId { get; set; }
        public Customer customer { get; set; }
    }
}
