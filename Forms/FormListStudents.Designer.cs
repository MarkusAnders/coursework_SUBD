
namespace coursework
{
	partial class FormListStudents
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListStudents));
			this.GridListStudents = new System.Windows.Forms.DataGridView();
			this.button_addRecord = new System.Windows.Forms.Button();
			this.button_editRecord = new System.Windows.Forms.Button();
			this.button_deleteRecord = new System.Windows.Forms.Button();
			this.searchDataTextBox = new System.Windows.Forms.TextBox();
			this.labelSearch = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataOfBirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.image = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).BeginInit();
			this.SuspendLayout();
			// 
			// GridListStudents
			// 
			this.GridListStudents.AllowUserToAddRows = false;
			this.GridListStudents.AllowUserToDeleteRows = false;
			this.GridListStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GridListStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridListStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.GridListStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridListStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.GridListStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridListStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.surname,
            this.firstname,
            this.patronymic,
            this.gender,
            this.classNumber,
            this.dataOfBirthDay,
            this.image});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.GridListStudents.DefaultCellStyle = dataGridViewCellStyle2;
			this.GridListStudents.Location = new System.Drawing.Point(12, 57);
			this.GridListStudents.Name = "GridListStudents";
			this.GridListStudents.ReadOnly = true;
			this.GridListStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.GridListStudents.RowHeadersVisible = false;
			this.GridListStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridListStudents.Size = new System.Drawing.Size(1166, 503);
			this.GridListStudents.TabIndex = 0;
			// 
			// button_addRecord
			// 
			this.button_addRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_addRecord.FlatAppearance.BorderSize = 2;
			this.button_addRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_addRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_addRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_addRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_addRecord.Image")));
			this.button_addRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_addRecord.Location = new System.Drawing.Point(12, 578);
			this.button_addRecord.Name = "button_addRecord";
			this.button_addRecord.Size = new System.Drawing.Size(180, 50);
			this.button_addRecord.TabIndex = 1;
			this.button_addRecord.Text = "Добавить  ";
			this.button_addRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_addRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_addRecord.UseVisualStyleBackColor = true;
			this.button_addRecord.Click += new System.EventHandler(this.button_addRecord_Click);
			// 
			// button_editRecord
			// 
			this.button_editRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_editRecord.FlatAppearance.BorderSize = 2;
			this.button_editRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_editRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_editRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_editRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_editRecord.Image")));
			this.button_editRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_editRecord.Location = new System.Drawing.Point(198, 578);
			this.button_editRecord.Name = "button_editRecord";
			this.button_editRecord.Size = new System.Drawing.Size(180, 50);
			this.button_editRecord.TabIndex = 2;
			this.button_editRecord.Text = "Информация  ";
			this.button_editRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_editRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_editRecord.UseVisualStyleBackColor = true;
			this.button_editRecord.Click += new System.EventHandler(this.button_editRecord_Click);
			// 
			// button_deleteRecord
			// 
			this.button_deleteRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_deleteRecord.FlatAppearance.BorderSize = 2;
			this.button_deleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_deleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_deleteRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_deleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_deleteRecord.Image")));
			this.button_deleteRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_deleteRecord.Location = new System.Drawing.Point(384, 578);
			this.button_deleteRecord.Name = "button_deleteRecord";
			this.button_deleteRecord.Size = new System.Drawing.Size(180, 50);
			this.button_deleteRecord.TabIndex = 3;
			this.button_deleteRecord.Text = "Удалить  ";
			this.button_deleteRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_deleteRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_deleteRecord.UseVisualStyleBackColor = true;
			this.button_deleteRecord.Click += new System.EventHandler(this.button_deleteRecord_Click);
			// 
			// searchDataTextBox
			// 
			this.searchDataTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.searchDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchDataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.searchDataTextBox.Location = new System.Drawing.Point(97, 15);
			this.searchDataTextBox.MaxLength = 40;
			this.searchDataTextBox.Multiline = true;
			this.searchDataTextBox.Name = "searchDataTextBox";
			this.searchDataTextBox.Size = new System.Drawing.Size(320, 27);
			this.searchDataTextBox.TabIndex = 4;
			this.searchDataTextBox.TextChanged += new System.EventHandler(this.searchDataTextBox_TextChanged);
			// 
			// labelSearch
			// 
			this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSearch.AutoSize = true;
			this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
			this.labelSearch.ForeColor = System.Drawing.Color.Gainsboro;
			this.labelSearch.Location = new System.Drawing.Point(12, 15);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(79, 26);
			this.labelSearch.TabIndex = 5;
			this.labelSearch.Text = "Поиск";
			// 
			// id
			// 
			this.id.FillWeight = 25F;
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// surname
			// 
			this.surname.HeaderText = "Фамилия";
			this.surname.Name = "surname";
			this.surname.ReadOnly = true;
			// 
			// firstname
			// 
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
			// gender
			// 
			this.gender.HeaderText = "Пол";
			this.gender.Name = "gender";
			this.gender.ReadOnly = true;
			this.gender.Visible = false;
			// 
			// classNumber
			// 
			this.classNumber.FillWeight = 60F;
			this.classNumber.HeaderText = "Класс";
			this.classNumber.Name = "classNumber";
			this.classNumber.ReadOnly = true;
			// 
			// dataOfBirthDay
			// 
			this.dataOfBirthDay.HeaderText = "Дата рождения";
			this.dataOfBirthDay.Name = "dataOfBirthDay";
			this.dataOfBirthDay.ReadOnly = true;
			this.dataOfBirthDay.Visible = false;
			// 
			// image
			// 
			this.image.HeaderText = "Фото";
			this.image.Name = "image";
			this.image.ReadOnly = true;
			this.image.Visible = false;
			// 
			// FormListStudents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(1190, 640);
			this.Controls.Add(this.labelSearch);
			this.Controls.Add(this.searchDataTextBox);
			this.Controls.Add(this.button_deleteRecord);
			this.Controls.Add(this.button_editRecord);
			this.Controls.Add(this.button_addRecord);
			this.Controls.Add(this.GridListStudents);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(894, 476);
			this.Name = "FormListStudents";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FormListStudents_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView GridListStudents;
		private System.Windows.Forms.Button button_addRecord;
		private System.Windows.Forms.Button button_editRecord;
		private System.Windows.Forms.Button button_deleteRecord;
		private System.Windows.Forms.TextBox searchDataTextBox;
		private System.Windows.Forms.Label labelSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn surname;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
		private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
		private System.Windows.Forms.DataGridViewTextBoxColumn gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn classNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataOfBirthDay;
		private System.Windows.Forms.DataGridViewImageColumn image;
	}
}