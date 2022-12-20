
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
			this.panelMenu = new System.Windows.Forms.Panel();
			this.button_listSubjects = new System.Windows.Forms.Button();
			this.button_listStudents = new System.Windows.Forms.Button();
			this.button_achievements = new System.Windows.Forms.Button();
			this.button_certification = new System.Windows.Forms.Button();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.button_minimize = new System.Windows.Forms.Button();
			this.button_maximize = new System.Windows.Forms.Button();
			this.button_exit = new System.Windows.Forms.Button();
			this.button_closeChildForm = new System.Windows.Forms.Button();
			this.labelTitle = new System.Windows.Forms.Label();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.panelMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelMenu.Controls.Add(this.button_listSubjects);
			this.panelMenu.Controls.Add(this.button_listStudents);
			this.panelMenu.Controls.Add(this.button_achievements);
			this.panelMenu.Controls.Add(this.button_certification);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(250, 710);
			this.panelMenu.TabIndex = 0;
			// 
			// button_listSubjects
			// 
			this.button_listSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.button_listSubjects.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_listSubjects.FlatAppearance.BorderSize = 0;
			this.button_listSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_listSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_listSubjects.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_listSubjects.Image = ((System.Drawing.Image)(resources.GetObject("button_listSubjects.Image")));
			this.button_listSubjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_listSubjects.Location = new System.Drawing.Point(0, 220);
			this.button_listSubjects.Name = "button_listSubjects";
			this.button_listSubjects.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button_listSubjects.Size = new System.Drawing.Size(248, 50);
			this.button_listSubjects.TabIndex = 4;
			this.button_listSubjects.Text = "  Список предметов";
			this.button_listSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_listSubjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button_listSubjects.UseVisualStyleBackColor = false;
			this.button_listSubjects.Click += new System.EventHandler(this.button_listSubjects_Click);
			// 
			// button_listStudents
			// 
			this.button_listStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.button_listStudents.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_listStudents.FlatAppearance.BorderSize = 0;
			this.button_listStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_listStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_listStudents.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_listStudents.Image = ((System.Drawing.Image)(resources.GetObject("button_listStudents.Image")));
			this.button_listStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_listStudents.Location = new System.Drawing.Point(0, 170);
			this.button_listStudents.Name = "button_listStudents";
			this.button_listStudents.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button_listStudents.Size = new System.Drawing.Size(248, 50);
			this.button_listStudents.TabIndex = 3;
			this.button_listStudents.Text = "  Список учеников";
			this.button_listStudents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_listStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button_listStudents.UseVisualStyleBackColor = false;
			this.button_listStudents.Click += new System.EventHandler(this.button_listStudents_Click);
			// 
			// button_achievements
			// 
			this.button_achievements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.button_achievements.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_achievements.FlatAppearance.BorderSize = 0;
			this.button_achievements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_achievements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_achievements.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_achievements.Image = ((System.Drawing.Image)(resources.GetObject("button_achievements.Image")));
			this.button_achievements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_achievements.Location = new System.Drawing.Point(0, 120);
			this.button_achievements.Name = "button_achievements";
			this.button_achievements.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button_achievements.Size = new System.Drawing.Size(248, 50);
			this.button_achievements.TabIndex = 2;
			this.button_achievements.Text = "  Достижения";
			this.button_achievements.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_achievements.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button_achievements.UseVisualStyleBackColor = false;
			this.button_achievements.Click += new System.EventHandler(this.button_achievements_Click);
			// 
			// button_certification
			// 
			this.button_certification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.button_certification.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_certification.FlatAppearance.BorderSize = 0;
			this.button_certification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_certification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_certification.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_certification.Image = ((System.Drawing.Image)(resources.GetObject("button_certification.Image")));
			this.button_certification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_certification.Location = new System.Drawing.Point(0, 70);
			this.button_certification.Name = "button_certification";
			this.button_certification.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button_certification.Size = new System.Drawing.Size(248, 50);
			this.button_certification.TabIndex = 1;
			this.button_certification.Text = "  Аттестация";
			this.button_certification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_certification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button_certification.UseVisualStyleBackColor = false;
			this.button_certification.Click += new System.EventHandler(this.button_certification_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.panelLogo.Controls.Add(this.label1);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(248, 70);
			this.panelLogo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightGray;
			this.label1.Location = new System.Drawing.Point(78, 29);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(102, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "AIS SCHOOL";
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
			this.panelTitle.Controls.Add(this.button_minimize);
			this.panelTitle.Controls.Add(this.button_maximize);
			this.panelTitle.Controls.Add(this.button_exit);
			this.panelTitle.Controls.Add(this.button_closeChildForm);
			this.panelTitle.Controls.Add(this.labelTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(250, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(1190, 70);
			this.panelTitle.TabIndex = 1;
			this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
			// 
			// button_minimize
			// 
			this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_minimize.FlatAppearance.BorderSize = 0;
			this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_minimize.ForeColor = System.Drawing.Color.White;
			this.button_minimize.Location = new System.Drawing.Point(1073, 0);
			this.button_minimize.Name = "button_minimize";
			this.button_minimize.Size = new System.Drawing.Size(35, 35);
			this.button_minimize.TabIndex = 3;
			this.button_minimize.Text = "O";
			this.button_minimize.UseVisualStyleBackColor = true;
			this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
			// 
			// button_maximize
			// 
			this.button_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_maximize.FlatAppearance.BorderSize = 0;
			this.button_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_maximize.ForeColor = System.Drawing.Color.White;
			this.button_maximize.Location = new System.Drawing.Point(1114, 0);
			this.button_maximize.Name = "button_maximize";
			this.button_maximize.Size = new System.Drawing.Size(35, 35);
			this.button_maximize.TabIndex = 2;
			this.button_maximize.Text = "O";
			this.button_maximize.UseVisualStyleBackColor = true;
			this.button_maximize.Click += new System.EventHandler(this.button_maximize_Click);
			// 
			// button_exit
			// 
			this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_exit.FlatAppearance.BorderSize = 0;
			this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_exit.ForeColor = System.Drawing.Color.White;
			this.button_exit.Location = new System.Drawing.Point(1155, 0);
			this.button_exit.Name = "button_exit";
			this.button_exit.Size = new System.Drawing.Size(35, 35);
			this.button_exit.TabIndex = 0;
			this.button_exit.Text = "O";
			this.button_exit.UseVisualStyleBackColor = true;
			this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
			// 
			// button_closeChildForm
			// 
			this.button_closeChildForm.Dock = System.Windows.Forms.DockStyle.Left;
			this.button_closeChildForm.FlatAppearance.BorderSize = 0;
			this.button_closeChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_closeChildForm.Image = ((System.Drawing.Image)(resources.GetObject("button_closeChildForm.Image")));
			this.button_closeChildForm.Location = new System.Drawing.Point(0, 0);
			this.button_closeChildForm.Name = "button_closeChildForm";
			this.button_closeChildForm.Size = new System.Drawing.Size(75, 70);
			this.button_closeChildForm.TabIndex = 1;
			this.button_closeChildForm.UseVisualStyleBackColor = true;
			this.button_closeChildForm.Click += new System.EventHandler(this.button_closeChildForm_Click);
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.Color.White;
			this.labelTitle.Location = new System.Drawing.Point(508, 22);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(139, 30);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "ГЛАВНАЯ";
			// 
			// panelChildForm
			// 
			this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChildForm.Location = new System.Drawing.Point(250, 70);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(1190, 640);
			this.panelChildForm.TabIndex = 2;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
			this.ClientSize = new System.Drawing.Size(1440, 710);
			this.Controls.Add(this.panelChildForm);
			this.Controls.Add(this.panelTitle);
			this.Controls.Add(this.panelMenu);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(1212, 691);
			this.Name = "FormMain";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.panelMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelLogo.PerformLayout();
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Button button_certification;
		private System.Windows.Forms.Panel panelChildForm;
		private System.Windows.Forms.Button button_listSubjects;
		private System.Windows.Forms.Button button_listStudents;
		private System.Windows.Forms.Button button_achievements;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_closeChildForm;
		private System.Windows.Forms.Button button_minimize;
		private System.Windows.Forms.Button button_maximize;
		private System.Windows.Forms.Button button_exit;
	}
}

