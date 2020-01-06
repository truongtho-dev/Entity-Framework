using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace PersonForm
{
	public partial class PersonInfo : Form
	{
		public PersonInfo()
		{
			InitializeComponent();
		}

		

		private void PersonInfo_Load(object sender, EventArgs e)
		{
			dataGridView1.ReadOnly = true;
			
			using (var context = new DemoContext())
			{
				dataGridView1.DataSource = context.People.Include(p=>p.Emails).ToList();
				dataGridView1.MultiSelect = false;
				dataGridView1.RowEnter += DataGridView1_RowEnter;

			}
		}
		private void txtId_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{

		}

		private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			var idValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
			var nameValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
			txtId.Text = idValue.ToString();
			txtName.Text = nameValue.ToString();

		}
		#region Add Event

		private void Add_Click(object sender, EventArgs e)
		{
			string textId = txtId.Text;
			string textName = txtName.Text;
			string textEmail = txtEmail.Text;
			int idValue;
			if (string.IsNullOrWhiteSpace(textId) || string.IsNullOrWhiteSpace(textName))
			{
				MessageBox.Show("You must input id and name!");
				return;
			}
			else
			{
				bool idInput = int.TryParse(textId, out idValue);
				if (!idInput)
				{
					MessageBox.Show("Value input invalid");
					return;
				}
				else
				{
					using (var context = new DemoContext())
					{
						if (context.People.Any(p=>p.Id==idValue))
						{
							MessageBox.Show("Id is exists in database");
							return;
						}
						else
						{
							var person = new Person
							{
								Name = textName,
								Emails = new List <Email> { new Email { EmailAddress = textEmail} }
							};
							context.People.Add(person);
							context.SaveChanges();
							MessageBox.Show($"You are input name: {textName} with id: {context.People.Max(p=>p.Id)}, email: {textEmail}");
					
							dataGridView1.DataSource = context.People.Include(p => p.Emails).ToList();
						}
					}
				}
			}
		}
		#endregion

		#region Update Event
		private void Update_Click(object sender, EventArgs e)
		{
			using (var context = new DemoContext())
			{			
				int idPerson = Convert.ToInt32(txtId.Text);
				var person = context.People.SingleOrDefault(p => p.Id == idPerson);
				person.Name = txtName.Text;
				Email newEmail = new Email() { EmailAddress = txtEmail.Text };
				context.SaveChanges();
				dataGridView1.DataSource = context.People.ToList();
			}
		}
		#endregion

		#region Delete Event
		private void Delete_Click(object sender, EventArgs e)
		{
			using (var context = new DemoContext())
			{
				int idPerson = Convert.ToInt32(txtId.Text);
				var person = context.People.SingleOrDefault(p => p.Id == idPerson);
				context.People.Remove(person);
				context.SaveChanges();
				dataGridView1.DataSource = context.People.Include(p=>p.Emails).ToList();
			}

		}
		#endregion
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		#region Emails Method



		public void FindEmail()
		{
			string nameInputToFind = txtNameToFind.Text.ToLower();
			using (var context = new DemoContext())
			{
				var query = context.People.Where(p=>p.Name.ToLower() == nameInputToFind).Include(p=>p.Emails).ToList();
				if (query.Exists(q=>q.Name.ToLower()== nameInputToFind))
				{
					dataGridView1.DataSource = query;				
				}
				else
				{
					MessageBox.Show("Not Found");
					return;
				}				
			}
		}
		
		
		public void EditEmail()
		{
			


		}

		public void DeleteEmail()
		{
		}
		#endregion

		#region Emails Event
		private void button3_Click(object sender, EventArgs e)
		{
			FindEmail();
		}
		#endregion

		private void button1_Click(object sender, EventArgs e)
		{
			EditEmail();
		}
	}
}


