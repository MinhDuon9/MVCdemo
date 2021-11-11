using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );

                // Person
                if (context.Person.Any())
                {
                    return;
                }
                context.Person.AddRange(
                    new Person
                    {
                        PersonName = "Nguyễn A"
                    },

                    new Person
                    {
                        PersonName = "Nguyễn B"
                    },

                    new Person
                    {
                        PersonName = "Nguyễn C"
                    },

                    new Person
                    {
                        PersonName = "Nguyễn D"
                    },

                    new Person
                    {
                        PersonName = "Nguyễn E"
                    }
                );

                // Student
                if (context.Student.Any())
                {
                    return;
                }
                context.Student.AddRange(
                    new Student
                    {
                        StudentName = "Nguyễn A",
                        Address = "Hà Nội"
                    },

                    new Student
                    {
                        StudentName = "Nguyễn B",
                        Address = "Hà Nội"
                    },

                    new Student
                    {
                        StudentName = "Nguyễn C",
                        Address = "Hà Nội"
                    },

                    new Student
                    {
                        StudentName = "Nguyễn D",
                        Address = "Hà Nội"
                    },

                    new Student
                    {
                        StudentName = "Nguyễn E",
                        Address = "Hà Nội"
                    }
                );

                // Employee
                if (context.Employee.Any())
                {
                    return;
                }
                context.Employee.AddRange(
                    new Employee
                    {
                        EmployeeName = "Nguyễn A",
                        PhoneNumber = "0123456789"
                    },

                    new Employee
                    {
                        EmployeeName = "Nguyễn B",
                        PhoneNumber = "0123456789"
                    },

                    new Employee
                    {
                        EmployeeName = "Nguyễn C",
                        PhoneNumber = "0123456789"
                    },

                    new Employee
                    {
                        EmployeeName = "Nguyễn D",
                        PhoneNumber = "0123456789"
                    },

                    new Employee
                    {
                        EmployeeName = "Nguyễn E",
                        PhoneNumber = "0123456789"
                    }
                );

                // Product
                if (context.Product.Any())
                {
                    return;
                }
                context.Product.AddRange(
                    new Product
                    {
                        ProductName = "Bánh",
                        UnitPrice = 9,
                        Quantity = 10
                    },

                    new Product
                    {
                        ProductName = "Kẹo",
                        UnitPrice = 9,
                        Quantity = 10
                    },

                    new Product
                    {
                        ProductName = "Mì",
                        UnitPrice = 9,
                        Quantity = 10
                    },

                    new Product
                    {
                        ProductName = "Quần",
                        UnitPrice = 9,
                        Quantity = 10
                    },

                    new Product
                    {
                        ProductName = "Áo",
                        UnitPrice = 9,
                        Quantity = 10
                    }
                );

                context.SaveChanges();
            }
        }
    }
}