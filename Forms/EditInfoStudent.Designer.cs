
namespace coursework
{
	partial class EditInfoStudent
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button_deletePhotoStudent = new System.Windows.Forms.Button();
			this.button_addPhotoStudent = new System.Windows.Forms.Button();
			this.picturePhotoStudent = new System.Windows.Forms.PictureBox();
			this.button_confirmEditInfo = new System.Windows.Forms.Button();
			this.button_cancellation = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.nameOfTextBox = new System.Windows.Forms.TextBox();
			this.surnameOfTextBox = new System.Windows.Forms.TextBox();
			this.patronymicOfTextBox = new System.Windows.Forms.TextBox();
			this.classOfTextBox = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.dateOfBirthDay = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturePhotoStudent)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(391, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Редактирование информации обучающегося";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button_deletePhotoStudent);
			this.groupBox1.Controls.Add(this.button_addPhotoStudent);
			this.groupBox1.Controls.Add(this.picturePhotoStudent);
			this.groupBox1.Location = new System.Drawing.Point(18, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(234, 355);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// button_deletePhotoStudent
			// 
			this.button_deletePhotoStudent.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_deletePhotoStudent.Location = new System.Drawing.Point(17, 312);
			this.button_deletePhotoStudent.Name = "button_deletePhotoStudent";
			this.button_deletePhotoStudent.Size = new System.Drawing.Size(198, 34);
			this.button_deletePhotoStudent.TabIndex = 3;
			this.button_deletePhotoStudent.Text = "Удалить";
			this.button_deletePhotoStudent.UseVisualStyleBackColor = true;
			this.button_deletePhotoStudent.Click += new System.EventHandler(this.button_deletePhotoStudent_Click);
			// 
			// button_addPhotoStudent
			// 
			this.button_addPhotoStudent.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_addPhotoStudent.Location = new System.Drawing.Point(17, 272);
			this.button_addPhotoStudent.Name = "button_addPhotoStudent";
			this.button_addPhotoStudent.Size = new System.Drawing.Size(198, 34);
			this.button_addPhotoStudent.TabIndex = 2;
			this.button_addPhotoStudent.Text = "Загрузить фото";
			this.button_addPhotoStudent.UseVisualStyleBackColor = true;
			this.button_addPhotoStudent.Click += new System.EventHandler(this.button_addPhotoStudent_Click);
			// 
			// picturePhotoStudent
			// 
			this.picturePhotoStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picturePhotoStudent.Location = new System.Drawing.Point(17, 21);
			this.picturePhotoStudent.Name = "picturePhotoStudent";
			this.picturePhotoStudent.Size = new System.Drawing.Size(198, 245);
			this.picturePhotoStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picturePhotoStudent.TabIndex = 2;
			this.picturePhotoStudent.TabStop = false;
			// 
			// button_confirmEditInfo
			// 
			this.button_confirmEditInfo.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_confirmEditInfo.Location = new System.Drawing.Point(282, 325);
			this.button_confirmEditInfo.Name = "button_confirmEditInfo";
			this.button_confirmEditInfo.Size = new System.Drawing.Size(135, 34);
			this.button_confirmEditInfo.TabIndex = 4;
			this.button_confirmEditInfo.Text = "Подтвердить";
			this.button_confirmEditInfo.UseVisualStyleBackColor = true;
			this.button_confirmEditInfo.Click += new System.EventHandler(this.button_confirmEditInfo_Click);
			// 
			// button_cancellation
			// 
			this.button_cancellation.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_cancellation.Location = new System.Drawing.Point(461, 325);
			this.button_cancellation.Name = "button_cancellation";
			this.button_cancellation.Size = new System.Drawing.Size(133, 34);
			this.button_cancellation.TabIndex = 5;
			this.button_cancellation.Text = "Отмена";
			this.button_cancellation.UseVisualStyleBackColor = true;
			this.button_cancellation.Click += new System.EventHandler(this.button_cancellation_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Имя";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Фамилия";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Отчество";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(15, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "Класс";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(15, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 15);
			this.label6.TabIndex = 10;
			this.label6.Text = "Дата рождения";
			// 
			// nameOfTextBox
			// 
			this.nameOfTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameOfTextBox.Location = new System.Drawing.Point(136, 10);
			this.nameOfTextBox.Name = "nameOfTextBox";
			this.nameOfTextBox.Size = new System.Drawing.Size(173, 26);
			this.nameOfTextBox.TabIndex = 11;
			// 
			// surnameOfTextBox
			// 
			this.surnameOfTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.surnameOfTextBox.Location = new System.Drawing.Point(136, 10);
			this.surnameOfTextBox.Name = "surnameOfTextBox";
			this.surnameOfTextBox.Size = new System.Drawing.Size(173, 26);
			this.surnameOfTextBox.TabIndex = 12;
			// 
			// patronymicOfTextBox
			// 
			this.patronymicOfTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.patronymicOfTextBox.Location = new System.Drawing.Point(136, 10);
			this.patronymicOfTextBox.Name = "patronymicOfTextBox";
			this.patronymicOfTextBox.Size = new System.Drawing.Size(173, 26);
			this.patronymicOfTextBox.TabIndex = 13;
			// 
			// classOfTextBox
			// 
			this.classOfTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.classOfTextBox.Location = new System.Drawing.Point(136, 11);
			this.classOfTextBox.Name = "classOfTextBox";
			this.classOfTextBox.Size = new System.Drawing.Size(173, 26);
			this.classOfTextBox.TabIndex = 14;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.nameOfTextBox);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(282, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(315, 42);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.surnameOfTextBox);
			this.groupBox3.Location = new System.Drawing.Point(282, 109);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(315, 42);
			this.groupBox3.TabIndex = 17;
			this.groupBox3.TabStop = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.patronymicOfTextBox);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Location = new System.Drawing.Point(282, 165);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(315, 42);
			this.groupBox4.TabIndex = 18;
			this.groupBox4.TabStop = false;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.classOfTextBox);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Location = new System.Drawing.Point(282, 221);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(315, 42);
			this.groupBox5.TabIndex = 19;
			this.groupBox5.TabStop = false;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.dateOfBirthDay);
			this.groupBox6.Controls.Add(this.label6);
			this.groupBox6.Location = new System.Drawing.Point(282, 277);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(315, 42);
			this.groupBox6.TabIndex = 20;
			this.groupBox6.TabStop = false;
			// 
			// dateOfBirthDay
			// 
			this.dateOfBirthDay.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateOfBirthDay.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateOfBirthDay.Location = new System.Drawing.Point(139, 11);
			this.dateOfBirthDay.MaximumSize = new System.Drawing.Size(180, 30);
			this.dateOfBirthDay.Name = "dateOfBirthDay";
			this.dateOfBirthDay.Size = new System.Drawing.Size(173, 25);
			this.dateOfBirthDay.TabIndex = 22;
			// 
			// EditInfoStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 415);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button_cancellation);
			this.Controls.Add(this.button_confirmEditInfo);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "EditInfoStudent";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picturePhotoStudent)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox picturePhotoStudent;
		private System.Windows.Forms.Button button_deletePhotoStudent;
		private System.Windows.Forms.Button button_addPhotoStudent;
		private System.Windows.Forms.Button button_confirmEditInfo;
		private System.Windows.Forms.Button button_cancellation;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox nameOfTextBox;
		private System.Windows.Forms.TextBox surnameOfTextBox;
		private System.Windows.Forms.TextBox patronymicOfTextBox;
		private System.Windows.Forms.TextBox classOfTextBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.DateTimePicker dateOfBirthDay;
	}
}