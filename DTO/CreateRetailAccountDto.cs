using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBankingProject.DTO
{
    public class CreateRetailAccountDto 
    {
        [Required]
        public int CustomerId { get; set; }
        [DataType(DataType.Text)]
        [MinLength(8)]
        [Display(Name = " name")]
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MinLength(8)]
        [Display(Name = " AccountType")]
        public string AccountType { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [MinLength(8)]

        [Display(Name = " Currency")]
        public string Currency { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Right { get; set; }

        [Required]
        [DataType(DataType.Currency)]

        public decimal AccountLimit { get; set; }

        [Required]
        public int RetailUserId { get; set; }

    }
}
