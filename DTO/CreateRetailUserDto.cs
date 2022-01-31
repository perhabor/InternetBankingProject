using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBankingProject.DTO
{
    public class CreateRetailUserDto 
    {
        [Required]
        [DataType(DataType.Text)]
        [MinLength(8)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }


        [Required]
        [DataType(DataType.Text)]
        [MinLength(6)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [MinLength(6)]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        public int DeliveryModeId { get; set; }

    }
}
