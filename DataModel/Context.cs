using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DataModel
{
	public class DemoContext : DbContext
	{
		public DemoContext() : base("demo")
		{
			Database.SetInitializer(new DbInitializer());
		}
		public virtual DbSet<Person> People { get; set; }
		//public virtual DbSet<Email> Emails { get; set; }
		//public virtual DbSet<Contact> Contacts { get; set; }
		//public virtual DbSet<Course> Courses { get; set; }
		//public virtual DbSet<Company> Companies { get; set; }
	}
}
