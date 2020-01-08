//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataModel
//{
//	// tao quan he nhieu- nhieu, bang trung gian co payload
//	public class Company
//	{
//		public int Id { get; set; }
//		public string Name { get; set; }

//		public virtual ICollection<PersonCompany> People { get; set; }
//	}
//	public class PersonCompany   // phia nhieu
//	{
//		public int Id { get; set; }
//		public string Position { get; set; }  //payload

//		public Person Person { get; set; }
//		public Company Company { get; set; }

//	}
//}
