using Microsoft.EntityFrameworkCore;
using finance_web_domain.Entities;

namespace finance_web_infra;

public class FinanceDbContext : DbContext
{

    public DbSet<PlanoConta> PlanoConta { get; set; }

    public DbSet<Transacao> Transacao { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=finance-web;Trusted_Connection=True;");

}
