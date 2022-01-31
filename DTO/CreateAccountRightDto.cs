using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBankingProject.DTO
{
    public class CreateAccountRightDto 
    {
        
        [DataType(DataType.Text)]
        [MinLength(8)]
        [Display(Name = " name")]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [MinLength(8)]
        [Display(Name = " name")]
        [Required]
        public string CreatedBy { get; set; }
    }
}
