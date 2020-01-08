using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataModel
{
	public class DbInitializer : DropCreateDatabaseIfModelChanges<DemoContext>
	{
		protected override void Seed(DemoContext context)
		{
			var teo = new Person
			{
				Name = "Teo",
				Emails =
				new List<Email>()
					{
						new Email
							{ EmailAddress = "teo@gmail.com", PersonId = 1 },
						new Email
							{ EmailAddress = "teo1@gmail.com", PersonId = 1 },
						new Email
							{ EmailAddress = "teo2@gmail.com", PersonId = 1 },
						new Email
							{ EmailAddress = "teo3@gmail.com", PersonId = 1 }
					}
				//Companies = new List<PersonCompany>(),
				//Courses = new List<Course>()
			};
			var ty = new Person
			{
				Name = "Ty",
				Emails =
				new List<Email>()
					{
						new Email
							{ EmailAddress = "ty@gmail.com", PersonId = 2 },
						new Email
							{ EmailAddress = "ty1@gmail.com", PersonId = 2 },
						new Email
							{ EmailAddress = "ty2@gmail.com", PersonId = 2 }
					}
				//Companies = new List<PersonCompany>(),
				//Courses = new List<Course>()
			};

			var tun = new Person
			{
				Name = "Tun",
				Emails =
				new List<Email>()
					{
						new Email
							{ EmailAddress = "tun@gmail.com", PersonId = 3 },
						new Email
							{ EmailAddress = "tun1@gmail.com", PersonId = 3 },
						new Email
							{ EmailAddress = "tun2@gmail.com", PersonId = 3 },
						new Email
							{ EmailAddress = "tun3@gmail.com", PersonId = 3 },
						new Email
							{ EmailAddress= "tun4@gmail.com", PersonId = 3 },
						new Email
							{ EmailAddress = "tun5@gmail.com", PersonId = 3 }
					}
				//Companies = new List<PersonCompany>(),
				//Courses = new List<Course>()
			};


			//var ibm = new Company() { Name = "IBM", People = new List<PersonCompany>() };
			//var oracle = new Company() { Name = "Oracle", People = new List<PersonCompany>() };
			//var nextfix = new Company() { Name = "Nexfix", People = new List<PersonCompany>() };
			//var omo = new Company() { Name = "OMO", People = new List<PersonCompany>() };

			//// 
			//teo.Companies.Add(new PersonCompany() { Company = ibm, Position = "Senior" });
			//teo.Companies.Add(new PersonCompany() { Company = omo, Position = "Junior" });
			////
			//tun.Companies.Add(new PersonCompany() { Company = ibm, Position = "Junior" });
			//tun.Companies.Add(new PersonCompany() { Company = nextfix, Position = "Junior" });
			//tun.Companies.Add(new PersonCompany() { Company = oracle, Position = "Junior" });
			////
			//ty.Companies.Add(new PersonCompany() { Company = oracle, Position = "Junior" });
			//tun.Companies.Add(new PersonCompany() { Company = nextfix, Position = "Leader" });
			//tun.Companies.Add(new PersonCompany() { Company = omo, Position = "Senior" });
			//tun.Companies.Add(new PersonCompany() { Company = ibm, Position = "Fresher" });
			////
			//var tech = new Course() { Name = "Tech" };
			//var marketting = new Course() { Name = "Marketting" };
			//var sale = new Course() { Name = "Sale" };
			//var logic = new Course() { Name = "Logic" };
			////
			//teo.Courses.Add(tech);
			//teo.Courses.Add(sale);
			//tun.Courses.Add(tech);
			//tun.Courses.Add(sale);
			//tun.Courses.Add(logic);
			//ty.Courses.Add(logic);
			////
			//context.Companies.Add(ibm);
			//context.Companies.Add(omo);
			//context.Companies.Add(oracle);
			//context.Companies.Add(nextfix);
			////
			//context.Courses.Add(tech);
			//context.Courses.Add(sale);
			//context.Courses.Add(logic);
			//context.Courses.Add(marketting);
			//
			context.People.Add(teo);
			context.People.Add(ty);
			context.People.Add(tun);
			//
			context.SaveChanges();
		}
	}
}
