using Microsoft.EntityFrameworkCore;

namespace CreditCardWeb.Data;


public class BankDbContext: DbContext
{
    public BankDbContext(DbContextOptions options): base(options) { }

    public DbSet<BankCardDetails> BankCardDetails{ get; set; }

}
