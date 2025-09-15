using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lastname_ATM_Kiosk.Models;

/**
 * Package Manager Console:
 * PM> Install-Package Microsoft.EntityFrameworkCore
 * PM> Install-Package Pomelo.EntityFrameworkCore.MySql
 * PM> Add-Migration InitialCreate
 * PM> Update-Database
 * 
 * PM> Add-Migration SeedInitialData
 * PM> Update-Database
 * */

namespace Lastname_ATM_Kiosk
{
    public class ATMKioskDbContext : DbContext
    {
        public DbSet<AccountModel> Accounts { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;database=ATMDB_A223_W7;user=root;password=;",
                    new MySqlServerVersion(new Version(8, 0, 36))
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed one account
            modelBuilder.Entity<AccountModel>().HasData(
                new AccountModel
                {
                    AccountId = 1,
                    AccountNumber = "1234567890",
                    AccountHolder = "John Doe",
                    Balance = 1000,
                    Pin = "1234"
                }
            );

            // Seed three transactions
            modelBuilder.Entity<TransactionModel>().HasData(
                new TransactionModel
                {
                    TransactionId = 1,
                    AccountId = 1,
                    TransactionType = "Deposit",
                    Amount = 500,
                    TransactionDate = DateTime.Now.AddDays(-2),
                    Description = "for savings"
                },
                new TransactionModel
                {
                    TransactionId = 2,
                    AccountId = 1,
                    TransactionType = "Withdrawal",
                    Amount = 200,
                    TransactionDate = DateTime.Now.AddDays(-1),
                    Description = "travel allowance"
                },
                new TransactionModel
                {
                    TransactionId = 3,
                    AccountId = 1,
                    TransactionType = "Deposit",
                    Amount = 300,
                    TransactionDate = DateTime.Now,
                    Description = "for savings"
                }
            );
        }


    }
}
