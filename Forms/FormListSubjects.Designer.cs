
namespace coursework
{
	partial class FormListSubjects
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListSubjects));
			this.labelSearch = new System.Windows.Forms.Label();
			this.searchDataTextBox = new System.Windows.Forms.TextBox();
			this.GridListSubjects = new System.Windows.Forms.DataGridView();
			this.button_addRecord = new System.Windows.Forms.Button();
			this.button_editRecord = new System.Windows.Forms.Button();
			this.button_deleteRecord = new System.Windows.Forms.Button();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hoursSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.GridListSubjects)).BeginInit();
			this.SuspendLayout();
			// 
			// labelSearch
			// 
			this.labelSearch.AutoSize = true;
			this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSearch.ForeColor = System.Drawing.Color.Gainsboro;
			this.labelSearch.Location = new System.Drawing.Point(12, 15);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(78, 25);
			this.labelSearch.TabIndex = 0;
			this.labelSearch.Text = "Поиск";
			// 
			// searchDataTextBox
			// 
			this.searchDataTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.searchDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchDataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.searchDataTextBox.Location = new System.Drawing.Point(97, 15);
			this.searchDataTextBox.MaxLength = 40;
			this.searchDataTextBox.Multiline = true;
			this.searchDataTextBox.Name = "searchDataTextBox";
			this.searchDataTextBox.Size = new System.Drawing.Size(320, 27);
			this.searchDataTextBox.TabIndex = 1;
			this.searchDataTextBox.TextChanged += new System.EventHandler(this.searchDataTextBox_TextChanged);
			// 
			// GridListSubjects
			// 
			this.GridListSubjects.AllowUserToAddRows = false;
			this.GridListSubjects.AllowUserToDeleteRows = false;
			this.GridListSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GridListSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridListSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.GridListSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridListSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.GridListSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridListSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameSubject,
            this.hoursSubject});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.GridListSubjects.DefaultCellStyle = dataGridViewCellStyle2;
			this.GridListSubjects.Location = new System.Drawing.Point(12, 57);
			this.GridListSubjects.Name = "GridListSubjects";
			this.GridListSubjects.ReadOnly = true;
			this.GridListSubjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.GridListSubjects.RowHeadersVisible = false;
			this.GridListSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridListSubjects.Size = new System.Drawing.Size(1166, 503);
			this.GridListSubjects.TabIndex = 2;
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
			this.button_addRecord.TabIndex = 3;
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
			this.button_editRecord.TabIndex = 4;
			this.button_editRecord.Text = "Информация ";
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
			this.button_deleteRecord.TabIndex = 5;
			this.button_deleteRecord.Text = "Удалить  ";
			this.button_deleteRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_deleteRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_deleteRecord.UseVisualStyleBackColor = true;
			this.button_deleteRecord.Click += new System.EventHandler(this.button_deleteRecord_Click);
			// 
			// id
			// 
			this.id.FillWeight = 25F;
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// nameSubject
			// 
			this.nameSubject.HeaderText = "Предмет";
			this.nameSubject.Name = "nameSubject";
			this.nameSubject.ReadOnly = true;
			// 
			// hoursSubject
			// 
			this.hoursSubject.HeaderText = "Кол-во часов";
			this.hoursSubject.Name = "hoursSubject";
			this.hoursSubject.ReadOnly = true;
			// 
			// FormListSubjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(1190, 640);
			this.Controls.Add(this.button_deleteRecord);
			this.Controls.Add(this.button_editRecord);
			this.Controls.Add(this.button_addRecord);
			this.Controls.Add(this.GridListSubjects);
			this.Controls.Add(this.searchDataTextBox);
			this.Controls.Add(this.labelSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormListSubjects";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormListSubjects";
			this.Load += new System.EventHandler(this.FormListSubjects_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridListSubjects)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelSearch;
		private System.Windows.Forms.TextBox searchDataTextBox;
		private System.Windows.Forms.DataGridView GridListSubjects;
		private System.Windows.Forms.Button button_addRecord;
		private System.Windows.Forms.Button button_editRecord;
		private System.Windows.Forms.Button button_deleteRecord;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameSubject;
		private System.Windows.Forms.DataGridViewTextBoxColumn hoursSubject;
	}
}