using Library.Models;
using Library.Models.Identity;
using Library.Models.Roles;
using System;
using System.Collections.Generic;

namespace Library.Data
{
    public static class SeedData
    {
        public static List<AuthorModel> Authors()
        {
            return new List<AuthorModel> {
                    new AuthorModel
                    {
                        Id = new Guid("8ff6c943-c1fc-4d71-9e7a-05d474fad866"),
                        FirstName = "Lewis",
                        LastName = "Carroll",
                        Born = new DateTime(1832, 1, 27),
                        Died = new DateTime(1898, 1, 14)
                    },
                    new AuthorModel
                    {
                        Id = new Guid("a78b4e31-d2b2-4ca6-beb8-bade1a65d042"),
                        FirstName = "Leo",
                        LastName = "Tolstoy",
                        Born = new DateTime(1828, 9, 9),
                        Died = new DateTime(1910, 11, 20)
                    },
                    new AuthorModel
                    {
                        Id = new Guid("8b48a5e8-e0a1-474d-afcf-33859dafb42d"),
                        FirstName = "Fyodor",
                        LastName = "Dostoevsky",
                        Born = new DateTime(1821, 11, 11),
                        Died = new DateTime(1881, 2, 9)
                    },
                    new AuthorModel
                    {
                        Id = new Guid("f9f011f8-e216-4ec5-95ea-a64c85d703bb"),
                        FirstName = "Jane",
                        LastName = "Austen",
                        Born = new DateTime(1775, 12, 16),
                        Died = new DateTime(1817, 7, 18)
                    }
                };
        }

        public static List<BookModel> Books()
        {
            return new List<BookModel> {
                    new BookModel
                    {
                        Id = new Guid("cbb71c00-f577-4702-9575-bdcbe209725e"),
                        Name = "Alice's Adventures in Wonderland",
                        AuthorId = new Guid("8ff6c943-c1fc-4d71-9e7a-05d474fad866"),
                        Published = new DateTime(1865, 11, 26)
                    },
                    new BookModel
                    {
                        Id = new Guid("f3f4e9ac-7107-4bdb-95cd-dbd690512704"),
                        Name = "Through the Looking-Glass",
                        AuthorId = new Guid("8ff6c943-c1fc-4d71-9e7a-05d474fad866"),
                        Published = new DateTime(1871, 12, 27)
                    },
                    new BookModel
                    {
                        Id = new Guid("a3e45335-5f9e-421e-b889-46e6cfea026d"),
                        Name = "War and Peace",
                        AuthorId = new Guid("a78b4e31-d2b2-4ca6-beb8-bade1a65d042"),
                        Published = new DateTime(1867, 1, 1)
                    },
                    new BookModel
                    {
                        Id = new Guid("5af127f6-4468-4599-aaba-49c2c2e15209"),
                        Name = "The Brothers Karamazov",
                        AuthorId = new Guid("8b48a5e8-e0a1-474d-afcf-33859dafb42d"),
                        Published = new DateTime(1880, 11, 1)
                    },
                    new BookModel
                    {
                        Id = new Guid("1e9ed09e-4b07-4a27-a2cd-64be73a3e85b"),
                        Name = "The Idiot",
                        AuthorId = new Guid("8b48a5e8-e0a1-474d-afcf-33859dafb42d"),
                        Published = new DateTime(1869, 1, 1)
                    },
                    new BookModel
                    {
                        Id = new Guid("e22024b0-5d64-441b-9ce6-33df0d9f6aae"),
                        Name = "Demons",
                        AuthorId = new Guid("8b48a5e8-e0a1-474d-afcf-33859dafb42d"),
                        Published = new DateTime(1871, 1, 1)
                    },
                    new BookModel
                    {
                        Id = new Guid("aab543ba-a513-49a1-8882-652793c09739"),
                        Name = "Pride and Prejudice",
                        AuthorId = new Guid("f9f011f8-e216-4ec5-95ea-a64c85d703bb"),
                        Published = new DateTime(1813, 1, 28)
                    },
                    new BookModel
                    {
                        Id = new Guid("9030cc63-416b-4df0-a2b5-465f836f3cc5"),
                        Name = "Sense and Sensibility",
                        AuthorId = new Guid("f9f011f8-e216-4ec5-95ea-a64c85d703bb"),
                        Published = new DateTime(1811, 1, 1)
                    }
                };
        }

        public static List<UserModel> Users()
        {
            return new List<UserModel>()
            {
                new UserModel
                {
                    Id = new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                    UserName = "Salt",
                    Email = "salt@test.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEE4IWmCoxpOmWx7jusiQx71D2711RJuEhKQWmETOir1u+nHUIJLuY2IDNxQmNItsLQ=="
                },
                new UserModel
                {
                    Id = new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                    UserName = "Pepper",
                    Email = "pepper@test.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEE4IWmCoxpOmWx7jusiQx71D2711RJuEhKQWmETOir1u+nHUIJLuY2IDNxQmNItsLQ=="
                },
                new UserModel
                {
                    Id = new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                    UserName = "Test",
                    Email = "test@test.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEE4IWmCoxpOmWx7jusiQx71D2711RJuEhKQWmETOir1u+nHUIJLuY2IDNxQmNItsLQ=="
                },
                new UserModel {
                    Id = new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                    UserName = "Admin",
                    Email = "admin@test.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEE4IWmCoxpOmWx7jusiQx71D2711RJuEhKQWmETOir1u+nHUIJLuY2IDNxQmNItsLQ=="
                }
            };
        }

        public static List<RoleModel> Roles()
        {
            return new List<RoleModel>()
            {
                new RoleModel {
                    Id = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                    Name = Constants.Roles.Admin,
                    Description = "Role for admin"
                },
                new RoleModel {
                    Id = new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                    Name = Constants.Roles.User,
                    Description = "Role for user"
                },
                new RoleModel {
                    Id = new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                    Name = Constants.Roles.Guest,
                    Description = "Role for guest"
                }
            };
        }

        public static List<PermissionModel> Permissions()
        {
            return new List<PermissionModel>()
            {
                new PermissionModel {
                    Id = new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd"),
                    Name = Constants.Permissions.Authors.Search,
                    Description = "Ability to GET author."
                },
                new PermissionModel {
                    Id = new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f"),
                    Name = Constants.Permissions.Authors.Add,
                    Description = "Ability to POST author."
                },
                new PermissionModel {
                    Id = new Guid("c90c27d2-d947-4f4b-884b-a4305083964e"),
                    Name = Constants.Permissions.Authors.Delete,
                    Description = "Ability to DELETE author."
                },
                new PermissionModel {
                    Id = new Guid("5dfdf747-a9c8-4186-9816-053fe86b43a0"),
                    Name = Constants.Permissions.Authors.Edit,
                    Description = "Ability to PUT author."
                },
                new PermissionModel {
                    Id = new Guid("50bbb8c8-d49c-4da1-8690-35f555334731"),
                    Name = Constants.Permissions.Books.Search,
                    Description = "Ability to GET books."
                },
                new PermissionModel {
                    Id = new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5"),
                    Name = Constants.Permissions.Books.Add,
                    Description = "Ability to POST book."
                },
                new PermissionModel {
                    Id = new Guid("2ac2829b-2c9b-4626-a47c-73d3dd46a6e5"),
                    Name = Constants.Permissions.Books.Delete,
                    Description = "Ability to DELTE book."
                },
                new PermissionModel {
                    Id = new Guid("27055641-e188-4e0f-afae-4dfd60d1b3fa"),
                    Name = Constants.Permissions.Books.Edit,
                    Description = "Ability to PUT book."
                }
            };
        }
    }
}
