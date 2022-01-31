using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBankingProject.DTO
{
    public class RetailAccountDto : CreateRetailAccountDto
    {

        public int Id { get; set; }

       public RetailUserDto RetailUser { get; set; }


        

     
    }
}
