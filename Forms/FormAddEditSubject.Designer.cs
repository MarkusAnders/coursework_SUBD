
namespace coursework
{
	partial class FormAddEditSubject
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditSubject));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.hourSubjectOfTextBox = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.nameSubjectTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panelMainTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.button_closeForm = new System.Windows.Forms.Button();
			this.button_editRecord = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panelMainTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.hourSubjectOfTextBox);
			this.groupBox3.Location = new System.Drawing.Point(12, 122);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(456, 60);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label3.ForeColor = System.Drawing.Color.Gainsboro;
			this.label3.Location = new System.Drawing.Point(6, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "Кол-во часов";
			// 
			// hourSubjectOfTextBox
			// 
			this.hourSubjectOfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hourSubjectOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.hourSubjectOfTextBox.Location = new System.Drawing.Point(217, 19);
			this.hourSubjectOfTextBox.MaxLength = 3;
			this.hourSubjectOfTextBox.Multiline = true;
			this.hourSubjectOfTextBox.Name = "hourSubjectOfTextBox";
			this.hourSubjectOfTextBox.Size = new System.Drawing.Size(231, 24);
			this.hourSubjectOfTextBox.TabIndex = 0;
			this.hourSubjectOfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hourSubjectOfTextBox_KeyPress);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.nameSubjectTextBox);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(12, 56);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(456, 60);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			// 
			// nameSubjectTextBox
			// 
			this.nameSubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nameSubjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.nameSubjectTextBox.Location = new System.Drawing.Point(217, 19);
			this.nameSubjectTextBox.MaxLength = 20;
			this.nameSubjectTextBox.Multiline = true;
			this.nameSubjectTextBox.Name = "nameSubjectTextBox";
			this.nameSubjectTextBox.Size = new System.Drawing.Size(231, 24);
			this.nameSubjectTextBox.TabIndex = 0;
			this.nameSubjectTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameSubjectTextBox_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.ForeColor = System.Drawing.Color.Gainsboro;
			this.label2.Location = new System.Drawing.Point(6, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(191, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Название предмета";
			// 
			// panelMainTitle
			// 
			this.panelMainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.panelMainTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelMainTitle.Controls.Add(this.labelTitle);
			this.panelMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMainTitle.Location = new System.Drawing.Point(0, 0);
			this.panelMainTitle.Name = "panelMainTitle";
			this.panelMainTitle.Size = new System.Drawing.Size(481, 50);
			this.panelMainTitle.TabIndex = 35;
			this.panelMainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMainTitle_MouseDown);
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Dungeon", 20F);
			this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
			this.labelTitle.Location = new System.Drawing.Point(77, 9);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(315, 30);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Редактирование информации";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_closeForm
			// 
			this.button_closeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_closeForm.FlatAppearance.BorderSize = 2;
			this.button_closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_closeForm.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_closeForm.Image = ((System.Drawing.Image)(resources.GetObject("button_closeForm.Image")));
			this.button_closeForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_closeForm.Location = new System.Drawing.Point(268, 200);
			this.button_closeForm.Name = "button_closeForm";
			this.button_closeForm.Size = new System.Drawing.Size(200, 50);
			this.button_closeForm.TabIndex = 3;
			this.button_closeForm.Text = "Закрыть  ";
			this.button_closeForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_closeForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_closeForm.UseVisualStyleBackColor = true;
			this.button_closeForm.Click += new System.EventHandler(this.button_closeForm_Click);
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
			this.button_editRecord.Location = new System.Drawing.Point(12, 200);
			this.button_editRecord.Name = "button_editRecord";
			this.button_editRecord.Size = new System.Drawing.Size(200, 50);
			this.button_editRecord.TabIndex = 2;
			this.button_editRecord.Text = "Редактировать  ";
			this.button_editRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_editRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_editRecord.UseVisualStyleBackColor = true;
			this.button_editRecord.Click += new System.EventHandler(this.button_editRecord_Click_1);
			// 
			// FormAddEditSubject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(481, 262);
			this.Controls.Add(this.button_editRecord);
			this.Controls.Add(this.button_closeForm);
			this.Controls.Add(this.panelMainTitle);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAddEditSubject";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAddEditSubject";
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panelMainTitle.ResumeLayout(false);
			this.panelMainTitle.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox hourSubjectOfTextBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox nameSubjectTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panelMainTitle;
		public System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Button button_closeForm;
		public System.Windows.Forms.Button button_editRecord;
	}
}