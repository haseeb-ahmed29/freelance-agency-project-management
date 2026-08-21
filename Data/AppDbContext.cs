using Microsoft.EntityFrameworkCore;
using FreelanceAgencyProjectManagement.Models;

namespace FreelanceAgencyProjectManagement.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<ClientProject> ClientProjects => Set<ClientProject>();
}
