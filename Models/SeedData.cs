using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcClient.Data;
using MvcClient.Models;
using System;
using System.Linq;

namespace MvcClient.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcClientContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcClientContext>>()))
            {
                // Seed Customers
                if (!context.Customer.Any())
                {
                    context.Customer.AddRange(
                        new Customer
                        {
                            Name = "Alice Smith",
                            CPF = "123.456.789-00",
                            BirthDate = new DateTime(1990, 5, 1),
                            Address = "123 Main St",
                            Phone = "555-1234",
                            Email = "alice@example.com",
                            CreatedAt = DateTime.Now
                        },
                        new Customer
                        {
                            Name = "Bob Johnson",
                            CPF = "987.654.321-00",
                            BirthDate = new DateTime(1985, 8, 15),
                            Address = "456 Oak Ave",
                            Phone = "555-5678",
                            Email = "bob@example.com",
                            CreatedAt = DateTime.Now
                        },
                        new Customer
                        {
                            Name = "Charlie Brown",
                            CPF = "111.222.333-44",
                            BirthDate = new DateTime(1992, 12, 20),
                            Address = "789 Pine Rd",
                            Phone = "555-8765",
                            Email = "chalie@gmail.com",
                            CreatedAt = DateTime.Now
                        },
                        new Customer
                        {
                            Name = "Diana Prince",
                            CPF = "444.555.666-77",
                            BirthDate = new DateTime(1988, 3, 10),
                            Address = "321 Maple St",
                            Phone = "555-4321",
                            Email = "diana@gmail.com",
                            CreatedAt = DateTime.Now
                        }
                    );
                }

                // Seed Suppliers
                if (!context.Supplier.Any())
                {
                    context.Supplier.AddRange(
                        new Supplier
                        {
                            Name = "Supplier One",
                            Address = "789 Pine Rd",
                            Phone = "555-1111",
                            Email = "contact@supplierone.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "12.345.678/0001-90",
                            CompanyName = "Supplier One Ltda",
                            TradeName = "Supplier One"
                        },
                        new Supplier
                        {
                            Name = "Supplier Two",
                            Address = "321 Maple St",
                            Phone = "555-2222",
                            Email = "contact@suppliertwo.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "98.765.432/0001-01",
                            CompanyName = "Supplier Two Ltda",
                            TradeName = "Supplier Two"
                        },
                        new Supplier
                        {
                            Name = "Supplier Three",
                            Address = "654 Cedar St",
                            Phone = "555-3333",
                            Email = "contact@supplierthree.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.222.333/0001-02",
                            CompanyName = "Supplier Three Ltda",
                            TradeName = "Supplier Three"
                        },
                        new Supplier
                        {
                            Name = "Supplier Four",
                            Address = "987 Birch St",
                            Phone = "555-4444",
                            Email = "contact@supplierfour.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "22.333.444/0001-03",
                            CompanyName = "Supplier Four Ltda",
                            TradeName = "Supplier Four"
                        }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}

