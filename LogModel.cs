using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TitleOperationsLog
{
	public partial class LogModel : DbContext
	{
		public LogModel()
			: base("name=LogModel")
		{
		}

		public virtual DbSet<Client> Clients { get; set; }
		public virtual DbSet<JobFunction> JobFunctions { get; set; }
		public virtual DbSet<LogEntry> LogEntries { get; set; }
		public virtual DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Client>()
				.HasMany(e => e.LogEntries)
				.WithOptional(e => e.Client)
				.HasForeignKey(e => e.LogClient_ClientID);

			modelBuilder.Entity<JobFunction>()
				.HasMany(e => e.LogEntries)
				.WithOptional(e => e.JobFunction)
				.HasForeignKey(e => e.LogFunction_JobFunctionId);

			modelBuilder.Entity<Product>()
				.HasMany(e => e.LogEntries)
				.WithOptional(e => e.Product)
				.HasForeignKey(e => e.LogProduct_ProductID);
		}
	}
}
