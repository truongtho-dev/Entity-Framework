using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace PersonForm
{
	public partial class ManagePerson : Form
	{
		public ManagePerson()
		{
			InitializeComponent();
		}

		#region Main Form
		private void ManagePerson_Load(object sender, EventArgs e)
		{
			using (var context = new DemoContext())
			{
				dgvPerson.ReadOnly = true;
				dgvPerson.MultiSelect = false;
				//dgvPerson.DataSource = context.People.ToList();
			

			}

		}
		#endregion

		#region Person
		#region Event
		private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		#endregion

		#region Method
		#endregion

		#endregion

		#region Course
		#region Event
		#endregion

		#region Method
		#endregion

		#endregion

		#region Company
		#region Event
		#endregion

		#region Method
		#endregion

		#endregion


	}
}
