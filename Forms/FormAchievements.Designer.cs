
namespace coursework
{
	partial class FormAchievements
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAchievements));
			this.GridListAchievements = new System.Windows.Forms.DataGridView();
			this.button_deleteRecord = new System.Windows.Forms.Button();
			this.button_editRecord = new System.Windows.Forms.Button();
			this.button_addRecord = new System.Windows.Forms.Button();
			this.GridListStudents = new System.Windows.Forms.DataGridView();
			this.searchDataTextBox = new System.Windows.Forms.TextBox();
			this.labelSearch = new System.Windows.Forms.Label();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.subd_schoolDataSet = new coursework.subd_schoolDataSet();
			this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentsTableAdapter = new coursework.subd_schoolDataSetTableAdapters.studentsTableAdapter();
			this.fKachievementsstudentsstudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.achievements_studentsTableAdapter = new coursework.subd_schoolDataSetTableAdapters.achievements_studentsTableAdapter();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classOfReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeOfReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subjectOfReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabInfoDetail = new System.Windows.Forms.TabPage();
			this.tabInfoCommon = new System.Windows.Forms.TabPage();
			this.GridListSudentCountAchievements = new System.Windows.Forms.DataGridView();
			this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countAchievements = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.GridListAchievements)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.subd_schoolDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKachievementsstudentsstudentsBindingSource)).BeginInit();
			this.tabControl.SuspendLayout();
			this.tabInfoDetail.SuspendLayout();
			this.tabInfoCommon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GridListSudentCountAchievements)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// GridListAchievements
			// 
			this.GridListAchievements.AllowUserToAddRows = false;
			this.GridListAchievements.AllowUserToDeleteRows = false;
			this.GridListAchievements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GridListAchievements.AutoGenerateColumns = false;
			this.GridListAchievements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridListAchievements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.GridListAchievements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.GridListAchievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridListAchievements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.classOfReward,
            this.typeOfReward,
            this.subjectOfReward,
            this.idStudent});
			this.GridListAchievements.DataSource = this.fKachievementsstudentsstudentsBindingSource;
			this.GridListAchievements.Location = new System.Drawing.Point(6, 298);
			this.GridListAchievements.Name = "GridListAchievements";
			this.GridListAchievements.ReadOnly = true;
			this.GridListAchievements.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.GridListAchievements.RowHeadersVisible = false;
			this.GridListAchievements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridListAchievements.Size = new System.Drawing.Size(936, 283);
			this.GridListAchievements.TabIndex = 19;
			// 
			// button_deleteRecord
			// 
			this.button_deleteRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.button_deleteRecord.FlatAppearance.BorderSize = 2;
			this.button_deleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_deleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_deleteRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_deleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_deleteRecord.Image")));
			this.button_deleteRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_deleteRecord.Location = new System.Drawing.Point(979, 248);
			this.button_deleteRecord.Name = "button_deleteRecord";
			this.button_deleteRecord.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
			this.button_deleteRecord.Size = new System.Drawing.Size(200, 50);
			this.button_deleteRecord.TabIndex = 18;
			this.button_deleteRecord.Text = "Удалить  ";
			this.button_deleteRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_deleteRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_deleteRecord.UseVisualStyleBackColor = true;
			this.button_deleteRecord.Click += new System.EventHandler(this.button_deleteRecord_Click);
			// 
			// button_editRecord
			// 
			this.button_editRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.button_editRecord.FlatAppearance.BorderSize = 2;
			this.button_editRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_editRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_editRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_editRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_editRecord.Image")));
			this.button_editRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_editRecord.Location = new System.Drawing.Point(979, 183);
			this.button_editRecord.Name = "button_editRecord";
			this.button_editRecord.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
			this.button_editRecord.Size = new System.Drawing.Size(200, 50);
			this.button_editRecord.TabIndex = 17;
			this.button_editRecord.Text = "Информация ";
			this.button_editRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_editRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_editRecord.UseVisualStyleBackColor = true;
			this.button_editRecord.Click += new System.EventHandler(this.button_editRecord_Click);
			// 
			// button_addRecord
			// 
			this.button_addRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.button_addRecord.FlatAppearance.BorderSize = 2;
			this.button_addRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_addRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_addRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_addRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_addRecord.Image")));
			this.button_addRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_addRecord.Location = new System.Drawing.Point(979, 118);
			this.button_addRecord.Name = "button_addRecord";
			this.button_addRecord.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
			this.button_addRecord.Size = new System.Drawing.Size(200, 50);
			this.button_addRecord.TabIndex = 16;
			this.button_addRecord.Text = "Добавить  ";
			this.button_addRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_addRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_addRecord.UseVisualStyleBackColor = true;
			this.button_addRecord.Click += new System.EventHandler(this.button_addRecord_Click);
			// 
			// GridListStudents
			// 
			this.GridListStudents.AllowUserToAddRows = false;
			this.GridListStudents.AllowUserToDeleteRows = false;
			this.GridListStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GridListStudents.AutoGenerateColumns = false;
			this.GridListStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridListStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.GridListStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.GridListStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridListStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
			this.GridListStudents.DataSource = this.studentsBindingSource;
			this.GridListStudents.Location = new System.Drawing.Point(6, 8);
			this.GridListStudents.Name = "GridListStudents";
			this.GridListStudents.ReadOnly = true;
			this.GridListStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.GridListStudents.RowHeadersVisible = false;
			this.GridListStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridListStudents.Size = new System.Drawing.Size(936, 283);
			this.GridListStudents.TabIndex = 15;
			// 
			// searchDataTextBox
			// 
			this.searchDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.searchDataTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.searchDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchDataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.searchDataTextBox.Location = new System.Drawing.Point(979, 74);
			this.searchDataTextBox.MaxLength = 40;
			this.searchDataTextBox.Multiline = true;
			this.searchDataTextBox.Name = "searchDataTextBox";
			this.searchDataTextBox.Size = new System.Drawing.Size(200, 27);
			this.searchDataTextBox.TabIndex = 14;
			this.searchDataTextBox.TextChanged += new System.EventHandler(this.searchDataTextBox_TextChanged);
			// 
			// labelSearch
			// 
			this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSearch.AutoSize = true;
			this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSearch.ForeColor = System.Drawing.Color.Gainsboro;
			this.labelSearch.Location = new System.Drawing.Point(974, 34);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(78, 25);
			this.labelSearch.TabIndex = 13;
			this.labelSearch.Text = "Поиск";
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = this.subd_schoolDataSet;
			this.bindingSource1.Position = 0;
			// 
			// subd_schoolDataSet
			// 
			this.subd_schoolDataSet.DataSetName = "subd_schoolDataSet";
			this.subd_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// studentsBindingSource
			// 
			this.studentsBindingSource.DataMember = "students";
			this.studentsBindingSource.DataSource = this.bindingSource1;
			// 
			// studentsTableAdapter
			// 
			this.studentsTableAdapter.ClearBeforeFill = true;
			// 
			// fKachievementsstudentsstudentsBindingSource
			// 
			this.fKachievementsstudentsstudentsBindingSource.DataMember = "FK_achievements_students_students";
			this.fKachievementsstudentsstudentsBindingSource.DataSource = this.studentsBindingSource;
			// 
			// achievements_studentsTableAdapter
			// 
			this.achievements_studentsTableAdapter.ClearBeforeFill = true;
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// classOfReward
			// 
			this.classOfReward.DataPropertyName = "classOfReward";
			this.classOfReward.HeaderText = "Класс награды";
			this.classOfReward.Name = "classOfReward";
			this.classOfReward.ReadOnly = true;
			// 
			// typeOfReward
			// 
			this.typeOfReward.DataPropertyName = "typeOfReward";
			this.typeOfReward.HeaderText = "Тип награды";
			this.typeOfReward.Name = "typeOfReward";
			this.typeOfReward.ReadOnly = true;
			// 
			// subjectOfReward
			// 
			this.subjectOfReward.DataPropertyName = "subjectOfReward";
			this.subjectOfReward.HeaderText = "Предмет награды";
			this.subjectOfReward.Name = "subjectOfReward";
			this.subjectOfReward.ReadOnly = true;
			// 
			// idStudent
			// 
			this.idStudent.DataPropertyName = "id_Student";
			this.idStudent.HeaderText = "id_Student";
			this.idStudent.Name = "idStudent";
			this.idStudent.ReadOnly = true;
			this.idStudent.Visible = false;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// surnameDataGridViewTextBoxColumn
			// 
			this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
			this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
			this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
			this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// firstnameDataGridViewTextBoxColumn
			// 
			this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
			this.firstnameDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
			this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// patronymicDataGridViewTextBoxColumn
			// 
			this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "patronymic";
			this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
			this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
			this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// classDataGridViewTextBoxColumn
			// 
			this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
			this.classDataGridViewTextBoxColumn.HeaderText = "Класс";
			this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
			this.classDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabInfoDetail);
			this.tabControl.Controls.Add(this.tabInfoCommon);
			this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(956, 616);
			this.tabControl.TabIndex = 20;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// tabInfoDetail
			// 
			this.tabInfoDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.tabInfoDetail.Controls.Add(this.GridListAchievements);
			this.tabInfoDetail.Controls.Add(this.GridListStudents);
			this.tabInfoDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tabInfoDetail.Location = new System.Drawing.Point(4, 25);
			this.tabInfoDetail.Name = "tabInfoDetail";
			this.tabInfoDetail.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabInfoDetail.Size = new System.Drawing.Size(948, 587);
			this.tabInfoDetail.TabIndex = 0;
			this.tabInfoDetail.Text = "Достижения учащегося";
			// 
			// tabInfoCommon
			// 
			this.tabInfoCommon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.tabInfoCommon.Controls.Add(this.GridListSudentCountAchievements);
			this.tabInfoCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tabInfoCommon.Location = new System.Drawing.Point(4, 25);
			this.tabInfoCommon.Name = "tabInfoCommon";
			this.tabInfoCommon.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabInfoCommon.Size = new System.Drawing.Size(948, 587);
			this.tabInfoCommon.TabIndex = 1;
			this.tabInfoCommon.Text = "Список достижений учащихся";
			// 
			// GridListSudentCountAchievements
			// 
			this.GridListSudentCountAchievements.AllowUserToAddRows = false;
			this.GridListSudentCountAchievements.AllowUserToDeleteRows = false;
			this.GridListSudentCountAchievements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GridListSudentCountAchievements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridListSudentCountAchievements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.GridListSudentCountAchievements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.GridListSudentCountAchievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridListSudentCountAchievements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surname,
            this.firstname,
            this.patronymic,
            this.classNumber,
            this.countAchievements});
			this.GridListSudentCountAchievements.Location = new System.Drawing.Point(6, 6);
			this.GridListSudentCountAchievements.Name = "GridListSudentCountAchievements";
			this.GridListSudentCountAchievements.ReadOnly = true;
			this.GridListSudentCountAchievements.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.GridListSudentCountAchievements.RowHeadersVisible = false;
			this.GridListSudentCountAchievements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridListSudentCountAchievements.Size = new System.Drawing.Size(936, 575);
			this.GridListSudentCountAchievements.TabIndex = 16;
			// 
			// studentsBindingSource1
			// 
			this.studentsBindingSource1.DataMember = "students";
			this.studentsBindingSource1.DataSource = this.bindingSource1;
			// 
			// surname
			// 
			this.surname.HeaderText = "Фамилия";
			this.surname.Name = "surname";
			this.surname.ReadOnly = true;
			// 
			// firstname
			// 
			this.firstname.FillWeight = 90F;
			this.firstname.HeaderText = "Имя";
			this.firstname.Name = "firstname";
			this.firstname.ReadOnly = true;
			// 
			// patronymic
			// 
			this.patronymic.HeaderText = "Отчество";
			this.patronymic.Name = "patronymic";
			this.patronymic.ReadOnly = true;
			// 
			// classNumber
			// 
			this.classNumber.FillWeight = 50F;
			this.classNumber.HeaderText = "Класс";
			this.classNumber.Name = "classNumber";
			this.classNumber.ReadOnly = true;
			// 
			// countAchievements
			// 
			this.countAchievements.HeaderText = "Кол-во достижений";
			this.countAchievements.Name = "countAchievements";
			this.countAchievements.ReadOnly = true;
			// 
			// FormAchievements
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(1190, 640);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.button_deleteRecord);
			this.Controls.Add(this.button_editRecord);
			this.Controls.Add(this.button_addRecord);
			this.Controls.Add(this.searchDataTextBox);
			this.Controls.Add(this.labelSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAchievements";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAchievements";
			this.Load += new System.EventHandler(this.FormAchievements_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridListAchievements)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.subd_schoolDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKachievementsstudentsstudentsBindingSource)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.tabInfoDetail.ResumeLayout(false);
			this.tabInfoCommon.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GridListSudentCountAchievements)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView GridListAchievements;
		private System.Windows.Forms.Button button_deleteRecord;
		private System.Windows.Forms.Button button_editRecord;
		private System.Windows.Forms.Button button_addRecord;
		public System.Windows.Forms.DataGridView GridListStudents;
		private System.Windows.Forms.TextBox searchDataTextBox;
		private System.Windows.Forms.Label labelSearch;
		private System.Windows.Forms.BindingSource bindingSource1;
		private subd_schoolDataSet subd_schoolDataSet;
		private System.Windows.Forms.BindingSource studentsBindingSource;
		private subd_schoolDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
		private System.Windows.Forms.BindingSource fKachievementsstudentsstudentsBindingSource;
		private subd_schoolDataSetTableAdapters.achievements_studentsTableAdapter achievements_studentsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn classOfReward;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeOfReward;
		private System.Windows.Forms.DataGridViewTextBoxColumn subjectOfReward;
		private System.Windows.Forms.DataGridViewTextBoxColumn idStudent;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabInfoDetail;
		private System.Windows.Forms.TabPage tabInfoCommon;
		public System.Windows.Forms.DataGridView GridListSudentCountAchievements;
		private System.Windows.Forms.BindingSource studentsBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn surname;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
		private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
		private System.Windows.Forms.DataGridViewTextBoxColumn classNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn countAchievements;
	}
}