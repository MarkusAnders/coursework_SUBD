
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.списокУчениковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокКлассовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокПредметовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокУчениковToolStripMenuItem,
            this.обновитьТаблицуToolStripMenuItem,
            this.списокКлассовToolStripMenuItem,
            this.списокПредметовToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1187, 30);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// списокУчениковToolStripMenuItem
			// 
			this.списокУчениковToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.списокУчениковToolStripMenuItem.Name = "списокУчениковToolStripMenuItem";
			this.списокУчениковToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
			this.списокУчениковToolStripMenuItem.Text = "Список учеников";
			this.списокУчениковToolStripMenuItem.Click += new System.EventHandler(this.списокУчениковToolStripMenuItem_Click);
			// 
			// обновитьТаблицуToolStripMenuItem
			// 
			this.обновитьТаблицуToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
			this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
			this.обновитьТаблицуToolStripMenuItem.Text = "Достижения учащихся ";
			// 
			// списокКлассовToolStripMenuItem
			// 
			this.списокКлассовToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.списокКлассовToolStripMenuItem.Name = "списокКлассовToolStripMenuItem";
			this.списокКлассовToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
			this.списокКлассовToolStripMenuItem.Text = "Список классов";
			this.списокКлассовToolStripMenuItem.Click += new System.EventHandler(this.списокКлассовToolStripMenuItem_Click);
			// 
			// списокПредметовToolStripMenuItem
			// 
			this.списокПредметовToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.списокПредметовToolStripMenuItem.Name = "списокПредметовToolStripMenuItem";
			this.списокПредметовToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
			this.списокПредметовToolStripMenuItem.Text = "Список предметов ";
			this.списокПредметовToolStripMenuItem.Click += new System.EventHandler(this.списокПредметовToolStripMenuItem_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1187, 626);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Главная страница АИС";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem списокКлассовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокПредметовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокУчениковToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
	}
}

