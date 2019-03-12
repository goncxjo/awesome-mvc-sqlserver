using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace awesomeMVC.Models {
    public class CharactersContext : DbContext {
        public CharactersContext(DbContextOptions<CharactersContext> options) : base(options) {
        }

        public DbSet<Character> Characters { get; set; }
    }

    public class Character {
        public int CharacterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get;set; }
    }
}