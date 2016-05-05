using System.Data.Entity;
using EFModelsDAL.Models;

namespace EFModelsDAL
{
    public class WordsMemorizingContext : DbContext
    {

        //Constructor sets the name of the connection string to the base class.
        public WordsMemorizingContext():base("name=WordsMemorizingDBConnectionString")
        {
            Database.SetInitializer<WordsMemorizingContext>(new DropCreateDatabaseIfModelChanges<WordsMemorizingContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Word>()
                        .HasOptional(w => w.Context) 
                        .WithRequired(ctx => ctx.Word);

            modelBuilder.Entity<Word>().HasRequired(w => w.LanguageOrigin).WithMany().HasForeignKey(w => w.LanguageIdOrigin).WillCascadeOnDelete(false);

            modelBuilder.Entity<Word>().HasRequired(w => w.LanguageTranslation).WithMany().HasForeignKey(w => w.LanguageIdTranslation).WillCascadeOnDelete(false);

        }

        //Tables to be created by Code First API
        public DbSet<Book> Books { get; set; }

        public DbSet<Context> Contexts { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Unit> Units { get; set; }

        public DbSet<Word> Words { get; set; }

    }
}
