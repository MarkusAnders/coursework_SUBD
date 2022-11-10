
namespace coursework
{
	partial class ListSubjects
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GridListSubjects = new System.Windows.Forms.DataGridView();
			this.Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GridListSubjects)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 31);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// закрытьToolStripMenuItem
			// 
			this.закрытьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
			this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(88, 27);
			this.закрытьToolStripMenuItem.Text = "Закрыть";
			this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
			// 
			// GridListSubjects
			// 
			this.GridListSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridListSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subjects,
            this.Hours});
			this.GridListSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridListSubjects.Location = new System.Drawing.Point(0, 31);
			this.GridListSubjects.Name = "GridListSubjects";
			this.GridListSubjects.RowHeadersWidth = 51;
			this.GridListSubjects.RowTemplate.Height = 24;
			this.GridListSubjects.Size = new System.Drawing.Size(800, 419);
			this.GridListSubjects.TabIndex = 1;
			// 
			// Subjects
			// 
			this.Subjects.HeaderText = "Предмет";
			this.Subjects.MinimumWidth = 6;
			this.Subjects.Name = "Subjects";
			this.Subjects.Width = 200;
			// 
			// Hours
			// 
			this.Hours.HeaderText = "Кол-во часов";
			this.Hours.MinimumWidth = 6;
			this.Hours.Name = "Hours";
			this.Hours.Width = 125;
			// 
			// ListSubjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.GridListSubjects);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ListSubjects";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Список предметов";
			this.Load += new System.EventHandler(this.ListSubjects_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GridListSubjects)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
		private System.Windows.Forms.DataGridView GridListSubjects;
		private System.Windows.Forms.DataGridViewTextBoxColumn Subjects;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
	}
}