using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBankingProject.DTO
{
    public class CreateDeliveryModeDto 
    {
        [Required]
        [DataType(DataType.Text)]
        [MinLength(6)]
        [Display(Name = "Last name")]
        public string Name { get; set; }

        [DataType(DataType.Text)]

        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }
    }
}
