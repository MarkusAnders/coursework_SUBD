
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
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataOfBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BoxEditList = new System.Windows.Forms.GroupBox();
			this.button_deleteStudent = new System.Windows.Forms.Button();
			this.button_editStudent = new System.Windows.Forms.Button();
			this.button_addStudent = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).BeginInit();
			this.BoxEditList.SuspendLayout();
			this.SuspendLayout();
			// 
			// GridListStudents
			// 
			this.GridListStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridListStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.surname,
            this.patronymic,
            this.classNumber,
            this.dataOfBirthday});
			this.GridListStudents.Location = new System.Drawing.Point(12, 9);
			this.GridListStudents.Name = "GridListStudents";
			this.GridListStudents.RowHeadersWidth = 51;
			this.GridListStudents.RowTemplate.Height = 24;
			this.GridListStudents.Size = new System.Drawing.Size(943, 393);
			this.GridListStudents.TabIndex = 0;
			// 
			// name
			// 
			this.name.HeaderText = "Имя";
			this.name.MinimumWidth = 6;
			this.name.Name = "name";
			this.name.Width = 125;
			// 
			// surname
			// 
			this.surname.HeaderText = "Фамилия";
			this.surname.MinimumWidth = 6;
			this.surname.Name = "surname";
			this.surname.Width = 150;
			// 
			// patronymic
			// 
			this.patronymic.HeaderText = "Отчество";
			this.patronymic.MinimumWidth = 6;
			this.patronymic.Name = "patronymic";
			this.patronymic.Width = 150;
			// 
			// classNumber
			// 
			this.classNumber.HeaderText = "Класс";
			this.classNumber.MinimumWidth = 6;
			this.classNumber.Name = "classNumber";
			this.classNumber.Width = 80;
			// 
			// dataOfBirthday
			// 
			this.dataOfBirthday.HeaderText = "Дата рождения";
			this.dataOfBirthday.MinimumWidth = 6;
			this.dataOfBirthday.Name = "dataOfBirthday";
			this.dataOfBirthday.Width = 125;
			// 
			// BoxEditList
			// 
			this.BoxEditList.BackColor = System.Drawing.Color.Transparent;
			this.BoxEditList.Controls.Add(this.button_deleteStudent);
			this.BoxEditList.Controls.Add(this.button_editStudent);
			this.BoxEditList.Controls.Add(this.button_addStudent);
			this.BoxEditList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BoxEditList.Location = new System.Drawing.Point(961, 0);
			this.BoxEditList.Name = "BoxEditList";
			this.BoxEditList.Size = new System.Drawing.Size(197, 191);
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
			// ListStudents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1165, 414);
			this.Controls.Add(this.BoxEditList);
			this.Controls.Add(this.GridListStudents);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
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
	}
}