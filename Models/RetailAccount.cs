using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace internetBankingProject.Models
{
    public class RetailAccount
    {
        public int Id { get; set; }

      
       // [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

       // public Customer Customer { get; set; }
        public string Name { get; set; }
        public string AccountType { get; set; }
        public string Currency { get; set; }
        public string Rights { get; set; }
        public decimal AccountLimit { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated{ get; set; }
        public DateTime DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool DeleteFlag { get; set; }

         [ForeignKey(nameof(RetailUser))]
        public int RetailUserId { get; set; }

        public RetailUser RetailUser { get; set; }

    }
}
