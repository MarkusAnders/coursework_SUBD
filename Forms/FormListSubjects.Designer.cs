
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.searchDateInTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.GridListSubjects = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_closeForm = new System.Windows.Forms.Button();
			this.button_deleteRecord = new System.Windows.Forms.Button();
			this.button_editRecord = new System.Windows.Forms.Button();
			this.button_addRecord = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GridListSubjects)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.panel3.Controls.Add(this.searchDateInTextBox);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(823, 50);
			this.panel3.TabIndex = 5;
			// 
			// searchDateInTextBox
			// 
			this.searchDateInTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.searchDateInTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.searchDateInTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchDateInTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.searchDateInTextBox.Location = new System.Drawing.Point(552, 17);
			this.searchDateInTextBox.MaxLength = 30;
			this.searchDateInTextBox.Multiline = true;
			this.searchDateInTextBox.Name = "searchDateInTextBox";
			this.searchDateInTextBox.Size = new System.Drawing.Size(266, 22);
			this.searchDateInTextBox.TabIndex = 13;
			this.searchDateInTextBox.Text = "Поиск";
			this.searchDateInTextBox.Click += new System.EventHandler(this.searchDateInTextBox_Click);
			this.searchDateInTextBox.TextChanged += new System.EventHandler(this.searchDateInTextBox_TextChanged);
			this.searchDateInTextBox.Leave += new System.EventHandler(this.searchDateInTextBox_Leave);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Dungeon", 20F);
			this.label1.ForeColor = System.Drawing.Color.Gainsboro;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(294, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Список учебных предметов";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.GridListSubjects);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(823, 508);
			this.panel2.TabIndex = 6;
			// 
			// GridListSubjects
			// 
			this.GridListSubjects.AllowUserToAddRows = false;
			this.GridListSubjects.AllowUserToDeleteRows = false;
			this.GridListSubjects.AllowUserToResizeColumns = false;
			this.GridListSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridListSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.GridListSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.GridListSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridListSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.GridListSubjects.ColumnHeadersHeight = 29;
			this.GridListSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Subjects,
            this.Hours});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.GridListSubjects.DefaultCellStyle = dataGridViewCellStyle2;
			this.GridListSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridListSubjects.GridColor = System.Drawing.Color.Gainsboro;
			this.GridListSubjects.Location = new System.Drawing.Point(0, 50);
			this.GridListSubjects.Name = "GridListSubjects";
			this.GridListSubjects.ReadOnly = true;
			this.GridListSubjects.RowHeadersVisible = false;
			this.GridListSubjects.RowHeadersWidth = 51;
			this.GridListSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridListSubjects.Size = new System.Drawing.Size(823, 458);
			this.GridListSubjects.TabIndex = 6;
			// 
			// id
			// 
			this.id.FillWeight = 20F;
			this.id.HeaderText = "id";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// Subjects
			// 
			this.Subjects.FillWeight = 110F;
			this.Subjects.HeaderText = "Название предмета";
			this.Subjects.MinimumWidth = 6;
			this.Subjects.Name = "Subjects";
			this.Subjects.ReadOnly = true;
			// 
			// Hours
			// 
			this.Hours.HeaderText = "Кол-во часов";
			this.Hours.MinimumWidth = 6;
			this.Hours.Name = "Hours";
			this.Hours.ReadOnly = true;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(189, 49);
			this.panel4.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button_closeForm);
			this.panel1.Controls.Add(this.button_deleteRecord);
			this.panel1.Controls.Add(this.button_editRecord);
			this.panel1.Controls.Add(this.button_addRecord);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(823, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.panel1.Size = new System.Drawing.Size(191, 508);
			this.panel1.TabIndex = 5;
			// 
			// button_closeForm
			// 
			this.button_closeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.button_closeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button_closeForm.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_closeForm.FlatAppearance.BorderSize = 0;
			this.button_closeForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(243)))));
			this.button_closeForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.button_closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_closeForm.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_closeForm.Image = ((System.Drawing.Image)(resources.GetObject("button_closeForm.Image")));
			this.button_closeForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_closeForm.Location = new System.Drawing.Point(0, 199);
			this.button_closeForm.Name = "button_closeForm";
			this.button_closeForm.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button_closeForm.Size = new System.Drawing.Size(189, 50);
			this.button_closeForm.TabIndex = 16;
			this.button_closeForm.Text = "Закрыть  ";
			this.button_closeForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_closeForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_closeForm.UseVisualStyleBackColor = false;
			this.button_closeForm.Click += new System.EventHandler(this.button_closeForm_Click);
			// 
			// button_deleteRecord
			// 
			this.button_deleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.button_deleteRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button_deleteRecord.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_deleteRecord.FlatAppearance.BorderSize = 0;
			this.button_deleteRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(243)))));
			this.button_deleteRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.button_deleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_deleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_deleteRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_deleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_deleteRecord.Image")));
			this.button_deleteRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_deleteRecord.Location = new System.Drawing.Point(0, 149);
			this.button_deleteRecord.Name = "button_deleteRecord";
			this.button_deleteRecord.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button_deleteRecord.Size = new System.Drawing.Size(189, 50);
			this.button_deleteRecord.TabIndex = 15;
			this.button_deleteRecord.Text = "Удалить  ";
			this.button_deleteRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_deleteRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_deleteRecord.UseVisualStyleBackColor = false;
			this.button_deleteRecord.Click += new System.EventHandler(this.button_deleteRecord_Click_1);
			// 
			// button_editRecord
			// 
			this.button_editRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.button_editRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button_editRecord.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_editRecord.FlatAppearance.BorderSize = 0;
			this.button_editRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(243)))));
			this.button_editRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.button_editRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_editRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_editRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_editRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_editRecord.Image")));
			this.button_editRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_editRecord.Location = new System.Drawing.Point(0, 99);
			this.button_editRecord.Name = "button_editRecord";
			this.button_editRecord.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button_editRecord.Size = new System.Drawing.Size(189, 50);
			this.button_editRecord.TabIndex = 13;
			this.button_editRecord.Text = "Информация  ";
			this.button_editRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_editRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_editRecord.UseVisualStyleBackColor = false;
			this.button_editRecord.Click += new System.EventHandler(this.button_editRecord_Click_1);
			// 
			// button_addRecord
			// 
			this.button_addRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button_addRecord.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_addRecord.FlatAppearance.BorderSize = 0;
			this.button_addRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(243)))));
			this.button_addRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.button_addRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_addRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_addRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_addRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_addRecord.Image")));
			this.button_addRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_addRecord.Location = new System.Drawing.Point(0, 49);
			this.button_addRecord.Name = "button_addRecord";
			this.button_addRecord.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button_addRecord.Size = new System.Drawing.Size(189, 50);
			this.button_addRecord.TabIndex = 12;
			this.button_addRecord.Text = "Добавить  ";
			this.button_addRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_addRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_addRecord.UseVisualStyleBackColor = true;
			this.button_addRecord.Click += new System.EventHandler(this.button_addRecord_Click_1);
			// 
			// FormListSubjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(1014, 508);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(900, 480);
			this.Name = "FormListSubjects";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FormListSubjects_Load);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GridListSubjects)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView GridListSubjects;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Subjects;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
		private System.Windows.Forms.TextBox searchDateInTextBox;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button_closeForm;
		private System.Windows.Forms.Button button_deleteRecord;
		private System.Windows.Forms.Button button_editRecord;
		private System.Windows.Forms.Button button_addRecord;
	}
}