using Microsoft.EntityFrameworkCore;
using FormForPF.Models; 

namespace FormForPF.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Добавляем коллекцию для работы с таблицей Contacts в БД
        public DbSet<ContactForm> Contacts { get; set; }
    }
}