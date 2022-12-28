
namespace coursework
{
	partial class FormAddEditCertification
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditCertification));
			this.panelMainTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.listSubjectsBox = new System.Windows.Forms.ComboBox();
			this.academicsubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.subd_schoolDataSet = new coursework.subd_schoolDataSet();
			this.label4 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.secondQuaterOfTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.firstQuaterOfTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.thirdQuaterOfTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.fourthQuaterOfTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button_editRecord = new System.Windows.Forms.Button();
			this.button_exitFromFrom = new System.Windows.Forms.Button();
			this.academic_subjectTableAdapter = new coursework.subd_schoolDataSetTableAdapters.academic_subjectTableAdapter();
			this.panelMainTitle.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.academicsubjectBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.subd_schoolDataSet)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
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
			this.panelMainTitle.TabIndex = 2;
			this.panelMainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMainTitle_MouseDown_1);
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Dungeon", 20F);
			this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
			this.labelTitle.Location = new System.Drawing.Point(117, 8);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(258, 30);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Редактирование оценок";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.listSubjectsBox);
			this.panel6.Controls.Add(this.label4);
			this.panel6.Location = new System.Drawing.Point(12, 58);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(467, 44);
			this.panel6.TabIndex = 0;
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
			this.label4.Size = new System.Drawing.Size(91, 24);
			this.label4.TabIndex = 8;
			this.label4.Text = "Предмет";
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.secondQuaterOfTextBox);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Location = new System.Drawing.Point(12, 158);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(467, 44);
			this.panel5.TabIndex = 2;
			// 
			// secondQuaterOfTextBox
			// 
			this.secondQuaterOfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.secondQuaterOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.secondQuaterOfTextBox.Location = new System.Drawing.Point(226, 8);
			this.secondQuaterOfTextBox.MaxLength = 1;
			this.secondQuaterOfTextBox.Multiline = true;
			this.secondQuaterOfTextBox.Name = "secondQuaterOfTextBox";
			this.secondQuaterOfTextBox.Size = new System.Drawing.Size(231, 24);
			this.secondQuaterOfTextBox.TabIndex = 0;
			this.secondQuaterOfTextBox.TextChanged += new System.EventHandler(this.annualOfTextBox_TextChanged);
			this.secondQuaterOfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstQuaterOfTextBox_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label3.ForeColor = System.Drawing.Color.Gainsboro;
			this.label3.Location = new System.Drawing.Point(16, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(164, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "Вторая четверть";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.firstQuaterOfTextBox);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(12, 108);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(467, 44);
			this.panel2.TabIndex = 1;
			// 
			// firstQuaterOfTextBox
			// 
			this.firstQuaterOfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.firstQuaterOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.firstQuaterOfTextBox.Location = new System.Drawing.Point(226, 8);
			this.firstQuaterOfTextBox.MaxLength = 1;
			this.firstQuaterOfTextBox.Multiline = true;
			this.firstQuaterOfTextBox.Name = "firstQuaterOfTextBox";
			this.firstQuaterOfTextBox.Size = new System.Drawing.Size(231, 24);
			this.firstQuaterOfTextBox.TabIndex = 0;
			this.firstQuaterOfTextBox.TextChanged += new System.EventHandler(this.annualOfTextBox_TextChanged);
			this.firstQuaterOfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstQuaterOfTextBox_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.ForeColor = System.Drawing.Color.Gainsboro;
			this.label2.Location = new System.Drawing.Point(16, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Первая четверть";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.thirdQuaterOfTextBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 208);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(467, 44);
			this.panel1.TabIndex = 3;
			// 
			// thirdQuaterOfTextBox
			// 
			this.thirdQuaterOfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.thirdQuaterOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.thirdQuaterOfTextBox.Location = new System.Drawing.Point(226, 8);
			this.thirdQuaterOfTextBox.MaxLength = 1;
			this.thirdQuaterOfTextBox.Multiline = true;
			this.thirdQuaterOfTextBox.Name = "thirdQuaterOfTextBox";
			this.thirdQuaterOfTextBox.Size = new System.Drawing.Size(231, 24);
			this.thirdQuaterOfTextBox.TabIndex = 0;
			this.thirdQuaterOfTextBox.TextChanged += new System.EventHandler(this.annualOfTextBox_TextChanged);
			this.thirdQuaterOfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstQuaterOfTextBox_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.ForeColor = System.Drawing.Color.Gainsboro;
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Третья четверть";
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.fourthQuaterOfTextBox);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(12, 258);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(467, 44);
			this.panel3.TabIndex = 4;
			// 
			// fourthQuaterOfTextBox
			// 
			this.fourthQuaterOfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.fourthQuaterOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.fourthQuaterOfTextBox.Location = new System.Drawing.Point(226, 8);
			this.fourthQuaterOfTextBox.MaxLength = 1;
			this.fourthQuaterOfTextBox.Multiline = true;
			this.fourthQuaterOfTextBox.Name = "fourthQuaterOfTextBox";
			this.fourthQuaterOfTextBox.Size = new System.Drawing.Size(231, 24);
			this.fourthQuaterOfTextBox.TabIndex = 0;
			this.fourthQuaterOfTextBox.TextChanged += new System.EventHandler(this.annualOfTextBox_TextChanged);
			this.fourthQuaterOfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstQuaterOfTextBox_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label5.ForeColor = System.Drawing.Color.Gainsboro;
			this.label5.Location = new System.Drawing.Point(16, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(195, 24);
			this.label5.TabIndex = 0;
			this.label5.Text = "Четвертая четверть";
			// 
			// button_editRecord
			// 
			this.button_editRecord.FlatAppearance.BorderSize = 2;
			this.button_editRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_editRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_editRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_editRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_editRecord.Image")));
			this.button_editRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_editRecord.Location = new System.Drawing.Point(12, 319);
			this.button_editRecord.Name = "button_editRecord";
			this.button_editRecord.Size = new System.Drawing.Size(207, 50);
			this.button_editRecord.TabIndex = 6;
			this.button_editRecord.Text = "Редактировать  ";
			this.button_editRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_editRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_editRecord.UseVisualStyleBackColor = true;
			this.button_editRecord.Click += new System.EventHandler(this.button_editRecord_Click);
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
			this.button_exitFromFrom.Location = new System.Drawing.Point(272, 319);
			this.button_exitFromFrom.Name = "button_exitFromFrom";
			this.button_exitFromFrom.Size = new System.Drawing.Size(207, 50);
			this.button_exitFromFrom.TabIndex = 7;
			this.button_exitFromFrom.Text = "Закрыть  ";
			this.button_exitFromFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_exitFromFrom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_exitFromFrom.UseVisualStyleBackColor = false;
			this.button_exitFromFrom.Click += new System.EventHandler(this.button_exitFromFrom_Click);
			// 
			// academic_subjectTableAdapter
			// 
			this.academic_subjectTableAdapter.ClearBeforeFill = true;
			// 
			// FormAddEditCertification
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(496, 382);
			this.Controls.Add(this.button_editRecord);
			this.Controls.Add(this.button_exitFromFrom);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panelMainTitle);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAddEditCertification";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAddEditCertification";
			this.Load += new System.EventHandler(this.FormAddEditCertification_Load);
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
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMainTitle;
		public System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.ComboBox listSubjectsBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox secondQuaterOfTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox firstQuaterOfTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox thirdQuaterOfTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox fourthQuaterOfTextBox;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.Button button_editRecord;
		private System.Windows.Forms.Button button_exitFromFrom;
		private subd_schoolDataSet subd_schoolDataSet;
		private System.Windows.Forms.BindingSource academicsubjectBindingSource;
		private subd_schoolDataSetTableAdapters.academic_subjectTableAdapter academic_subjectTableAdapter;
	}
}