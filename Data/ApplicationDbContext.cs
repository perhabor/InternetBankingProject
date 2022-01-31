
using internetBankingProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace internetBankingProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RetailUser>().HasData(
               new RetailUser
               {
                   Id = 1,
                   FirstName = " Samuel",
                   MiddleName = "Ajayi",
                   LastName = " Osoufia",
                   Email = "Samuelo@gmail.com ",
                  Password = "forever222" ,
                
                Phone =   "+2348124536609",
                UserId = 1,
                IsActive = true,
                DeliveryModeId = 1,
                CreatedBy = "Pamela",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                ModifiedBy = " Admin" ,
                DeleteFlag = true


               },

                 new RetailUser
                 {
                     Id = 2,
                     FirstName = " Abayomi" ,
                    MiddleName = "Abas",        
                     LastName = " Osoufia",
                     Email = " abasa@gmail.com",
                    Password = "forever12345",

                     Phone = "+2347124536609",
                     UserId = 2,
                     IsActive = true,
                     DeliveryModeId = 2,
                     CreatedBy = "Pamela",
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = " Admin",
                     DeleteFlag = true


                 }


                );

            builder.Entity<DeliveryMode>().HasData(
             new DeliveryMode
             {
                 Id = 1,
                 Name = " Emmauel",
                 IsActive = true,
                 CreatedBy = "Pamela",
                 DateCreated = DateTime.Now,
                 DateModified = DateTime.Now,
                 ModifiedBy = " Admin",
                 DeleteFlag = true


             },

               new DeliveryMode
               {
                   Id = 2,
                   Name = " Isaac",
                  IsActive = true,
                   CreatedBy = "Pamela",
                   DateCreated = DateTime.Now,
                   DateModified = DateTime.Now,
                   ModifiedBy = " Admin",
                   DeleteFlag = true

               }

               );



            builder.Entity<AccountRight>().HasData(
            new AccountRight
            {
                Id = 1,
                Name = " Stan",
               IsActive = true,
                CreatedBy = "Pamela",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                ModifiedBy = " Admin",
                DeleteFlag = true


            },

              new DeliveryMode
              {
                  Id = 2,
                  Name = " Isaac",
                  IsActive = true,
                  CreatedBy = "Pamela",
                  DateCreated = DateTime.Now,
                  DateModified = DateTime.Now,
                  ModifiedBy = " Admin",
                  DeleteFlag = true

              }

              );


            builder.Entity<RetailAccount>().HasData(
           new RetailAccount
           {
               Id = 1,
               CustomerId = 1,
               Name = " Emmauel",
               AccountType = "Current",
               Currency = "Naira",
               Rights = " Customer",
               AccountLimit = 10000000,
               CreatedBy = "Pamela",
               DateCreated = DateTime.Now,
               DateModified = DateTime.Now,
               ModifiedBy = " Admin",
               DeleteFlag = true,
               RetailUserId = 1


           },

             new RetailAccount
             {
                 Id = 2,
                 CustomerId = 2,
                 Name = " Steph",
                 AccountType = "Savings",
                Currency = "Naira",
                 Rights = " Customer",
                 AccountLimit = 20000000,
                 CreatedBy = "Pamela",
                 DateCreated = DateTime.Now,
                 DateModified = DateTime.Now,
                 ModifiedBy = " Admin",
                 DeleteFlag = true,
                 RetailUserId = 1,

             }

             );

        }
       
        public DbSet<DeliveryMode>DeliveryModes { get; set; }
        public DbSet<AccountRight> AccountRights { get; set; }

        public DbSet<RetailAccount>RetailAccounts { get; set; }
        public DbSet<RetailUser> RetailUsers { get; set; }


    }
}
