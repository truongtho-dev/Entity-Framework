using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataModel
{
    public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Email> Emails { get; set; }
		[NotMapped]
		public string EmailsDisplay {
			get
			{
				string display = null;
				if (Emails != null)
				{
					foreach (var e in Emails)
					{
						display += e.EmailAddress + Environment.NewLine;
					}
				}
				return display;
			}
		}
	}

	public class Email
	{
		public int Id { get; set; }
		public string EmailAddress { get; set; }

		public int PersonId { get; set; } // FK = Nav property + Id of Person
		public Person Person { get; set; }
	}
	public class DemoContext: DbContext
	{
		public DemoContext(): base("demo") {
			Database.SetInitializer(new DbInitializer());
		}		
		public virtual DbSet<Person> People { get; set; }
		public virtual DbSet<Email> Emails { get; set; }
	}
	
}
