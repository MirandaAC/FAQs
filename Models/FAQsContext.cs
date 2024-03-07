using Microsoft.EntityFrameworkCore;

namespace FAQs.Models
{
    public class FAQsContext : DbContext
    {
        public FAQsContext(DbContextOptions<FAQsContext> options) 
            : base(options) 
        { }
   

        public DbSet<FAQ> FAQs { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Topic> Topics { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = "aspnet", Name = "ASP.NET" },
                new Topic { TopicId = "csharp", Name = "C#"},
                new Topic { TopicId = "javascript", Name = "JavaScript"}
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "hist", Name = "History" },
                new Category { CategoryId = "gen", Name = "General" }
                );

            modelBuilder.Entity<FAQ>().HasData(
                new FAQ { 
                    FAQId = 1,
                    CategoryId = "hist",
                    TopicId = "aspnet",
                    Question = "When did ASP.NET come out?",
                    Answer = "January 5, 2002"
                },
                new FAQ
                {
                    FAQId = 2,
                    CategoryId = "hist",
                    TopicId = "csharp",
                    Question = "When did C# come out?",
                    Answer = "2000"
                },
                new FAQ
                {
                    FAQId = 3,
                    CategoryId = "hist",
                    TopicId = "javascript",
                    Question = "When did Javascript come out?",
                    Answer = "1995"
                },
                new FAQ
                {
                    FAQId = 4,
                    CategoryId = "gen",
                    TopicId = "aspnet",
                    Question = "What is ASP.NET best used for?",
                    Answer = "Building great websites and web applications using HTML, CSS, and JavaScript. You can also create Web APIs and use real-time technologies like Web Sockets."
                },
                 new FAQ
                 {
                     FAQId = 5,
                     CategoryId = "gen",
                     TopicId = "csharp",
                     Question = "What is C# used for?",
                     Answer = "To create a number of different programs and applications: mobile apps, desktop apps, cloud-based services, websites, enterprise software and games"
                 },
                 new FAQ
                 {
                     FAQId = 6,
                     CategoryId = "gen",
                     TopicId = "javascript",
                     Question = "What is Javascript used for?",
                     Answer = "Used to develop web pages. Developed in Netscape, JS allows developers to create a dynamic and interactive web page to interact with visitors and execute complex actions. It also enables users to load content into a document without reloading the entire page"
                 }
                );
        }
    }
}
