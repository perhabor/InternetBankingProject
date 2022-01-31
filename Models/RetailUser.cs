using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace internetBankingProject.Models
{
    public class RetailUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }  
       public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public string Password {get; set; }

        [ForeignKey(nameof(DeliveryMode))]
        public int DeliveryModeId { get; set; }

        public DeliveryMode DeliveryMode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool DeleteFlag { get; set; }

        public ICollection<RetailAccount> RetailAccounts { get; set; }
    }
}
