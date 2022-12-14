
namespace coursework
{
	partial class FormAddStudent
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddStudent));
			this.dateOfBirthDay = new System.Windows.Forms.DateTimePicker();
			this.classOfTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.patronymicOfTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.surnameOfTextBox = new System.Windows.Forms.TextBox();
			this.nameOfTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_exitFromFrom = new System.Windows.Forms.Button();
			this.button_editRecord = new System.Windows.Forms.Button();
			this.button_addImageForRecord = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.genderComboBox = new System.Windows.Forms.ComboBox();
			this.picturePhotoStudent = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturePhotoStudent)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateOfBirthDay
			// 
			this.dateOfBirthDay.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateOfBirthDay.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dateOfBirthDay.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
			this.dateOfBirthDay.Location = new System.Drawing.Point(203, 7);
			this.dateOfBirthDay.Name = "dateOfBirthDay";
			this.dateOfBirthDay.Size = new System.Drawing.Size(213, 31);
			this.dateOfBirthDay.TabIndex = 22;
			this.dateOfBirthDay.Value = new System.DateTime(2022, 11, 15, 0, 0, 0, 0);
			// 
			// classOfTextBox
			// 
			this.classOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.classOfTextBox.Location = new System.Drawing.Point(203, 7);
			this.classOfTextBox.MaxLength = 3;
			this.classOfTextBox.Multiline = true;
			this.classOfTextBox.Name = "classOfTextBox";
			this.classOfTextBox.Size = new System.Drawing.Size(213, 29);
			this.classOfTextBox.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label5.Location = new System.Drawing.Point(16, 7);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 24);
			this.label5.TabIndex = 9;
			this.label5.Text = "Класс";
			// 
			// patronymicOfTextBox
			// 
			this.patronymicOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.patronymicOfTextBox.Location = new System.Drawing.Point(203, 6);
			this.patronymicOfTextBox.MaxLength = 30;
			this.patronymicOfTextBox.Multiline = true;
			this.patronymicOfTextBox.Name = "patronymicOfTextBox";
			this.patronymicOfTextBox.Size = new System.Drawing.Size(213, 29);
			this.patronymicOfTextBox.TabIndex = 13;
			this.patronymicOfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patronymicOfTextBox_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label4.Location = new System.Drawing.Point(16, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 24);
			this.label4.TabIndex = 8;
			this.label4.Text = "Отчество";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label3.Location = new System.Drawing.Point(16, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "Фамилия";
			// 
			// surnameOfTextBox
			// 
			this.surnameOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.surnameOfTextBox.Location = new System.Drawing.Point(203, 6);
			this.surnameOfTextBox.MaxLength = 25;
			this.surnameOfTextBox.Multiline = true;
			this.surnameOfTextBox.Name = "surnameOfTextBox";
			this.surnameOfTextBox.Size = new System.Drawing.Size(213, 29);
			this.surnameOfTextBox.TabIndex = 12;
			this.surnameOfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameOfTextBox_KeyPress);
			// 
			// nameOfTextBox
			// 
			this.nameOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.nameOfTextBox.Location = new System.Drawing.Point(203, 8);
			this.nameOfTextBox.MaxLength = 15;
			this.nameOfTextBox.Name = "nameOfTextBox";
			this.nameOfTextBox.Size = new System.Drawing.Size(213, 27);
			this.nameOfTextBox.TabIndex = 11;
			this.nameOfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameOfTextBox_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.Location = new System.Drawing.Point(16, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Имя";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label6.Location = new System.Drawing.Point(18, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(150, 24);
			this.label6.TabIndex = 10;
			this.label6.Text = "Дата рождения";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.panel3.Controls.Add(this.label7);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(754, 50);
			this.panel3.TabIndex = 31;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Dungeon", 20F);
			this.label7.ForeColor = System.Drawing.Color.Gainsboro;
			this.label7.Location = new System.Drawing.Point(11, 9);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(252, 30);
			this.label7.TabIndex = 0;
			this.label7.Text = "Информация о ученике";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button_exitFromFrom);
			this.panel1.Controls.Add(this.button_editRecord);
			this.panel1.Controls.Add(this.button_addImageForRecord);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(754, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.panel1.Size = new System.Drawing.Size(209, 379);
			this.panel1.TabIndex = 30;
			// 
			// button_exitFromFrom
			// 
			this.button_exitFromFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.button_exitFromFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button_exitFromFrom.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_exitFromFrom.FlatAppearance.BorderSize = 0;
			this.button_exitFromFrom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(243)))));
			this.button_exitFromFrom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.button_exitFromFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_exitFromFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_exitFromFrom.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_exitFromFrom.Image = ((System.Drawing.Image)(resources.GetObject("button_exitFromFrom.Image")));
			this.button_exitFromFrom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_exitFromFrom.Location = new System.Drawing.Point(0, 150);
			this.button_exitFromFrom.Name = "button_exitFromFrom";
			this.button_exitFromFrom.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button_exitFromFrom.Size = new System.Drawing.Size(207, 50);
			this.button_exitFromFrom.TabIndex = 10;
			this.button_exitFromFrom.Text = "Закрыть  ";
			this.button_exitFromFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_exitFromFrom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_exitFromFrom.UseVisualStyleBackColor = false;
			this.button_exitFromFrom.Click += new System.EventHandler(this.button_exitFromFrom_Click);
			// 
			// button_editRecord
			// 
			this.button_editRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.button_editRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button_editRecord.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_editRecord.FlatAppearance.BorderSize = 0;
			this.button_editRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(243)))));
			this.button_editRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.button_editRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_editRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_editRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_editRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_editRecord.Image")));
			this.button_editRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_editRecord.Location = new System.Drawing.Point(0, 100);
			this.button_editRecord.Name = "button_editRecord";
			this.button_editRecord.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button_editRecord.Size = new System.Drawing.Size(207, 50);
			this.button_editRecord.TabIndex = 8;
			this.button_editRecord.Text = "Редактировать  ";
			this.button_editRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_editRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_editRecord.UseVisualStyleBackColor = false;
			this.button_editRecord.Click += new System.EventHandler(this.button_editRecord_Click);
			// 
			// button_addImageForRecord
			// 
			this.button_addImageForRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button_addImageForRecord.Dock = System.Windows.Forms.DockStyle.Top;
			this.button_addImageForRecord.FlatAppearance.BorderSize = 0;
			this.button_addImageForRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(243)))));
			this.button_addImageForRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.button_addImageForRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_addImageForRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_addImageForRecord.ForeColor = System.Drawing.Color.Gainsboro;
			this.button_addImageForRecord.Image = ((System.Drawing.Image)(resources.GetObject("button_addImageForRecord.Image")));
			this.button_addImageForRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_addImageForRecord.Location = new System.Drawing.Point(0, 50);
			this.button_addImageForRecord.Name = "button_addImageForRecord";
			this.button_addImageForRecord.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.button_addImageForRecord.Size = new System.Drawing.Size(207, 50);
			this.button_addImageForRecord.TabIndex = 7;
			this.button_addImageForRecord.Text = "Сменить фото  ";
			this.button_addImageForRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_addImageForRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button_addImageForRecord.UseVisualStyleBackColor = true;
			this.button_addImageForRecord.Click += new System.EventHandler(this.button_addImageForRecord_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(207, 50);
			this.panel4.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.Location = new System.Drawing.Point(18, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 24);
			this.label1.TabIndex = 32;
			this.label1.Text = "Пол";
			// 
			// genderComboBox
			// 
			this.genderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.genderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.genderComboBox.FormattingEnabled = true;
			this.genderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.genderComboBox.Location = new System.Drawing.Point(203, 8);
			this.genderComboBox.MaxLength = 7;
			this.genderComboBox.Name = "genderComboBox";
			this.genderComboBox.Size = new System.Drawing.Size(213, 28);
			this.genderComboBox.TabIndex = 33;
			// 
			// picturePhotoStudent
			// 
			this.picturePhotoStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picturePhotoStudent.Location = new System.Drawing.Point(477, 64);
			this.picturePhotoStudent.Name = "picturePhotoStudent";
			this.picturePhotoStudent.Size = new System.Drawing.Size(255, 295);
			this.picturePhotoStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picturePhotoStudent.TabIndex = 34;
			this.picturePhotoStudent.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.nameOfTextBox);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(12, 64);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(421, 44);
			this.panel2.TabIndex = 35;
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.surnameOfTextBox);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Location = new System.Drawing.Point(12, 114);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(421, 44);
			this.panel5.TabIndex = 36;
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.patronymicOfTextBox);
			this.panel6.Controls.Add(this.label4);
			this.panel6.Location = new System.Drawing.Point(12, 164);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(421, 44);
			this.panel6.TabIndex = 36;
			// 
			// panel7
			// 
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel7.Controls.Add(this.genderComboBox);
			this.panel7.Controls.Add(this.label1);
			this.panel7.Location = new System.Drawing.Point(12, 214);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(421, 44);
			this.panel7.TabIndex = 36;
			// 
			// panel8
			// 
			this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel8.Controls.Add(this.classOfTextBox);
			this.panel8.Controls.Add(this.label5);
			this.panel8.Location = new System.Drawing.Point(12, 264);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(421, 44);
			this.panel8.TabIndex = 36;
			// 
			// panel9
			// 
			this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel9.Controls.Add(this.dateOfBirthDay);
			this.panel9.Controls.Add(this.label6);
			this.panel9.Location = new System.Drawing.Point(12, 314);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(421, 44);
			this.panel9.TabIndex = 36;
			// 
			// FormAddStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(963, 379);
			this.Controls.Add(this.panel9);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.picturePhotoStudent);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAddStudent";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picturePhotoStudent)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateOfBirthDay;
		private System.Windows.Forms.TextBox classOfTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox patronymicOfTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox surnameOfTextBox;
		private System.Windows.Forms.TextBox nameOfTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button_exitFromFrom;
		public System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.Button button_editRecord;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button button_addImageForRecord;
		private System.Windows.Forms.PictureBox picturePhotoStudent;
		public System.Windows.Forms.ComboBox genderComboBox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
	}
}