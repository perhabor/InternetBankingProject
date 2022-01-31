using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBankingProject.DTO
{
    public class DeliveryModeDto : CreateDeliveryModeDto
    {
        public int Id { get; set; }

        public IList<RetailAccountDto> RetailAccounts { get; set; }

      
    }
}
