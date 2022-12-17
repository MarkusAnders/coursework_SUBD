
namespace coursework
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_listSubjects = new System.Windows.Forms.Button();
			this.button_achievementStudent = new System.Windows.Forms.Button();
			this.button_listStudent = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(262, 49);
			this.panel4.TabIndex = 6;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(885, 50);
			this.panel3.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Dungeon", 20F);
			this.label1.ForeColor = System.Drawing.Color.Gainsboro;
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Главная страница АИС";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button_listSubjects);
			this.panel1.Controls.Add(this.button_achievementStudent);
			this.panel1.Controls.Add(this.button_listStudent);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(885, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.panel1.Size = new System.Drawing.Size(264, 638);
			this.panel1.TabIndex = 6;
			// 
			// button_listSubjects
			// 
			this.button_listSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button_listSubjects.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_listSubjects.FlatAppearance.BorderSize = 0;
			this.button_listSubjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(243)))));
			this.button_listSubjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.button_listSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_listSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_listSubjects.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_listSubjects.Image = ((System.Drawing.Image)(resources.GetObject("button_listSubjects.Image")));
			this.button_listSubjects.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_listSubjects.Location = new System.Drawing.Point(0, 149);
			this.button_listSubjects.Name = "button_listSubjects";
			this.button_listSubjects.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button_listSubjects.Size = new System.Drawing.Size(262, 50);
			this.button_listSubjects.TabIndex = 9;
			this.button_listSubjects.Text = "Список предметов  ";
			this.button_listSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_listSubjects.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_listSubjects.UseVisualStyleBackColor = true;
			this.button_listSubjects.Click += new System.EventHandler(this.button_listSubjects_Click);
			// 
			// button_achievementStudent
			// 
			this.button_achievementStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button_achievementStudent.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_achievementStudent.FlatAppearance.BorderSize = 0;
			this.button_achievementStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(243)))));
			this.button_achievementStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.button_achievementStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_achievementStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_achievementStudent.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_achievementStudent.Image = ((System.Drawing.Image)(resources.GetObject("button_achievementStudent.Image")));
			this.button_achievementStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_achievementStudent.Location = new System.Drawing.Point(0, 99);
			this.button_achievementStudent.Name = "button_achievementStudent";
			this.button_achievementStudent.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button_achievementStudent.Size = new System.Drawing.Size(262, 50);
			this.button_achievementStudent.TabIndex = 8;
			this.button_achievementStudent.Text = "Достижения учеников  ";
			this.button_achievementStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_achievementStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_achievementStudent.UseVisualStyleBackColor = true;
			this.button_achievementStudent.Click += new System.EventHandler(this.button_achievementStudent_Click);
			// 
			// button_listStudent
			// 
			this.button_listStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button_listStudent.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_listStudent.FlatAppearance.BorderSize = 0;
			this.button_listStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(243)))));
			this.button_listStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.button_listStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_listStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_listStudent.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_listStudent.Image = ((System.Drawing.Image)(resources.GetObject("button_listStudent.Image")));
			this.button_listStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_listStudent.Location = new System.Drawing.Point(0, 49);
			this.button_listStudent.Name = "button_listStudent";
			this.button_listStudent.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button_listStudent.Size = new System.Drawing.Size(262, 50);
			this.button_listStudent.TabIndex = 7;
			this.button_listStudent.Text = "Список учеников  ";
			this.button_listStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_listStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_listStudent.UseVisualStyleBackColor = true;
			this.button_listStudent.Click += new System.EventHandler(this.button_listStudent_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1149, 638);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(1112, 641);
			this.Name = "FormMain";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button_achievementStudent;
		private System.Windows.Forms.Button button_listSubjects;
		public System.Windows.Forms.Button button_listStudent;
	}
}

