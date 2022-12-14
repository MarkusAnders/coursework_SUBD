
namespace coursework
{
	partial class FormAddEditAchievements
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditAchievements));
			this.panelMainTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.button_exitFromFrom = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.listSubjectsBox = new System.Windows.Forms.ComboBox();
			this.academicsubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.subd_schoolDataSet = new coursework.subd_schoolDataSet();
			this.label4 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.classOfRewardOfTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.typeOfRewardOfTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button_editRecord = new System.Windows.Forms.Button();
			this.academic_subjectTableAdapter = new coursework.subd_schoolDataSetTableAdapters.academic_subjectTableAdapter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.nameOfRewardOfTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelMainTitle.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.academicsubjectBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.subd_schoolDataSet)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMainTitle
			// 
			this.panelMainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.panelMainTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelMainTitle.Controls.Add(this.labelTitle);
			this.panelMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMainTitle.Location = new System.Drawing.Point(0, 0);
			this.panelMainTitle.Name = "panelMainTitle";
			this.panelMainTitle.Size = new System.Drawing.Size(496, 50);
			this.panelMainTitle.TabIndex = 1;
			this.panelMainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMainTitle_MouseDown);
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Dungeon", 20F);
			this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
			this.labelTitle.Location = new System.Drawing.Point(92, 8);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(307, 30);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Редактирование достижений";
			// 
			// button_exitFromFrom
			// 
			this.button_exitFromFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.button_exitFromFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button_exitFromFrom.FlatAppearance.BorderSize = 2;
			this.button_exitFromFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_exitFromFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_exitFromFrom.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_exitFromFrom.Image = ((System.Drawing.Image)(resources.GetObject("button_exitFromFrom.Image")));
			this.button_exitFromFrom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_exitFromFrom.Location = new System.Drawing.Point(272, 272);
			this.button_exitFromFrom.Name = "button_exitFromFrom";
			this.button_exitFromFrom.Size = new System.Drawing.Size(207, 50);
			this.button_exitFromFrom.TabIndex = 4;
			this.button_exitFromFrom.Text = "Закрыть  ";
			this.button_exitFromFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_exitFromFrom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_exitFromFrom.UseVisualStyleBackColor = false;
			this.button_exitFromFrom.Click += new System.EventHandler(this.button_exitFromFrom_Click);
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.listSubjectsBox);
			this.panel6.Controls.Add(this.label4);
			this.panel6.Location = new System.Drawing.Point(12, 213);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(467, 44);
			this.panel6.TabIndex = 2;
			// 
			// listSubjectsBox
			// 
			this.listSubjectsBox.DataSource = this.academicsubjectBindingSource;
			this.listSubjectsBox.DisplayMember = "subject";
			this.listSubjectsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.listSubjectsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.listSubjectsBox.FormattingEnabled = true;
			this.listSubjectsBox.Location = new System.Drawing.Point(226, 8);
			this.listSubjectsBox.Name = "listSubjectsBox";
			this.listSubjectsBox.Size = new System.Drawing.Size(231, 28);
			this.listSubjectsBox.TabIndex = 0;
			this.listSubjectsBox.ValueMember = "subject";
			// 
			// academicsubjectBindingSource
			// 
			this.academicsubjectBindingSource.DataMember = "academic_subject";
			this.academicsubjectBindingSource.DataSource = this.subd_schoolDataSet;
			// 
			// subd_schoolDataSet
			// 
			this.subd_schoolDataSet.DataSetName = "subd_schoolDataSet";
			this.subd_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label4.ForeColor = System.Drawing.Color.Gainsboro;
			this.label4.Location = new System.Drawing.Point(16, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 24);
			this.label4.TabIndex = 8;
			this.label4.Text = "Предмет награды";
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.classOfRewardOfTextBox);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Location = new System.Drawing.Point(12, 113);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(467, 44);
			this.panel5.TabIndex = 0;
			// 
			// classOfRewardOfTextBox
			// 
			this.classOfRewardOfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.classOfRewardOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.classOfRewardOfTextBox.Location = new System.Drawing.Point(226, 8);
			this.classOfRewardOfTextBox.MaxLength = 30;
			this.classOfRewardOfTextBox.Multiline = true;
			this.classOfRewardOfTextBox.Name = "classOfRewardOfTextBox";
			this.classOfRewardOfTextBox.Size = new System.Drawing.Size(231, 24);
			this.classOfRewardOfTextBox.TabIndex = 0;
			this.classOfRewardOfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.classOfRewardOfTextBox_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label3.ForeColor = System.Drawing.Color.Gainsboro;
			this.label3.Location = new System.Drawing.Point(16, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "Класс награды";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.typeOfRewardOfTextBox);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(12, 163);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(467, 44);
			this.panel2.TabIndex = 1;
			// 
			// typeOfRewardOfTextBox
			// 
			this.typeOfRewardOfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.typeOfRewardOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.typeOfRewardOfTextBox.Location = new System.Drawing.Point(226, 8);
			this.typeOfRewardOfTextBox.MaxLength = 20;
			this.typeOfRewardOfTextBox.Multiline = true;
			this.typeOfRewardOfTextBox.Name = "typeOfRewardOfTextBox";
			this.typeOfRewardOfTextBox.Size = new System.Drawing.Size(231, 24);
			this.typeOfRewardOfTextBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.ForeColor = System.Drawing.Color.Gainsboro;
			this.label2.Location = new System.Drawing.Point(16, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Тип награды";
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
			this.button_editRecord.Location = new System.Drawing.Point(12, 272);
			this.button_editRecord.Name = "button_editRecord";
			this.button_editRecord.Size = new System.Drawing.Size(207, 50);
			this.button_editRecord.TabIndex = 3;
			this.button_editRecord.Text = "Редактировать  ";
			this.button_editRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_editRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_editRecord.UseVisualStyleBackColor = true;
			this.button_editRecord.Click += new System.EventHandler(this.button_editRecord_Click_1);
			// 
			// academic_subjectTableAdapter
			// 
			this.academic_subjectTableAdapter.ClearBeforeFill = true;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.nameOfRewardOfTextBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(467, 44);
			this.panel1.TabIndex = 1;
			// 
			// nameOfRewardOfTextBox
			// 
			this.nameOfRewardOfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nameOfRewardOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.nameOfRewardOfTextBox.Location = new System.Drawing.Point(226, 8);
			this.nameOfRewardOfTextBox.MaxLength = 30;
			this.nameOfRewardOfTextBox.Multiline = true;
			this.nameOfRewardOfTextBox.Name = "nameOfRewardOfTextBox";
			this.nameOfRewardOfTextBox.Size = new System.Drawing.Size(231, 24);
			this.nameOfRewardOfTextBox.TabIndex = 0;
			this.nameOfRewardOfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameOfRewardOfTextBox_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.ForeColor = System.Drawing.Color.Gainsboro;
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название награды";
			// 
			// FormAddEditAchievements
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(496, 331);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button_editRecord);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button_exitFromFrom);
			this.Controls.Add(this.panelMainTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAddEditAchievements";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAddEditAchievements";
			this.Load += new System.EventHandler(this.FormAddEditAchievements_Load);
			this.panelMainTitle.ResumeLayout(false);
			this.panelMainTitle.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.academicsubjectBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.subd_schoolDataSet)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMainTitle;
		private System.Windows.Forms.Button button_exitFromFrom;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox classOfRewardOfTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox typeOfRewardOfTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox listSubjectsBox;
		public System.Windows.Forms.Label labelTitle;
		public System.Windows.Forms.Button button_editRecord;
		private subd_schoolDataSet subd_schoolDataSet;
		private System.Windows.Forms.BindingSource academicsubjectBindingSource;
		private subd_schoolDataSetTableAdapters.academic_subjectTableAdapter academic_subjectTableAdapter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox nameOfRewardOfTextBox;
		private System.Windows.Forms.Label label1;
	}
}