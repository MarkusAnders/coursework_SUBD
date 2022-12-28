
namespace coursework
{
	partial class FormCertification
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCertification));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.button_deleteRecord = new System.Windows.Forms.Button();
			this.button_editRecord = new System.Windows.Forms.Button();
			this.button_addRecord = new System.Windows.Forms.Button();
			this.GridListStudents = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.subd_schoolDataSet = new coursework.subd_schoolDataSet();
			this.searchDataTextBox = new System.Windows.Forms.TextBox();
			this.labelSearch = new System.Windows.Forms.Label();
			this.GridListCertification = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstQuarter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.secondQuarter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.thirdQuarter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fourthQuarter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.annual = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idstudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fKcertificationstudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentsTableAdapter = new coursework.subd_schoolDataSetTableAdapters.studentsTableAdapter();
			this.certificationTableAdapter = new coursework.subd_schoolDataSetTableAdapters.certificationTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.subd_schoolDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridListCertification)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKcertificationstudentsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// button_deleteRecord
			// 
			this.button_deleteRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_deleteRecord.FlatAppearance.BorderSize = 2;
			this.button_deleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_deleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_deleteRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_deleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_deleteRecord.Image")));
			this.button_deleteRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_deleteRecord.Location = new System.Drawing.Point(954, 221);
			this.button_deleteRecord.Name = "button_deleteRecord";
			this.button_deleteRecord.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
			this.button_deleteRecord.Size = new System.Drawing.Size(215, 50);
			this.button_deleteRecord.TabIndex = 11;
			this.button_deleteRecord.Text = "Удалить  ";
			this.button_deleteRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_deleteRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_deleteRecord.UseVisualStyleBackColor = true;
			this.button_deleteRecord.Click += new System.EventHandler(this.button_deleteRecord_Click);
			// 
			// button_editRecord
			// 
			this.button_editRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_editRecord.FlatAppearance.BorderSize = 2;
			this.button_editRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_editRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_editRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_editRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_editRecord.Image")));
			this.button_editRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_editRecord.Location = new System.Drawing.Point(954, 156);
			this.button_editRecord.Name = "button_editRecord";
			this.button_editRecord.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
			this.button_editRecord.Size = new System.Drawing.Size(215, 50);
			this.button_editRecord.TabIndex = 10;
			this.button_editRecord.Text = "Информация ";
			this.button_editRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_editRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_editRecord.UseVisualStyleBackColor = true;
			this.button_editRecord.Click += new System.EventHandler(this.button_editRecord_Click);
			// 
			// button_addRecord
			// 
			this.button_addRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_addRecord.FlatAppearance.BorderSize = 2;
			this.button_addRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_addRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_addRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_addRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_addRecord.Image")));
			this.button_addRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_addRecord.Location = new System.Drawing.Point(954, 91);
			this.button_addRecord.Name = "button_addRecord";
			this.button_addRecord.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
			this.button_addRecord.Size = new System.Drawing.Size(215, 50);
			this.button_addRecord.TabIndex = 9;
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
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridListStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.GridListStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridListStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
			this.GridListStudents.DataSource = this.studentsBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.GridListStudents.DefaultCellStyle = dataGridViewCellStyle2;
			this.GridListStudents.Location = new System.Drawing.Point(12, 12);
			this.GridListStudents.Name = "GridListStudents";
			this.GridListStudents.ReadOnly = true;
			this.GridListStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.GridListStudents.RowHeadersVisible = false;
			this.GridListStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridListStudents.Size = new System.Drawing.Size(917, 300);
			this.GridListStudents.TabIndex = 8;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
			this.classDataGridViewTextBoxColumn.FillWeight = 60F;
			this.classDataGridViewTextBoxColumn.HeaderText = "Класс";
			this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
			this.classDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// studentsBindingSource
			// 
			this.studentsBindingSource.DataMember = "students";
			this.studentsBindingSource.DataSource = this.bindingSource1;
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
			// searchDataTextBox
			// 
			this.searchDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchDataTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.searchDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchDataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.searchDataTextBox.Location = new System.Drawing.Point(954, 49);
			this.searchDataTextBox.MaxLength = 40;
			this.searchDataTextBox.Multiline = true;
			this.searchDataTextBox.Name = "searchDataTextBox";
			this.searchDataTextBox.Size = new System.Drawing.Size(215, 27);
			this.searchDataTextBox.TabIndex = 7;
			this.searchDataTextBox.TextChanged += new System.EventHandler(this.searchDataTextBox_TextChanged);
			// 
			// labelSearch
			// 
			this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSearch.AutoSize = true;
			this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSearch.ForeColor = System.Drawing.Color.Gainsboro;
			this.labelSearch.Location = new System.Drawing.Point(949, 12);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(85, 25);
			this.labelSearch.TabIndex = 6;
			this.labelSearch.Text = "Поиск:";
			// 
			// GridListCertification
			// 
			this.GridListCertification.AllowUserToAddRows = false;
			this.GridListCertification.AllowUserToDeleteRows = false;
			this.GridListCertification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GridListCertification.AutoGenerateColumns = false;
			this.GridListCertification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridListCertification.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.GridListCertification.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridListCertification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.GridListCertification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridListCertification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.subject,
            this.firstQuarter,
            this.secondQuarter,
            this.thirdQuarter,
            this.fourthQuarter,
            this.annual,
            this.idstudent});
			this.GridListCertification.DataSource = this.fKcertificationstudentsBindingSource;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.GridListCertification.DefaultCellStyle = dataGridViewCellStyle4;
			this.GridListCertification.Location = new System.Drawing.Point(12, 328);
			this.GridListCertification.Name = "GridListCertification";
			this.GridListCertification.ReadOnly = true;
			this.GridListCertification.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.GridListCertification.RowHeadersVisible = false;
			this.GridListCertification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridListCertification.Size = new System.Drawing.Size(917, 300);
			this.GridListCertification.TabIndex = 12;
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// subject
			// 
			this.subject.DataPropertyName = "subject";
			this.subject.HeaderText = "Предмет";
			this.subject.Name = "subject";
			this.subject.ReadOnly = true;
			// 
			// firstQuarter
			// 
			this.firstQuarter.DataPropertyName = "firstQuarter";
			this.firstQuarter.FillWeight = 67F;
			this.firstQuarter.HeaderText = "1 Четверть";
			this.firstQuarter.Name = "firstQuarter";
			this.firstQuarter.ReadOnly = true;
			// 
			// secondQuarter
			// 
			this.secondQuarter.DataPropertyName = "secondQuarter";
			this.secondQuarter.FillWeight = 67F;
			this.secondQuarter.HeaderText = "2 Четверть";
			this.secondQuarter.Name = "secondQuarter";
			this.secondQuarter.ReadOnly = true;
			// 
			// thirdQuarter
			// 
			this.thirdQuarter.DataPropertyName = "thirdQuarter";
			this.thirdQuarter.FillWeight = 67F;
			this.thirdQuarter.HeaderText = "3 Четверть";
			this.thirdQuarter.Name = "thirdQuarter";
			this.thirdQuarter.ReadOnly = true;
			// 
			// fourthQuarter
			// 
			this.fourthQuarter.DataPropertyName = "fourthQuarter";
			this.fourthQuarter.FillWeight = 67F;
			this.fourthQuarter.HeaderText = "4 Четверть";
			this.fourthQuarter.Name = "fourthQuarter";
			this.fourthQuarter.ReadOnly = true;
			// 
			// annual
			// 
			this.annual.DataPropertyName = "annual";
			this.annual.FillWeight = 65F;
			this.annual.HeaderText = "Итоговая";
			this.annual.Name = "annual";
			this.annual.ReadOnly = true;
			// 
			// idstudent
			// 
			this.idstudent.DataPropertyName = "id_student";
			this.idstudent.HeaderText = "id_student";
			this.idstudent.Name = "idstudent";
			this.idstudent.ReadOnly = true;
			this.idstudent.Visible = false;
			// 
			// fKcertificationstudentsBindingSource
			// 
			this.fKcertificationstudentsBindingSource.DataMember = "FK_certification_students";
			this.fKcertificationstudentsBindingSource.DataSource = this.studentsBindingSource;
			// 
			// studentsTableAdapter
			// 
			this.studentsTableAdapter.ClearBeforeFill = true;
			// 
			// certificationTableAdapter
			// 
			this.certificationTableAdapter.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Gainsboro;
			this.label1.Location = new System.Drawing.Point(1033, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 17);
			this.label1.TabIndex = 22;
			this.label1.Text = "по фамилии";
			// 
			// FormCertification
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(1190, 640);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GridListCertification);
			this.Controls.Add(this.button_deleteRecord);
			this.Controls.Add(this.button_editRecord);
			this.Controls.Add(this.button_addRecord);
			this.Controls.Add(this.GridListStudents);
			this.Controls.Add(this.searchDataTextBox);
			this.Controls.Add(this.labelSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormCertification";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormCertification";
			this.Load += new System.EventHandler(this.FormCertification_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.subd_schoolDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridListCertification)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKcertificationstudentsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_deleteRecord;
		private System.Windows.Forms.Button button_editRecord;
		private System.Windows.Forms.Button button_addRecord;
		private System.Windows.Forms.TextBox searchDataTextBox;
		private System.Windows.Forms.Label labelSearch;
		public System.Windows.Forms.DataGridView GridListStudents;
		public System.Windows.Forms.DataGridView GridListCertification;
		private System.Windows.Forms.BindingSource bindingSource1;
		private subd_schoolDataSet subd_schoolDataSet;
		private System.Windows.Forms.BindingSource studentsBindingSource;
		private subd_schoolDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
		private System.Windows.Forms.BindingSource fKcertificationstudentsBindingSource;
		private subd_schoolDataSetTableAdapters.certificationTableAdapter certificationTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn subject;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstQuarter;
		private System.Windows.Forms.DataGridViewTextBoxColumn secondQuarter;
		private System.Windows.Forms.DataGridViewTextBoxColumn thirdQuarter;
		private System.Windows.Forms.DataGridViewTextBoxColumn fourthQuarter;
		private System.Windows.Forms.DataGridViewTextBoxColumn annual;
		private System.Windows.Forms.DataGridViewTextBoxColumn idstudent;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label1;
	}
}