using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
	// tao quan he 1-nhieu phu thuoc (ben nhieu)
	public class Email
	{
		public int Id { get; set; }
		public string EmailAddress { get; set; }
		public int PersonId { get; set; } // FK = Nav property + Id of Person

		public Person Person { get; set; }
	}
}
