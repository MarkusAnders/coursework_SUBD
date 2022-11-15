﻿
namespace coursework
{
	partial class ListStudents
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
			this.GridListStudents = new System.Windows.Forms.DataGridView();
			this.BoxEditList = new System.Windows.Forms.GroupBox();
			this.button_deleteStudent = new System.Windows.Forms.Button();
			this.button_editStudent = new System.Windows.Forms.Button();
			this.button_addStudent = new System.Windows.Forms.Button();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataOfBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Фотография = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).BeginInit();
			this.BoxEditList.SuspendLayout();
			this.SuspendLayout();
			// 
			// GridListStudents
			// 
			this.GridListStudents.AllowUserToAddRows = false;
			this.GridListStudents.AllowUserToDeleteRows = false;
			this.GridListStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.GridListStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.GridListStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridListStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.surname,
            this.patronymic,
            this.classNumber,
            this.dataOfBirthday,
            this.Фотография});
			this.GridListStudents.Dock = System.Windows.Forms.DockStyle.Left;
			this.GridListStudents.Location = new System.Drawing.Point(0, 0);
			this.GridListStudents.Name = "GridListStudents";
			this.GridListStudents.ReadOnly = true;
			this.GridListStudents.RowHeadersWidth = 51;
			this.GridListStudents.RowTemplate.Height = 24;
			this.GridListStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridListStudents.Size = new System.Drawing.Size(963, 414);
			this.GridListStudents.TabIndex = 0;
			// 
			// BoxEditList
			// 
			this.BoxEditList.BackColor = System.Drawing.Color.Transparent;
			this.BoxEditList.Controls.Add(this.button_deleteStudent);
			this.BoxEditList.Controls.Add(this.button_editStudent);
			this.BoxEditList.Controls.Add(this.button_addStudent);
			this.BoxEditList.Dock = System.Windows.Forms.DockStyle.Right;
			this.BoxEditList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BoxEditList.Location = new System.Drawing.Point(963, 0);
			this.BoxEditList.Name = "BoxEditList";
			this.BoxEditList.Size = new System.Drawing.Size(202, 414);
			this.BoxEditList.TabIndex = 1;
			this.BoxEditList.TabStop = false;
			// 
			// button_deleteStudent
			// 
			this.button_deleteStudent.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_deleteStudent.Location = new System.Drawing.Point(6, 131);
			this.button_deleteStudent.Name = "button_deleteStudent";
			this.button_deleteStudent.Size = new System.Drawing.Size(184, 49);
			this.button_deleteStudent.TabIndex = 2;
			this.button_deleteStudent.Text = "Удалить";
			this.button_deleteStudent.UseVisualStyleBackColor = true;
			this.button_deleteStudent.Click += new System.EventHandler(this.button_deleteStudent_Click);
			// 
			// button_editStudent
			// 
			this.button_editStudent.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_editStudent.Location = new System.Drawing.Point(6, 76);
			this.button_editStudent.Name = "button_editStudent";
			this.button_editStudent.Size = new System.Drawing.Size(184, 49);
			this.button_editStudent.TabIndex = 1;
			this.button_editStudent.Text = "Редактировать";
			this.button_editStudent.UseVisualStyleBackColor = true;
			this.button_editStudent.Click += new System.EventHandler(this.button_editStudent_Click);
			// 
			// button_addStudent
			// 
			this.button_addStudent.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_addStudent.Location = new System.Drawing.Point(6, 21);
			this.button_addStudent.Name = "button_addStudent";
			this.button_addStudent.Size = new System.Drawing.Size(184, 49);
			this.button_addStudent.TabIndex = 0;
			this.button_addStudent.Text = "Добавить";
			this.button_addStudent.UseVisualStyleBackColor = true;
			this.button_addStudent.Click += new System.EventHandler(this.button_addStudent_Click);
			// 
			// name
			// 
			this.name.HeaderText = "Имя";
			this.name.MinimumWidth = 6;
			this.name.Name = "name";
			this.name.ReadOnly = true;
			this.name.Width = 64;
			// 
			// surname
			// 
			this.surname.HeaderText = "Фамилия";
			this.surname.MinimumWidth = 6;
			this.surname.Name = "surname";
			this.surname.ReadOnly = true;
			this.surname.Width = 99;
			// 
			// patronymic
			// 
			this.patronymic.HeaderText = "Отчество";
			this.patronymic.MinimumWidth = 6;
			this.patronymic.Name = "patronymic";
			this.patronymic.ReadOnly = true;
			// 
			// classNumber
			// 
			this.classNumber.HeaderText = "Класс";
			this.classNumber.MinimumWidth = 6;
			this.classNumber.Name = "classNumber";
			this.classNumber.ReadOnly = true;
			this.classNumber.Width = 76;
			// 
			// dataOfBirthday
			// 
			this.dataOfBirthday.HeaderText = "Дата рождения";
			this.dataOfBirthday.MinimumWidth = 6;
			this.dataOfBirthday.Name = "dataOfBirthday";
			this.dataOfBirthday.ReadOnly = true;
			this.dataOfBirthday.Width = 128;
			// 
			// Фотография
			// 
			this.Фотография.HeaderText = "Фотография";
			this.Фотография.MinimumWidth = 6;
			this.Фотография.Name = "Фотография";
			this.Фотография.ReadOnly = true;
			this.Фотография.Width = 121;
			// 
			// ListStudents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1165, 414);
			this.Controls.Add(this.BoxEditList);
			this.Controls.Add(this.GridListStudents);
			this.Name = "ListStudents";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Список учеников";
			this.Load += new System.EventHandler(this.ListStudents_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).EndInit();
			this.BoxEditList.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView GridListStudents;
		private System.Windows.Forms.GroupBox BoxEditList;
		private System.Windows.Forms.Button button_deleteStudent;
		private System.Windows.Forms.Button button_editStudent;
		private System.Windows.Forms.Button button_addStudent;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn surname;
		private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
		private System.Windows.Forms.DataGridViewTextBoxColumn classNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataOfBirthday;
		private System.Windows.Forms.DataGridViewTextBoxColumn Фотография;
	}
}