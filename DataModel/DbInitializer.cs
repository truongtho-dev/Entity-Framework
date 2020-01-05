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
			var teo = new Person { Name = "Teo"};
			var ty = new Person { Name = "Ty"};
			var tun = new Person { Name = "Tun"};
			context.People.Add(teo);
			context.People.Add(ty);
			context.People.Add(tun);
			context.SaveChanges();
		}
	}
}
