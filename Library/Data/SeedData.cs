using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Data
{
    public class SeedData
    {
        private readonly LibraryDbContext _context;

        public SeedData(LibraryDbContext context) => _context = context;

        public List<Author> Authors()
        {
            return new List<Author> {
                    new Author
                    {
                        FirstName = "Lewis",
                        LastName = "Carroll",
                        Born = new DateTime(1832, 1, 27),
                        Died = new DateTime(1898, 1, 14)
                    },
                    new Author
                    {
                        FirstName = "Leo",
                        LastName = "Tolstoy",
                        Born = new DateTime(1828, 9, 9),
                        Died = new DateTime(1910, 11, 20)
                    },
                    new Author
                    {
                        FirstName = "Fyodor",
                        LastName = "Dostoevsky",
                        Born = new DateTime(1821, 11, 11),
                        Died = new DateTime(1881, 2, 9)
                    },
                    new Author
                    {
                        FirstName = "Jane",
                        LastName = "Austen",
                        Born = new DateTime(1775, 12, 16),
                        Died = new DateTime(1817, 7, 18)
                    }
                };
        }

        public List<Book> Books()
        {
            return new List<Book> {
                    new Book
                    {
                        Name = "Alice's Adventures in Wonderland",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Lewis").Id,
                        Published = new DateTime(1865, 11, 26)
                    },
                    new Book
                    {
                        Name = "Through the Looking-Glass",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Lewis").Id,
                        Published = new DateTime(1871, 12, 27)
                    },
                    new Book
                    {
                        Name = "War and Peace",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Leo").Id,
                        Published = new DateTime(1867, 1, 1)
                    },
                    new Book
                    {
                        Name = "The Brothers Karamazov",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Fyodor").Id,
                        Published = new DateTime(1880, 11, 1)
                    },
                    new Book
                    {
                        Name = "The Idiot",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Fyodor").Id,
                        Published = new DateTime(1869, 1, 1)
                    },
                    new Book
                    {
                        Name = "Demons",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Fyodor").Id,
                        Published = new DateTime(1871, 1, 1)
                    },
                    new Book
                    {
                        Name = "Pride and Prejudice",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Jane").Id,
                        Published = new DateTime(1813, 1, 28)
                    },
                    new Book
                    {
                        Name = "Sense and Sensibility",
                        AuthorId = _context.Authors.FirstOrDefault(x => x.FirstName == "Jane").Id,
                        Published = new DateTime(1811, 1, 1)
                    }
                };
        }
    }
}
