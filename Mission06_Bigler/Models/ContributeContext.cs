using Microsoft.EntityFrameworkCore;

namespace Mission06_Bigler.Models
{
	public class ContributeContext : DbContext
	{
		public ContributeContext(DbContextOptions<ContributeContext> options) : base (options) 
		{
		}

		public DbSet<Contribution> Contributions { get; set; }
	}
}
