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
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<Email> Emails { get; set; }
		//public virtual ICollection<Course> Courses { get; set; }
		//public virtual ICollection<PersonCompany> Companies { get; set; }
		//public Contact Contact { get; set; }
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
}
