
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
			this.GridListStudents = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataOfBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.image = new System.Windows.Forms.DataGridViewImageColumn();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GridListStudents
			// 
			this.GridListStudents.AllowUserToAddRows = false;
			this.GridListStudents.AllowUserToDeleteRows = false;
			this.GridListStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridListStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.GridListStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridListStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.patronymic,
            this.classNumber,
            this.dataOfBirthday,
            this.image});
			this.GridListStudents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridListStudents.Location = new System.Drawing.Point(0, 0);
			this.GridListStudents.Name = "GridListStudents";
			this.GridListStudents.ReadOnly = true;
			this.GridListStudents.RowHeadersWidth = 51;
			this.GridListStudents.RowTemplate.Height = 24;
			this.GridListStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridListStudents.Size = new System.Drawing.Size(1008, 414);
			this.GridListStudents.TabIndex = 0;
			// 
			// id
			// 
			this.id.FillWeight = 15F;
			this.id.HeaderText = "id";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// name
			// 
			this.name.FillWeight = 45F;
			this.name.HeaderText = "Имя";
			this.name.MinimumWidth = 6;
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// surname
			// 
			this.surname.FillWeight = 54.27807F;
			this.surname.HeaderText = "Фамилия";
			this.surname.MinimumWidth = 6;
			this.surname.Name = "surname";
			this.surname.ReadOnly = true;
			// 
			// patronymic
			// 
			this.patronymic.FillWeight = 54.27807F;
			this.patronymic.HeaderText = "Отчество";
			this.patronymic.MinimumWidth = 6;
			this.patronymic.Name = "patronymic";
			this.patronymic.ReadOnly = true;
			// 
			// classNumber
			// 
			this.classNumber.FillWeight = 40F;
			this.classNumber.HeaderText = "Класс";
			this.classNumber.MinimumWidth = 6;
			this.classNumber.Name = "classNumber";
			this.classNumber.ReadOnly = true;
			// 
			// dataOfBirthday
			// 
			this.dataOfBirthday.FillWeight = 54.27807F;
			this.dataOfBirthday.HeaderText = "Дата рождения";
			this.dataOfBirthday.MinimumWidth = 6;
			this.dataOfBirthday.Name = "dataOfBirthday";
			this.dataOfBirthday.ReadOnly = true;
			// 
			// image
			// 
			this.image.FillWeight = 54.27807F;
			this.image.HeaderText = "Фотография";
			this.image.MinimumWidth = 6;
			this.image.Name = "image";
			this.image.ReadOnly = true;
			this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.обновитьToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(1008, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(157, 414);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// добавитьToolStripMenuItem
			// 
			this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.добавитьToolStripMenuItem.Text = "Добавить";
			this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
			// 
			// редактироватьToolStripMenuItem
			// 
			this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
			this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.редактироватьToolStripMenuItem.Text = "Редактировать";
			this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// обновитьToolStripMenuItem
			// 
			this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
			this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.обновитьToolStripMenuItem.Text = "Обновить";
			this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
			// 
			// FormListStudents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1165, 414);
			this.Controls.Add(this.GridListStudents);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormListStudents";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Список учеников";
			this.Load += new System.EventHandler(this.ListStudents_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView GridListStudents;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn surname;
		private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
		private System.Windows.Forms.DataGridViewTextBoxColumn classNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataOfBirthday;
		private System.Windows.Forms.DataGridViewImageColumn image;
	}
}