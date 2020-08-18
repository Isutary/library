using Library.Infrastructure;
using Library.Models;
using Library.Models.Identity;
using Library.Models.Roles;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Data
{
    public class SeedData
    {
        private readonly LibraryDbContext _context;
        private readonly UserManager<UserModel> _userManager;

        public SeedData(LibraryDbContext context, UserManager<UserModel> userManager)
            => (_context, _userManager) = (context, userManager);

        public List<AuthorModel> Authors()
        {
            return new List<AuthorModel> {
                    new AuthorModel
                    {
                        FirstName = "Lewis",
                        LastName = "Carroll",
                        Born = new DateTime(1832, 1, 27),
                        Died = new DateTime(1898, 1, 14)
                    },
                    new AuthorModel
                    {
                        FirstName = "Leo",
                        LastName = "Tolstoy",
                        Born = new DateTime(1828, 9, 9),
                        Died = new DateTime(1910, 11, 20)
                    },
                    new AuthorModel
                    {
                        FirstName = "Fyodor",
                        LastName = "Dostoevsky",
                        Born = new DateTime(1821, 11, 11),
                        Died = new DateTime(1881, 2, 9)
                    },
                    new AuthorModel
                    {
                        FirstName = "Jane",
                        LastName = "Austen",
                        Born = new DateTime(1775, 12, 16),
                        Died = new DateTime(1817, 7, 18)
                    }
                };
        }

        public List<BookModel> Books()
        {
            return new List<BookModel> {
                    new BookModel
                    {
                        Name = "Alice's Adventures in Wonderland",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Lewis").Id,
                        Published = new DateTime(1865, 11, 26)
                    },
                    new BookModel
                    {
                        Name = "Through the Looking-Glass",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Lewis").Id,
                        Published = new DateTime(1871, 12, 27)
                    },
                    new BookModel
                    {
                        Name = "War and Peace",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Leo").Id,
                        Published = new DateTime(1867, 1, 1)
                    },
                    new BookModel
                    {
                        Name = "The Brothers Karamazov",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Fyodor").Id,
                        Published = new DateTime(1880, 11, 1)
                    },
                    new BookModel
                    {
                        Name = "The Idiot",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Fyodor").Id,
                        Published = new DateTime(1869, 1, 1)
                    },
                    new BookModel
                    {
                        Name = "Demons",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Fyodor").Id,
                        Published = new DateTime(1871, 1, 1)
                    },
                    new BookModel
                    {
                        Name = "Pride and Prejudice",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Jane").Id,
                        Published = new DateTime(1813, 1, 28)
                    },
                    new BookModel
                    {
                        Name = "Sense and Sensibility",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Jane").Id,
                        Published = new DateTime(1811, 1, 1)
                    }
                };
        }

        public List<UserModel> Users()
        {
            return new List<UserModel>()
            {
                new UserModel
                {
                    UserName = "Salt",
                    Email = "salt@test.com"
                },
                new UserModel
                {
                    UserName = "Pepper",
                    Email = "pepper@test.com"
                },
                new UserModel
                {
                    UserName = "Test",
                    Email = "test@test.com"
                },
                new UserModel {
                    UserName = "Admin",
                    Email = "admin@test.com"
                }
            };
        }

        public List<RoleModel> Roles()
        {
            return new List<RoleModel>()
            {
                new RoleModel(Constants.Roles.Admin, "Role for Admin"),
                new RoleModel(Constants.Roles.User, "Role for User"),
                new RoleModel(Constants.Roles.Guest, "Role for Guest")
            };
        }

        public List<PermissionModel> Permissions()
        {
            return new List<PermissionModel>()
            {
                new PermissionModel { Name = Constants.Permissions.Books.Search, Description = "Ability to see books"},
                new PermissionModel { Name = Constants.Permissions.Books.Add, Description = "Ability to add new book"},
                new PermissionModel { Name = Constants.Permissions.Books.Delete, Description = "Ability to delete a book"},
                new PermissionModel { Name = Constants.Permissions.Books.Edit, Description = "Ability to edit a book"},
                new PermissionModel { Name = Constants.Permissions.Authors.Search, Description = "Ability to see authors"},
                new PermissionModel { Name = Constants.Permissions.Authors.Add, Description = "Ability to add new author"},
                new PermissionModel { Name = Constants.Permissions.Authors.Delete, Description = "Ability to delete an author"},
                new PermissionModel { Name = Constants.Permissions.Authors.Edit, Description = "Ability to edit an author"}
            };
        }
    }
}
