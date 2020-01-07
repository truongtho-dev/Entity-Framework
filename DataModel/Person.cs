using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataModel
{
    public class Person
	{
		[Required, Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Name { get; set; }

		public ICollection<Email> Emails { get; set; }
		public virtual ICollection<Course> Course { get; set; }
		public virtual ICollection<PersonCompany> Companies { get; set; }
		public Contact Contact { get; set; }
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
	 
	// tao quan he 1-nhieu phu thuoc (ben nhieu)
	public class Email
	{
		public int Id { get; set; }
		public string EmailAddress { get; set; }
		public int PersonId { get; set; } // FK = Nav property + Id of Person

		public Person Person { get; set; }
	}

	//tao quan he 1-1. o hai class phai co nav pro
	public class Contact
	{
		[ForeignKey("Person")] //vua PK-vua FK
		public int Id { get; set; }
		public string HomePhone { get; set; }
		
		public Person Person { get; set; }
	}
	
	// tao quan he nhieu - nhieu, bang trung gian khong co payload
	public class Course
	{
		public int Id { get; set; }
		public string CourseName { get; set; }

		public virtual ICollection<Person> Person { get; set; }
	}

	// tao quan he nhieu- nhieu, bang trung gian co payload
	public class Company
	{
		public int Id { get; set; }
		public string CompanyName { get; set; }

		public virtual ICollection<Person> People { get; set; }	
	}
	public class PersonCompany   // phia nhieu
	{
		public int Id { get; set; }
		public string Position { get; set; }  //payload

		public Person Person { get; set; }
		public Company Company { get; set; }

	}
	
	public class DemoContext: DbContext
	{
		public DemoContext(): base("demo") {
			Database.SetInitializer(new DbInitializer());
		}	
		public virtual DbSet<Person> People { get; set; }
		public virtual DbSet<Email> Emails { get; set; }
		public virtual DbSet<Contact> Contacts { get; set; }
		public virtual DbSet<Course> Courses { get; set; }
		public virtual DbSet<Course> Companies { get; set; }
	}
	
}
