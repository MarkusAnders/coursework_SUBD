
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classNagrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeNagrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.predmetNagrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.subd_schoolDataSet = new coursework.subd_schoolDataSet();
			this.lstudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lstudentsTableAdapter = new coursework.subd_schoolDataSetTableAdapters.lstudentsTableAdapter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataOfBirthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.subd_schoolDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lstudentsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.classNagrada,
            this.typeNagrada,
            this.predmetNagrada});
			this.dataGridView1.Location = new System.Drawing.Point(568, 86);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(442, 236);
			this.dataGridView1.TabIndex = 0;
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.Width = 125;
			// 
			// classNagrada
			// 
			this.classNagrada.HeaderText = "Класс награды";
			this.classNagrada.MinimumWidth = 6;
			this.classNagrada.Name = "classNagrada";
			this.classNagrada.Width = 125;
			// 
			// typeNagrada
			// 
			this.typeNagrada.HeaderText = "Тип награды";
			this.typeNagrada.MinimumWidth = 6;
			this.typeNagrada.Name = "typeNagrada";
			this.typeNagrada.Width = 125;
			// 
			// predmetNagrada
			// 
			this.predmetNagrada.HeaderText = "Предмет награды";
			this.predmetNagrada.MinimumWidth = 6;
			this.predmetNagrada.Name = "predmetNagrada";
			this.predmetNagrada.Width = 125;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(972, 453);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 41);
			this.button1.TabIndex = 1;
			this.button1.Text = "добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(972, 499);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 41);
			this.button2.TabIndex = 2;
			this.button2.Text = "изменить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(972, 545);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 41);
			this.button3.TabIndex = 3;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.dataOfBirthDayDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
			this.dataGridView2.DataSource = this.lstudentsBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(27, 25);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(442, 236);
			this.dataGridView2.TabIndex = 4;
			// 
			// subd_schoolDataSet
			// 
			this.subd_schoolDataSet.DataSetName = "subd_schoolDataSet";
			this.subd_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lstudentsBindingSource
			// 
			this.lstudentsBindingSource.DataMember = "lstudents";
			this.lstudentsBindingSource.DataSource = this.subd_schoolDataSet;
			// 
			// lstudentsTableAdapter
			// 
			this.lstudentsTableAdapter.ClearBeforeFill = true;
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
			this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
			this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
			// 
			// firstnameDataGridViewTextBoxColumn
			// 
			this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
			this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
			this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
			// 
			// patronymicDataGridViewTextBoxColumn
			// 
			this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "patronymic";
			this.patronymicDataGridViewTextBoxColumn.HeaderText = "patronymic";
			this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			// 
			// classDataGridViewTextBoxColumn
			// 
			this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
			this.classDataGridViewTextBoxColumn.HeaderText = "class";
			this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
			// 
			// dataOfBirthDayDataGridViewTextBoxColumn
			// 
			this.dataOfBirthDayDataGridViewTextBoxColumn.DataPropertyName = "dataOfBirthDay";
			this.dataOfBirthDayDataGridViewTextBoxColumn.HeaderText = "dataOfBirthDay";
			this.dataOfBirthDayDataGridViewTextBoxColumn.Name = "dataOfBirthDayDataGridViewTextBoxColumn";
			// 
			// imageDataGridViewImageColumn
			// 
			this.imageDataGridViewImageColumn.DataPropertyName = "image";
			this.imageDataGridViewImageColumn.HeaderText = "image";
			this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
			// 
			// FormAchievements
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1140, 609);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAchievements";
			this.Text = "FormAchievements";
			this.Load += new System.EventHandler(this.FormAchievements_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.subd_schoolDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lstudentsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn classNagrada;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeNagrada;
		private System.Windows.Forms.DataGridViewTextBoxColumn predmetNagrada;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView dataGridView2;
		private subd_schoolDataSet subd_schoolDataSet;
		private System.Windows.Forms.BindingSource lstudentsBindingSource;
		private subd_schoolDataSetTableAdapters.lstudentsTableAdapter lstudentsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataOfBirthDayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
	}
}