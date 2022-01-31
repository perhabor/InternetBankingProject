using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBankingProject.DTO
{
    public class RetailUserDto : CreateRetailUserDto
    {
        public int Id { get; set; }
        
        public DeliveryModeDto DeliveryMode { get; set; }

        public IList<RetailAccountDto> RetailAccounts { get; set; }
    }
}
