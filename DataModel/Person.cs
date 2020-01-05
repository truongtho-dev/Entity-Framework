using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DataModel
{
    public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Email> Emails { get; set; }
		

	}

	public class Email
	{
		public int Id { get; set; }
		public string EmailAddress { get; set; }

		public int PersonId { get; set; } // FK = Nav property + ID of person
		public Person Person { get; set; }
	}
	public class DemoContext: DbContext
	{
		public DemoContext(): base("demo") {
			Database.SetInitializer(new DbInitializer());
		}
		
		public virtual DbSet<Person> People { get; set; }
	}
	
}
