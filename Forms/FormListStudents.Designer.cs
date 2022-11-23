
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListStudents));
			this.GridListStudents = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataOfBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.image = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.GridListStudents)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GridListStudents
			// 
			this.GridListStudents.AllowUserToAddRows = false;
			this.GridListStudents.AllowUserToDeleteRows = false;
			this.GridListStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridListStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
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
			this.GridListStudents.Size = new System.Drawing.Size(1020, 414);
			this.GridListStudents.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.обновитьToolStripMenuItem});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
			this.menuStrip1.Location = new System.Drawing.Point(1020, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(145, 414);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// добавитьToolStripMenuItem
			// 
			this.добавитьToolStripMenuItem.AutoSize = false;
			this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			this.добавитьToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(145, 50);
			this.добавитьToolStripMenuItem.Text = "Добавить";
			this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
			// 
			// редактироватьToolStripMenuItem
			// 
			this.редактироватьToolStripMenuItem.AutoSize = false;
			this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
			this.редактироватьToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(145, 50);
			this.редактироватьToolStripMenuItem.Text = "Редактировать";
			this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.AutoSize = false;
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(145, 50);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// обновитьToolStripMenuItem
			// 
			this.обновитьToolStripMenuItem.AutoSize = false;
			this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
			this.обновитьToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(145, 50);
			this.обновитьToolStripMenuItem.Text = "Обновить";
			this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
			// 
			// id
			// 
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.id.DefaultCellStyle = dataGridViewCellStyle1;
			this.id.FillWeight = 15F;
			this.id.HeaderText = "id";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// name
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			this.name.DefaultCellStyle = dataGridViewCellStyle2;
			this.name.FillWeight = 40F;
			this.name.HeaderText = "Имя";
			this.name.MinimumWidth = 6;
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// surname
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			this.surname.DefaultCellStyle = dataGridViewCellStyle3;
			this.surname.FillWeight = 50F;
			this.surname.HeaderText = "Фамилия";
			this.surname.MinimumWidth = 6;
			this.surname.Name = "surname";
			this.surname.ReadOnly = true;
			// 
			// patronymic
			// 
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.patronymic.DefaultCellStyle = dataGridViewCellStyle4;
			this.patronymic.FillWeight = 53F;
			this.patronymic.HeaderText = "Отчество";
			this.patronymic.MinimumWidth = 6;
			this.patronymic.Name = "patronymic";
			this.patronymic.ReadOnly = true;
			// 
			// classNumber
			// 
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrange;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			this.classNumber.DefaultCellStyle = dataGridViewCellStyle5;
			this.classNumber.FillWeight = 25F;
			this.classNumber.HeaderText = "Класс";
			this.classNumber.MinimumWidth = 6;
			this.classNumber.Name = "classNumber";
			this.classNumber.ReadOnly = true;
			// 
			// dataOfBirthday
			// 
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkOrange;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
			this.dataOfBirthday.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataOfBirthday.FillWeight = 50F;
			this.dataOfBirthday.HeaderText = "Дата рождения";
			this.dataOfBirthday.MinimumWidth = 6;
			this.dataOfBirthday.Name = "dataOfBirthday";
			this.dataOfBirthday.ReadOnly = true;
			// 
			// image
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkOrange;
			this.image.DefaultCellStyle = dataGridViewCellStyle7;
			this.image.FillWeight = 54.27807F;
			this.image.HeaderText = "Фотография";
			this.image.MinimumWidth = 6;
			this.image.Name = "image";
			this.image.ReadOnly = true;
			this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
		private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn surname;
		private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
		private System.Windows.Forms.DataGridViewTextBoxColumn classNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataOfBirthday;
		private System.Windows.Forms.DataGridViewImageColumn image;
	}
}