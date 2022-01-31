using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace internetBankingProject.Models
{
    public class AccountRight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool DeleteFlag { get; set; }
    }
}
