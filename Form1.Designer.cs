
namespace coursework
{
	partial class MainForm
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
			this.дневникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокКлассовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокПредметовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокУчениковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дневникToolStripMenuItem,
            this.списокКлассовToolStripMenuItem,
            this.списокПредметовToolStripMenuItem,
            this.списокУчениковToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1187, 31);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// дневникToolStripMenuItem
			// 
			this.дневникToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.дневникToolStripMenuItem.Name = "дневникToolStripMenuItem";
			this.дневникToolStripMenuItem.Size = new System.Drawing.Size(92, 27);
			this.дневникToolStripMenuItem.Text = "Дневник";
			// 
			// списокКлассовToolStripMenuItem
			// 
			this.списокКлассовToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.списокКлассовToolStripMenuItem.Name = "списокКлассовToolStripMenuItem";
			this.списокКлассовToolStripMenuItem.Size = new System.Drawing.Size(147, 27);
			this.списокКлассовToolStripMenuItem.Text = "Список классов";
			// 
			// списокПредметовToolStripMenuItem
			// 
			this.списокПредметовToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.списокПредметовToolStripMenuItem.Name = "списокПредметовToolStripMenuItem";
			this.списокПредметовToolStripMenuItem.Size = new System.Drawing.Size(176, 27);
			this.списокПредметовToolStripMenuItem.Text = "Список предметов ";
			// 
			// списокУчениковToolStripMenuItem
			// 
			this.списокУчениковToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.списокУчениковToolStripMenuItem.Name = "списокУчениковToolStripMenuItem";
			this.списокУчениковToolStripMenuItem.Size = new System.Drawing.Size(160, 27);
			this.списокУчениковToolStripMenuItem.Text = "Список учеников";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1187, 626);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
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
		private System.Windows.Forms.ToolStripMenuItem дневникToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокКлассовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокПредметовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокУчениковToolStripMenuItem;
	}
}

