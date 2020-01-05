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
				Emails = new List <Email>()
				{
					new Email {EmailAddress = "teo@gmail.com"},
					new Email {EmailAddress = "teo1@gmail.com"},
					new Email {EmailAddress = "teo2@gmail.com"},
					new Email {EmailAddress = "teo3@gmail.com"}
				}
			};
			var ty = new Person
			{
				Name = "Ty",
				Emails = new List<Email>()
				{
					new Email {EmailAddress = "ty@gmail.com"},
					new Email {EmailAddress = "ty1@gmail.com"},
					new Email {EmailAddress = "ty2@gmail.com"}
					
				}
			};
			var tun = new Person
			{
				Name = "Tun",
				Emails = new List<Email>()
				{
					new Email {EmailAddress = "tun@gmail.com"},
					new Email {EmailAddress = "tun1@gmail.com"},
					new Email {EmailAddress = "tun2@gmail.com"},
					new Email {EmailAddress = "tun3@gmail.com"},
					new Email {EmailAddress = "tun4@gmail.com"},
					new Email {EmailAddress = "tun5@gmail.com"}
				}
			};
			context.People.Add(teo);
			context.People.Add(ty);
			context.People.Add(tun);
			context.SaveChanges();
		}
	}
}
