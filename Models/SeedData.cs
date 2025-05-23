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
                        },
                        new Customer { Name = "Bruce Wayne", CPF = "111.222.333-44", BirthDate = new DateTime(1975, 2, 19), Address = "100 Gotham St", Phone = "555-0001", Email = "bruce@wayneenterprises.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Clark Kent", CPF = "222.333.444-55", BirthDate = new DateTime(1980, 6, 18), Address = "200 Smallville Rd", Phone = "555-0002", Email = "clark@dailyplanet.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Barry Allen", CPF = "333.444.555-66", BirthDate = new DateTime(1990, 1, 5), Address = "300 Central City Blvd", Phone = "555-0003", Email = "barry@ccpd.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Diana Prince", CPF = "444.555.666-77", BirthDate = new DateTime(1988, 3, 10), Address = "321 Maple St", Phone = "555-4321", Email = "diana@gmail.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Hal Jordan", CPF = "555.666.777-88", BirthDate = new DateTime(1985, 7, 24), Address = "500 Coast City Ave", Phone = "555-0004", Email = "hal@airforce.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Arthur Curry", CPF = "666.777.888-99", BirthDate = new DateTime(1984, 8, 15), Address = "400 Atlantis Ln", Phone = "555-0005", Email = "arthur@sea.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Victor Stone", CPF = "777.888.999-00", BirthDate = new DateTime(1992, 9, 20), Address = "150 Cyborg St", Phone = "555-0006", Email = "victor@starlabs.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Oliver Queen", CPF = "888.999.000-11", BirthDate = new DateTime(1983, 12, 30), Address = "99 Star City Way", Phone = "555-0007", Email = "oliver@qc.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Kara Danvers", CPF = "999.000.111-22", BirthDate = new DateTime(1995, 5, 7), Address = "22 National City Ave", Phone = "555-0008", Email = "kara@catco.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Lex Luthor", CPF = "000.111.222-33", BirthDate = new DateTime(1978, 4, 9), Address = "12 Metropolis Rd", Phone = "555-0009", Email = "lex@lexcorp.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Selina Kyle", CPF = "111.222.333-00", BirthDate = new DateTime(1987, 2, 14), Address = "77 Gotham Heights", Phone = "555-0010", Email = "selina@catmail.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Harleen Quinzel", CPF = "222.333.444-11", BirthDate = new DateTime(1986, 10, 12), Address = "55 Arkham Ave", Phone = "555-0011", Email = "harleen@dc.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Pamela Isley", CPF = "333.444.555-22", BirthDate = new DateTime(1985, 6, 5), Address = "44 Gotham Gardens", Phone = "555-0012", Email = "pamela@eco.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Edward Nigma", CPF = "444.555.666-33", BirthDate = new DateTime(1982, 11, 11), Address = "33 Riddle Rd", Phone = "555-0013", Email = "edward@riddles.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Slade Wilson", CPF = "555.666.777-44", BirthDate = new DateTime(1979, 9, 9), Address = "22 Assassin St", Phone = "555-0014", Email = "slade@merc.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "John Constantine", CPF = "666.777.888-55", BirthDate = new DateTime(1981, 5, 13), Address = "13 Occult Blvd", Phone = "555-0015", Email = "john@hellblazer.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Zatanna Zatara", CPF = "777.888.999-66", BirthDate = new DateTime(1990, 7, 30), Address = "8 Magic St", Phone = "555-0016", Email = "zatanna@stage.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Billy Batson", CPF = "888.999.000-77", BirthDate = new DateTime(2000, 12, 25), Address = "10 Shazam Ln", Phone = "555-0017", Email = "billy@shazam.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Jon Kent", CPF = "999.000.111-88", BirthDate = new DateTime(2005, 4, 1), Address = "20 Smallville Jr Rd", Phone = "555-0018", Email = "jon@legacy.com", CreatedAt = DateTime.Now },
                        new Customer { Name = "Cassie Sandsmark", CPF = "000.111.222-99", BirthDate = new DateTime(1998, 1, 17), Address = "3 Wonder Way", Phone = "555-0019", Email = "cassie@amazon.com", CreatedAt = DateTime.Now }
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
                        },
                        new Supplier
                        {
                            Name = "Supplier Five",
                            Address = "321 Elm St",
                            Phone = "555-0005",
                            Email = "contact@supplierfive.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-05",
                            CompanyName = "Supplier Five Ltda",
                            TradeName = "Supplier Five"
                        },
                        new Supplier
                        {
                            Name = "Supplier Six",
                            Address = "654 Spruce St",
                            Phone = "555-0006",
                            Email = "contact@suppliersix.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-06",
                            CompanyName = "Supplier Six Ltda",
                            TradeName = "Supplier Six"
                        },
                        new Supplier
                        {
                            Name = "Supplier Seven",
                            Address = "111 Cedar St",
                            Phone = "555-0007",
                            Email = "contact@supplierseven.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-07",
                            CompanyName = "Supplier Seven Ltda",
                            TradeName = "Supplier Seven"
                        },
                        new Supplier
                        {
                            Name = "Supplier Eight",
                            Address = "222 Redwood St",
                            Phone = "555-0008",
                            Email = "contact@suppliereight.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-08",
                            CompanyName = "Supplier Eight Ltda",
                            TradeName = "Supplier Eight"
                        },
                        new Supplier
                        {
                            Name = "Supplier Nine",
                            Address = "333 Cypress St",
                            Phone = "555-0009",
                            Email = "contact@suppliernine.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-09",
                            CompanyName = "Supplier Nine Ltda",
                            TradeName = "Supplier Nine"
                        },
                        new Supplier
                        {
                            Name = "Supplier Ten",
                            Address = "444 Dogwood St",
                            Phone = "555-0010",
                            Email = "contact@supplierten.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-10",
                            CompanyName = "Supplier Ten Ltda",
                            TradeName = "Supplier Ten"
                        },
                        new Supplier
                        {
                            Name = "Supplier Eleven",
                            Address = "555 Magnolia St",
                            Phone = "555-0011",
                            Email = "contact@suppliereleven.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-11",
                            CompanyName = "Supplier Eleven Ltda",
                            TradeName = "Supplier Eleven"
                        },
                        new Supplier
                        {
                            Name = "Supplier Twelve",
                            Address = "666 Ash St",
                            Phone = "555-0012",
                            Email = "contact@suppliertwelve.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-12",
                            CompanyName = "Supplier Twelve Ltda",
                            TradeName = "Supplier Twelve"
                        },
                        new Supplier
                        {
                            Name = "Supplier Thirteen",
                            Address = "777 Poplar St",
                            Phone = "555-0013",
                            Email = "contact@supplierthirteen.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-13",
                            CompanyName = "Supplier Thirteen Ltda",
                            TradeName = "Supplier Thirteen"
                        },
                        new Supplier
                        {
                            Name = "Supplier Fourteen",
                            Address = "888 Fir St",
                            Phone = "555-0014",
                            Email = "contact@supplierfourteen.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-14",
                            CompanyName = "Supplier Fourteen Ltda",
                            TradeName = "Supplier Fourteen"
                        },
                        new Supplier
                        {
                            Name = "Supplier Fifteen",
                            Address = "999 Beech St",
                            Phone = "555-0015",
                            Email = "contact@supplierfifteen.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-15",
                            CompanyName = "Supplier Fifteen Ltda",
                            TradeName = "Supplier Fifteen"
                        },
                        new Supplier
                        {
                            Name = "Supplier Sixteen",
                            Address = "1010 Chestnut St",
                            Phone = "555-0016",
                            Email = "contact@suppliersixteen.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-16",
                            CompanyName = "Supplier Sixteen Ltda",
                            TradeName = "Supplier Sixteen"
                        },
                        new Supplier
                        {
                            Name = "Supplier Seventeen",
                            Address = "1111 Walnut St",
                            Phone = "555-0017",
                            Email = "contact@supplierseventeen.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-17",
                            CompanyName = "Supplier Seventeen Ltda",
                            TradeName = "Supplier Seventeen"
                        },
                        new Supplier
                        {
                            Name = "Supplier Eighteen",
                            Address = "1212 Hickory St",
                            Phone = "555-0018",
                            Email = "contact@suppliereighteen.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-18",
                            CompanyName = "Supplier Eighteen Ltda",
                            TradeName = "Supplier Eighteen"
                        },
                        new Supplier
                        {
                            Name = "Supplier Nineteen",
                            Address = "1313 Willow St",
                            Phone = "555-0019",
                            Email = "contact@suppliernineteen.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-19",
                            CompanyName = "Supplier Nineteen Ltda",
                            TradeName = "Supplier Nineteen"
                        },
                        new Supplier
                        {
                            Name = "Supplier Twenty",
                            Address = "1414 Palm St",
                            Phone = "555-0020",
                            Email = "contact@suppliertwenty.com",
                            CreatedAt = DateTime.Now,
                            CNPJ = "11.111.111/0001-20",
                            CompanyName = "Supplier Twenty Ltda",
                            TradeName = "Supplier Twenty"
                        }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}

