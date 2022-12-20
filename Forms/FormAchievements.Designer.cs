
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAchievements));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.GridListAchievements = new System.Windows.Forms.DataGridView();
			this.button_deleteRecord = new System.Windows.Forms.Button();
			this.button_editRecord = new System.Windows.Forms.Button();
			this.button_addRecord = new System.Windows.Forms.Button();
			this.GridListStudents = new System.Windows.Forms.DataGridView();
			this.searchDataTextBox = new System.Windows.Forms.TextBox();
			this.labelSearch = new System.Windows.Forms.Label();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.subd_schoolDataSet = new coursework.subd_schoolDataSet();
			((System.ComponentModel.ISupportInitialize)(this.GridListAchievements)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.subd_schoolDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// GridListAchievements
			// 
			this.GridListAchievements.AllowUserToAddRows = false;
			this.GridListAchievements.AllowUserToDeleteRows = false;
			this.GridListAchievements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GridListAchievements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridListAchievements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.GridListAchievements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridListAchievements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.GridListAchievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.GridListAchievements.DefaultCellStyle = dataGridViewCellStyle2;
			this.GridListAchievements.Location = new System.Drawing.Point(12, 328);
			this.GridListAchievements.Name = "GridListAchievements";
			this.GridListAchievements.ReadOnly = true;
			this.GridListAchievements.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.GridListAchievements.RowHeadersVisible = false;
			this.GridListAchievements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridListAchievements.Size = new System.Drawing.Size(917, 300);
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
			this.button_deleteRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_deleteRecord.Location = new System.Drawing.Point(954, 221);
			this.button_deleteRecord.Name = "button_deleteRecord";
			this.button_deleteRecord.Size = new System.Drawing.Size(215, 50);
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
			this.button_editRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_editRecord.Location = new System.Drawing.Point(954, 156);
			this.button_editRecord.Name = "button_editRecord";
			this.button_editRecord.Size = new System.Drawing.Size(215, 50);
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
			this.button_addRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_addRecord.Location = new System.Drawing.Point(954, 91);
			this.button_addRecord.Name = "button_addRecord";
			this.button_addRecord.Size = new System.Drawing.Size(215, 50);
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
			this.GridListStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridListStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.GridListStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridListStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.GridListStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.GridListStudents.DefaultCellStyle = dataGridViewCellStyle4;
			this.GridListStudents.Location = new System.Drawing.Point(12, 12);
			this.GridListStudents.Name = "GridListStudents";
			this.GridListStudents.ReadOnly = true;
			this.GridListStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.GridListStudents.RowHeadersVisible = false;
			this.GridListStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridListStudents.Size = new System.Drawing.Size(917, 300);
			this.GridListStudents.TabIndex = 15;
			// 
			// searchDataTextBox
			// 
			this.searchDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.searchDataTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.searchDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchDataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.searchDataTextBox.Location = new System.Drawing.Point(954, 49);
			this.searchDataTextBox.MaxLength = 40;
			this.searchDataTextBox.Multiline = true;
			this.searchDataTextBox.Name = "searchDataTextBox";
			this.searchDataTextBox.Size = new System.Drawing.Size(215, 27);
			this.searchDataTextBox.TabIndex = 14;
			// 
			// labelSearch
			// 
			this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSearch.AutoSize = true;
			this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSearch.ForeColor = System.Drawing.Color.Gainsboro;
			this.labelSearch.Location = new System.Drawing.Point(949, 12);
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
			// FormAchievements
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(1190, 640);
			this.Controls.Add(this.GridListAchievements);
			this.Controls.Add(this.button_deleteRecord);
			this.Controls.Add(this.button_editRecord);
			this.Controls.Add(this.button_addRecord);
			this.Controls.Add(this.GridListStudents);
			this.Controls.Add(this.searchDataTextBox);
			this.Controls.Add(this.labelSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAchievements";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAchievements";
			((System.ComponentModel.ISupportInitialize)(this.GridListAchievements)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.subd_schoolDataSet)).EndInit();
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
	}
}