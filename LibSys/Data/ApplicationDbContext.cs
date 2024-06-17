using LibSys.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LibSys.Models.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Text.Json;
using LibSys.Models.Services;
using Microsoft.AspNet.Identity;

namespace LibSys.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDefinition> BookDefinitions { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<LogEntry> LogEntries { get; set; }
        private readonly UserResolverService _userService;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, UserResolverService userService)
            : base(options)
        {
            _userService = userService;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region SeedData

            const int sampleBooksCount = 100;

            BookDefinition[] bookDefinitions = new BookDefinition[]
            {
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Harry Potter i Kamień Filozoficzny",
                    Author = "J.K. Rowling"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Harry Potter i Komnata Tajemnic",
                    Author = "J.K. Rowling"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Harry Potter i więzień Azkabanu",
                    Author = "J.K. Rowling"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Harry Potter i Czara Ognia",
                    Author = "J.K. Rowling"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Harry Potter i Zakon Feniksa",
                    Author = "J.K. Rowling"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Harry Potter i Książę Półkrwi",
                    Author = "J.K. Rowling"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Mężczyźni, którzy nienawidzą kobiet",
                    Author = "Stieg Larsson"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Gra o tron (edycja ilustrowana)",
                    Author = "George R.R. Martin"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Romeo i Julia",
                    Author = "William Shakespeare"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Starcie królów (edycja ilustrowana)",
                    Author = "George R.R. Martin"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Księżniczka z lodu",
                    Author = "Camilla Läckberg"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Nawałnica mieczy: Stal i śnieg",
                    Author = "George R.R. Martin"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Cierpienia młodego Wertera",
                    Author = "Johann Wolfgang von Goethe"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Niezgodna",
                    Author = "Veronica Roth"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Harry Potter i Przeklęte Dziecko",
                    Author = "J.K. Rowling, Jack Thorne"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Balladyna",
                    Author = "Juliusz Słowacki"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Kaznodzieja",
                    Author = "Camilla Läckberg"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Inferno",
                    Author = "Dan Brown"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Wesele",
                    Author = "Stanisław Wyspiański"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Kamieniarz",
                    Author = "Camilla Läckberg"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Człowiek nietoperz",
                    Author = "Jo Nesbø"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Kordian",
                    Author = "Juliusz Słowacki"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Narrenturm",
                    Author = "Andrzej Sapkowski"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Szatan z siódmej klasy",
                    Author = "Kornel Makuszyński"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Ofiara losu",
                    Author = "Camilla Läckberg"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Miasto upadłych aniołów",
                    Author = "Cassandra Clare"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Niemiecki bękart",
                    Author = "Camilla Läckberg"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Chłopi",
                    Author = "Władysław Stanisław Reymont"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Achaja. Tom I",
                    Author = "Andrzej Ziemiański"
                },
                new BookDefinition
                {
                    Id = Guid.NewGuid(),
                    Title = "Dziedzictwo",
                    Author = "Christopher Paolini"
                }
            };

            Reader[] readers = new Reader[]
            {
                new Reader
                {
                    Id = new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"),
                    City = "Poznań",
                    Code = "61-842",
                    Name = "Jan Kowalski",
                    Street = "Za Bramką 12"
                },
                new Reader
                {
                    Id = Guid.NewGuid(),
                    City = "Poznań",
                    Code = "61-111",
                    Name = "Tomasz Rydz",
                    Street = "Garbary 1"
                },
                new Reader
                {
                    Id = Guid.NewGuid(),
                    City = "Poznań",
                    Code = "61-111",
                    Name = "Aleksandra Mechrzycka",
                    Street = "Solna 2"
                },
                new Reader
                {
                    Id = Guid.NewGuid(),
                    City = "Poznań",
                    Code = "61-311",
                    Name = "Jan Nowak",
                    Street = "Wieżowa 3"
                }
            };

            List<Book> sampleBooks = new List<Book>(sampleBooksCount);
            List<Borrowing> borrowings = new List<Borrowing>();
            Random random = new Random();

            for (int i = 0; i < sampleBooksCount; i++)
            {
                BookStatus status = (BookStatus)random.Next(0, 3);
                var book = new Book
                {
                    Id = Guid.NewGuid(),
                    BookDefinitionId = bookDefinitions[random.Next(0, bookDefinitions.Length)].Id,
                    Status = status
                };
                if (status == BookStatus.Borrowed)
                {
                    DateTime borrowDate = DateTime.Today.AddDays(-random.Next(15, 30));
                    DateTime returnDate = borrowDate.AddDays(60);
                    borrowings.Add(
                        new Borrowing
                        {
                            Id = Guid.NewGuid(),
                            BookId = book.Id,
                            ReaderId = readers[random.Next(0, readers.Length)].Id,
                            BorrowDate = borrowDate,
                            ReturnDate = returnDate
                        }
                    );
                }

                sampleBooks.Add(book);
            }



            modelBuilder.Entity<BookDefinition>().HasData(bookDefinitions);
            modelBuilder.Entity<Reader>().HasData(readers);
            modelBuilder.Entity<Book>().HasData(sampleBooks);
            modelBuilder.Entity<Borrowing>().HasData(borrowings);

            #endregion

            #region SeedUser

            IdentityUser user = new IdentityUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                 EmailConfirmed = true,
            };

            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, "AdminP@ssw0rd123!");

            modelBuilder.Entity<IdentityUser>().HasData(user);

            #endregion
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken)
        {
            LogChanges();
            var result = await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            return result;
        }

        private void LogChanges()
        {
            var user = _userService.GetUser();

            var logEntries = new List<LogEntry>();
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is LogEntry || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                {
                    continue;
                }

                var logEntry = new LogEntry()
                {
                    Id = Guid.NewGuid(),
                    EntityName = entry.Metadata.Name.Split(".").Last(),
                    DateTime = DateTime.UtcNow,
                    MethodName = Enum.GetName(typeof(EntityState), entry.State),
                    UserName = user!
                };
                logEntries.Add(logEntry);

                var newValues = new Dictionary<string, string?>();
                var oldValues = new Dictionary<string, string?>();
                var allValues = new Dictionary<string, Dictionary<string, string?>>();
                foreach (var property in entry.Properties)
                {
                    string propertyName = property.Metadata.Name;

                    switch (entry.State)
                    {
                        case EntityState.Added:
                            newValues[propertyName] = property.CurrentValue?.ToString();
                            break;

                        case EntityState.Deleted:
                            oldValues[propertyName] = property.OriginalValue?.ToString();
                            break;

                        case EntityState.Modified:
                            if (property.IsModified)
                            {
                                oldValues[propertyName] = property.OriginalValue?.ToString();
                                newValues[propertyName] = property.CurrentValue?.ToString();
                            }
                            break;
                    }
                }

                if(oldValues.Count > 0)
                {
                    allValues["old"] = oldValues;
                }

                if (newValues.Count > 0)
                {
                    allValues["new"] = newValues;
                }

                var oldJson = JsonSerializer.Serialize(allValues);
                logEntry.EntityChanges = oldJson;
            }

            foreach (var logEntry in logEntries)
            {
                LogEntries.Add(logEntry);
            }
        }
    }
}
