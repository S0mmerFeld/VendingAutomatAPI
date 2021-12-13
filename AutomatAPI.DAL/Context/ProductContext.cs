using AutomatAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Automat.DAL.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
             : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<AutomatMachine> AutomatMachine { get; set; }
        public DbSet<ServiceMan> ServiceMan { get; set; }
        public DbSet<ServiceCard> ServiceCard { get; set; }
        public DbSet<DiscountCard> DiscountCard { get; set; }
        public DbSet<Solds> Solds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(product => product.Id);
            modelBuilder.Entity<Product>().Property(product => product.Name).HasMaxLength(30);
            modelBuilder.Entity<Product>().Property(product => product.Name).IsRequired();
            modelBuilder.Entity<Product>().Property(product => product.Location).HasMaxLength(30);
            modelBuilder.Entity<Product>().Property(product => product.Location).IsRequired();
            modelBuilder.Entity<Product>().Property(product => product.Price).IsRequired();
            modelBuilder.Entity<Product>().Property(product => product.Price).HasMaxLength(10);
            modelBuilder.Entity<Product>().Property(product => product.Description).IsRequired();
            modelBuilder.Entity<Product>().Property(product => product.Description).HasMaxLength(10);
            modelBuilder.Entity<Product>().Property(product => product.Sells).IsRequired();

            modelBuilder.Entity<Product>().Property(product => product.PriceString).HasMaxLength(10);
            modelBuilder.Entity<Product>().Property(product => product.PriceString).IsRequired();
            modelBuilder.Entity<Product>().Property(product => product.ShortDescription).HasMaxLength(10);
            modelBuilder.Entity<Product>().Property(product => product.ShortDescription).IsRequired();
            modelBuilder.Entity<Product>().Property(product => product.CurrentQuantity).HasMaxLength(10);
            modelBuilder.Entity<Product>().Property(product => product.CurrentQuantity).IsRequired();

            modelBuilder.Entity<Product>(entity => entity.HasIndex(product => product.Id).IsUnique());

            modelBuilder.Entity<Product>().HasData(
               new Product { Id = 1, Name = "Вода", Location = "Караван", Price = 10, Description = "Газ", Sells = 10, PriceString = "1.00", ShortDescription = "Бонаква", CurrentQuantity = 0},
               new Product { Id = 2, Name = "Кола", Location = "Дафи", Price = 20, Description = "СО2", Sells = 13, PriceString = "2.00", ShortDescription = "2 литра", CurrentQuantity = 0 },
               new Product { Id = 3, Name = "Снек", Location = "Аве Плаза", Price = 35, Description = "Бутерброд", Sells = 30, PriceString = "3.00", ShortDescription = "Бутерброд", CurrentQuantity = 0 },
               new Product { Id = 4, Name = "Кофе", Location = "АТБ", Price = 40, Description = "Арабика", Sells = 20, PriceString = "4.00", ShortDescription = "100г Якобс", CurrentQuantity = 0 },
               new Product { Id = 5, Name = "Чипсы", Location = "Комфи", Price = 5, Description = "Лэйс", Sells = 11, PriceString = "5.00",ShortDescription = "lays сыр", CurrentQuantity = 0 }
               );



            modelBuilder.Entity<Solds>().HasKey(solds => solds.Id);
            modelBuilder.Entity<Solds>().Property(solds => solds.Name).HasMaxLength(30);
            modelBuilder.Entity<Solds>().Property(solds => solds.Name).IsRequired();
            modelBuilder.Entity<Solds>().Property(solds => solds.Tax).HasMaxLength(10);
            modelBuilder.Entity<Solds>().Property(solds => solds.Tax).IsRequired();
            modelBuilder.Entity<Solds>().Property(solds => solds.SellsDateTime).HasMaxLength(20);
            modelBuilder.Entity<Solds>().Property(solds => solds.SellsDateTime).IsRequired();
            modelBuilder.Entity<Solds>().Property(solds => solds.Price).IsRequired();
            modelBuilder.Entity<Solds>().Property(solds => solds.Price).HasMaxLength(10);
            modelBuilder.Entity<Solds>().Property(solds => solds.PriceString).HasMaxLength(10);
            modelBuilder.Entity<Solds>().Property(solds => solds.PriceString).IsRequired();
            modelBuilder.Entity<Solds>(entity => entity.HasIndex(solds => solds.Id).IsUnique());

            modelBuilder.Entity<Solds>().HasData(
               new Solds { Id = 1, Name = "Вода",  Price = 1,  PriceString = "1.00", Tax = 20, SellsDateTime = new DateTime(2021, 11, 1, 7, 10, 0) },
               new Solds { Id = 2, Name = "Кола", Price = 2,  PriceString = "2.00",   Tax = 20, SellsDateTime = new DateTime(2021, 11, 2, 7, 20, 0) },
               new Solds { Id = 3, Name = "Снек", Price = 3,   PriceString = "3.00", Tax = 20, SellsDateTime = new DateTime(2021, 11, 3, 7, 30, 0) },
               new Solds { Id = 4, Name = "Кофе", Price = 4,  PriceString = "4.00",  Tax = 20, SellsDateTime = new DateTime(2021, 11, 4, 7, 40, 0) },
               new Solds { Id = 5, Name = "Чипсы",  Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 11, 5, 7, 50, 0) },
               new Solds { Id = 6, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 11, 5, 7, 50, 0) },
               new Solds { Id = 7, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 11, 5, 7, 50, 0) },
               new Solds { Id = 8, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 11, 5, 7, 50, 0) },
               new Solds { Id = 9, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 11, 5, 7, 50, 0) },
               new Solds { Id = 10, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 11, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 12, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 13, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 14, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 15, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 16, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 17, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 18, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 19, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 20, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 21, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 22, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 23, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 24, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 25, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 26, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 27, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 28, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) },
               new Solds { Id = 29, Name = "Чипсы", Price = 5, PriceString = "5.00", Tax = 20, SellsDateTime = new DateTime(2021, 12, 5, 7, 50, 0) }
               );








            modelBuilder.Entity<AutomatMachine>().HasKey(automatMachine => automatMachine.Id);
            modelBuilder.Entity<AutomatMachine>().Property(automatMachine => automatMachine.InventoryId).HasMaxLength(30);
            modelBuilder.Entity<AutomatMachine>().Property(automatMachine => automatMachine.InventoryId).IsRequired();
            modelBuilder.Entity<AutomatMachine>().Property(automatMachine => automatMachine.Name).HasMaxLength(30);
            modelBuilder.Entity<AutomatMachine>().Property(automatMachine => automatMachine.Name).IsRequired();
            modelBuilder.Entity<AutomatMachine>().Property(automatMachine => automatMachine.Address).HasMaxLength(30);
            modelBuilder.Entity<AutomatMachine>().Property(automatMachine => automatMachine.Address).IsRequired();
            modelBuilder.Entity<AutomatMachine>().Property(automatMachine => automatMachine.MaxProductNum).HasMaxLength(30);
            modelBuilder.Entity<AutomatMachine>().Property(automatMachine => automatMachine.MaxProductNum).IsRequired();
            modelBuilder.Entity<AutomatMachine>().Property(automatMachine => automatMachine.CurrentProdNumber).HasMaxLength(10);
            modelBuilder.Entity<AutomatMachine>().Property(automatMachine => automatMachine.CurrentProdNumber).IsRequired();
            modelBuilder.Entity<AutomatMachine>(entity => entity.HasIndex(automatMachine => automatMachine.Id).IsUnique());

            modelBuilder.Entity<AutomatMachine>().HasData(
               new AutomatMachine { Id = 1, Address = "Address1", InventoryId = 10000001, Name = "Автомат воды", CurrentProdNumber = 30, MaxProductNum = 100 },
               new AutomatMachine { Id = 2, Address = "Address2", InventoryId = 10000002, Name = "Автомат снеков", CurrentProdNumber = 44, MaxProductNum = 56 },
               new AutomatMachine { Id = 3, Address = "Address3", InventoryId = 10000003, Name = "Автомат сувениров", CurrentProdNumber = 33, MaxProductNum = 60 },
               new AutomatMachine { Id = 4, Address = "Address4", InventoryId = 10000004, Name = "Автомат пива", CurrentProdNumber = 4, MaxProductNum = 10 },
               new AutomatMachine { Id = 5, Address = "Address5", InventoryId = 10000005, Name = "Автомат пива", CurrentProdNumber = 11, MaxProductNum = 20 }
               );

            modelBuilder.Entity<DiscountCard>().HasKey(discountcard => discountcard.Id);
            modelBuilder.Entity<DiscountCard>().Property(discountcard => discountcard.Discount).HasMaxLength(30);
            modelBuilder.Entity<DiscountCard>().Property(discountcard => discountcard.Discount).IsRequired();
            modelBuilder.Entity<DiscountCard>().Property(discountcard => discountcard.PurchaseSum).HasMaxLength(30);
            modelBuilder.Entity<DiscountCard>().Property(discountcard => discountcard.PurchaseSum).IsRequired();
            modelBuilder.Entity<DiscountCard>(entity => entity.HasIndex(discountcard => discountcard.Id).IsUnique());

            modelBuilder.Entity<DiscountCard>().HasData(
                new DiscountCard { Id = 1, Discount = 6, PurchaseSum = 1560 },
                new DiscountCard { Id = 2, Discount = 10, PurchaseSum = 20000 },
                new DiscountCard { Id = 3, Discount = 8, PurchaseSum = 10000 },
                new DiscountCard { Id = 4, Discount = 7, PurchaseSum = 5005 },
                new DiscountCard { Id = 5, Discount = 3, PurchaseSum = 100 }
                );

            modelBuilder.Entity<ServiceCard>().HasKey(servicecard => servicecard.Id);
            modelBuilder.Entity<ServiceCard>().Property(servicecard => servicecard.Discount).HasMaxLength(30);
            modelBuilder.Entity<ServiceCard>().Property(servicecard => servicecard.Discount).IsRequired();
            modelBuilder.Entity<ServiceCard>(entity => entity.HasIndex(servicecard => servicecard.Id).IsUnique());

            modelBuilder.Entity<ServiceCard>().HasData(
                new ServiceCard { Id = 1, Discount = 1 },
                new ServiceCard { Id = 2, Discount = 2 },
                new ServiceCard { Id = 3, Discount = 3 },
                new ServiceCard { Id = 4, Discount = 4 },
                new ServiceCard { Id = 5, Discount = 5 }
                );

            modelBuilder.Entity<ServiceMan>().HasKey(serviceman => serviceman.Id);
            modelBuilder.Entity<ServiceMan>().Property(serviceman => serviceman.Name).HasMaxLength(30);
            modelBuilder.Entity<ServiceMan>().Property(serviceman => serviceman.Name).IsRequired();
            modelBuilder.Entity<ServiceMan>().Property(serviceman => serviceman.Surname).HasMaxLength(30);
            modelBuilder.Entity<ServiceMan>().Property(serviceman => serviceman.Surname).IsRequired();
            //modelBuilder.Entity<ServiceMan>().Property(serviceman => serviceman.SMCard).HasMaxLength(30);
            // modelBuilder.Entity<ServiceMan>().Property(serviceman => serviceman.SMCard).IsRequired();
            modelBuilder.Entity<ServiceMan>(entity => entity.HasIndex(serviceman => serviceman.Id).IsUnique());

            modelBuilder.Entity<ServiceMan>().HasData(
                new ServiceMan { Id = 1, Name = "Олег", Surname = "Евсеенко" },
                new ServiceMan { Id = 2, Name = "Никита", Surname = "Лебедев" },
                new ServiceMan { Id = 3, Name = "Андрей", Surname = "Воронин" },
                new ServiceMan { Id = 4, Name = "Павел", Surname = "Никифоров" },
                new ServiceMan { Id = 5, Name = "Сергей", Surname = "Иванчук" }
                );




            base.OnModelCreating(modelBuilder);
        }

    }
}
