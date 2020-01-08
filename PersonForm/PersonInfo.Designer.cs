﻿namespace PersonForm
{
	partial class PersonInfo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.Add = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailsDisplayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.UpdatePerson = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.txtEmailToEdit = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.emailFoundCbx = new System.Windows.Forms.ComboBox();
			this.txtNameToFind = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(218, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input Id";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(328, 20);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(182, 22);
			this.txtId.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(218, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Input Name";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(328, 57);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(182, 22);
			this.txtName.TabIndex = 3;
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(221, 142);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(75, 23);
			this.Add.TabIndex = 4;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailsDisplayDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.personBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(138, 182);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(555, 350);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 50;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// emailsDisplayDataGridViewTextBoxColumn
			// 
			this.emailsDisplayDataGridViewTextBoxColumn.DataPropertyName = "EmailsDisplay";
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.emailsDisplayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.emailsDisplayDataGridViewTextBoxColumn.HeaderText = "Emails Display";
			this.emailsDisplayDataGridViewTextBoxColumn.Name = "emailsDisplayDataGridViewTextBoxColumn";
			this.emailsDisplayDataGridViewTextBoxColumn.ReadOnly = true;
			this.emailsDisplayDataGridViewTextBoxColumn.Width = 200;
			// 
			// personBindingSource
			// 
			this.personBindingSource.DataSource = typeof(DataModel.Person);
			// 
			// UpdatePerson
			// 
			this.UpdatePerson.Location = new System.Drawing.Point(328, 142);
			this.UpdatePerson.Name = "UpdatePerson";
			this.UpdatePerson.Size = new System.Drawing.Size(67, 23);
			this.UpdatePerson.TabIndex = 6;
			this.UpdatePerson.Text = "Update";
			this.UpdatePerson.UseVisualStyleBackColor = true;
			this.UpdatePerson.Click += new System.EventHandler(this.Update_Click);
			// 
			// Delete
			// 
			this.Delete.Location = new System.Drawing.Point(435, 142);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(75, 23);
			this.Delete.TabIndex = 7;
			this.Delete.Text = "Delete";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(218, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Input Email";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(328, 93);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(182, 22);
			this.txtEmail.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.txtEmailToEdit);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.emailFoundCbx);
			this.groupBox1.Controls.Add(this.txtNameToFind);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(872, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(427, 303);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Emails";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(275, 149);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 10;
			this.button4.Text = "Save";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// txtEmailToEdit
			// 
			this.txtEmailToEdit.Location = new System.Drawing.Point(141, 150);
			this.txtEmailToEdit.Name = "txtEmailToEdit";
			this.txtEmailToEdit.Size = new System.Drawing.Size(119, 22);
			this.txtEmailToEdit.TabIndex = 9;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(287, 15);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "Find";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(63, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "Email";
			// 
			// emailFoundCbx
			// 
			this.emailFoundCbx.FormattingEnabled = true;
			this.emailFoundCbx.Location = new System.Drawing.Point(141, 107);
			this.emailFoundCbx.Name = "emailFoundCbx";
			this.emailFoundCbx.Size = new System.Drawing.Size(119, 24);
			this.emailFoundCbx.TabIndex = 4;
			// 
			// txtNameToFind
			// 
			this.txtNameToFind.Location = new System.Drawing.Point(163, 16);
			this.txtNameToFind.Name = "txtNameToFind";
			this.txtNameToFind.Size = new System.Drawing.Size(111, 22);
			this.txtNameToFind.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(63, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "Input Name";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(275, 107);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(67, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.button1.Location = new System.Drawing.Point(66, 149);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(52, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Edit";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// PersonInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1651, 657);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.UpdatePerson);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Name = "PersonInfo";
			this.Text = "Person";
			this.Load += new System.EventHandler(this.PersonInfo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button UpdatePerson;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.BindingSource personBindingSource;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox emailFoundCbx;
		private System.Windows.Forms.TextBox txtNameToFind;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailsDisplayDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox txtEmailToEdit;
		private System.Windows.Forms.Button button4;
	}
}

