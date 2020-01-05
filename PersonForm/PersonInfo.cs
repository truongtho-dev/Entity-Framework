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
				dataGridView1.DataSource = context.People.ToList();
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

		private void Add_Click(object sender, EventArgs e)
		{
			string textId = txtId.Text;
			string textName = txtName.Text;
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
								Name = textName
							};
							context.People.Add(person);
							context.SaveChanges();
							MessageBox.Show($"You are input name: {textName} with id: {context.People.Max(p=>p.Id)}");
							dataGridView1.DataSource = context.People.ToList();
						}
					}
				}
			}
		}

		private void Update_Click(object sender, EventArgs e)
		{
			using (var context = new DemoContext())
			{			
				int idPerson = Convert.ToInt32(txtId.Text);
				var person = context.People.SingleOrDefault(p => p.Id == idPerson);
				person.Name = txtName.Text;
				context.SaveChanges();
				dataGridView1.DataSource = context.People.ToList();
			}
		}


		private void Delete_Click(object sender, EventArgs e)
		{
			using (var context = new DemoContext())
			{
				int idPerson = Convert.ToInt32(txtId.Text);
				var person = context.People.SingleOrDefault(p => p.Id == idPerson);
				context.People.Remove(person);
				context.SaveChanges();
				dataGridView1.DataSource = context.People.ToList();
			}

		}
	}
}
