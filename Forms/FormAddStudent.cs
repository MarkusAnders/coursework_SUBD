using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace coursework
{
	public partial class FormAddStudent : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		readonly int id = -1;

		string checkingForChangesNameStudent = string.Empty;
		string checkingForChangesSurnameStudent = string.Empty;
		string checkingForChangesPatronymicStudent = string.Empty;
		string checkingForChangesGenderStudent = string.Empty;
		string checkingForChangesClassStudent = string.Empty;
		string checkingForChangesDataOfBirthDayStudent = string.Empty;
		Image checkingForChangesPhotoStudent;

		public FormAddStudent()
		{
			InitializeComponent();
		}

		public FormAddStudent(int id, string name, string surname, string patronymic, string gender, string classNumber, string dateOfBirth, Bitmap photo) : base()
		{
			InitializeComponent();
			this.id = id;
			nameOfTextBox.Text = name;
			surnameOfTextBox.Text = surname;
			patronymicOfTextBox.Text = patronymic;
			genderComboBox.Text = gender;
			classOfTextBox.Text = classNumber;
			dateOfBirthDay.Text = dateOfBirth;
			picturePhotoStudent.Image = photo;

			// Проверка изменение данных. Если не изменились, то мы не вызываем запрос update.
			checkingForChangesNameStudent = name;
			checkingForChangesSurnameStudent = surname;
			checkingForChangesPatronymicStudent = patronymic;
			checkingForChangesGenderStudent = gender;
			checkingForChangesClassStudent = classNumber;
			checkingForChangesDataOfBirthDayStudent = dateOfBirth;
			checkingForChangesPhotoStudent = photo;

		}

		#region[Add photo for student]
		private void button_addImageForRecord_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
			if (ofd.ShowDialog() == DialogResult.OK && Path.GetExtension(ofd.FileName) == ".png" || Path.GetExtension(ofd.FileName) == ".jpeg" || Path.GetExtension(ofd.FileName) == ".jpg")
			{
				picturePhotoStudent.Image = Image.FromFile(ofd.FileName);
			}
		}
		#endregion

		#region[Add new student or edit info]
		private void button_editRecord_Click(object sender, EventArgs e)
		{
			conn.Connect();

			string name = nameOfTextBox.Text;
			string surname = surnameOfTextBox.Text;
			string patronymic = patronymicOfTextBox.Text;
			string gender = genderComboBox.Text;
			string classNumber = classOfTextBox.Text;
			DateTime dataOfBirthDay = Convert.ToDateTime(dateOfBirthDay.Value);
			MemoryStream ms = new MemoryStream();

			if (nameOfTextBox.Text == null || surnameOfTextBox.Text == null || patronymicOfTextBox.Text == null
				|| genderComboBox.Text == null ||classOfTextBox.Text == null || dateOfBirthDay.Text == null || picturePhotoStudent.Image == null)
			{
				MessageBox.Show("Не все данные заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				picturePhotoStudent.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				var photo = ms.ToArray();
				try
				{
					SQLiteCommand command = new SQLiteCommand();

					if (id == -1) // Добавление нового ученика
					{
						command = new SQLiteCommand(
							"insert into list_students (name, surname, patronymic, gender, class, dataOfBirthDay, image) " +
							"values (@name, @surname, @patronymic, @gender, @classNumber, @dataOfBirthDay, @image)", conn.connection);
						command.Parameters.Add("name", DbType.String).Value = name;
						command.Parameters.Add("surname", DbType.String).Value = surname;
						command.Parameters.Add("patronymic", DbType.String).Value = patronymic;
						command.Parameters.Add("gender", DbType.String).Value = gender;
						command.Parameters.Add("classNumber", DbType.String).Value = classNumber;
						command.Parameters.Add("dataOfBirthDay", DbType.Date).Value = dataOfBirthDay;
						command.Parameters.Add("image", DbType.Binary, 8000).Value = photo;
						command.ExecuteNonQuery();

						MessageBox.Show("Запись добавлена!", "", MessageBoxButtons.OK);
					}
					else // Редактирование информации ученика
					{
						if (checkingForChangesNameStudent == nameOfTextBox.Text && checkingForChangesSurnameStudent == surnameOfTextBox.Text &&
							checkingForChangesPatronymicStudent == patronymicOfTextBox.Text && checkingForChangesGenderStudent == genderComboBox.Text &&
							checkingForChangesClassStudent == classOfTextBox.Text && checkingForChangesDataOfBirthDayStudent == Convert.ToString(dateOfBirthDay.Value) &&
							checkingForChangesPhotoStudent == picturePhotoStudent.Image) // Проверка изменение данных. Если не изменились, то мы не вызываем запрос update.
						{
							MessageBox.Show("Данные не измеились!", "", MessageBoxButtons.OK);
							
						}
						else // Одно из данных изменилось. Вызываем запрос update.
						{
							if (MessageBox.Show("Внести изменения в запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
							{
								command = new SQLiteCommand(
								"update list_students " +
								"set name = @name, surname = @surname, patronymic = @patronymic, gender = @gender, class = @classNumber, dataOfBirthDay = @dataOfBirthDay, image = @image " +
								"where id = @id", conn.connection);
								command.Parameters.Add("name", DbType.String).Value = name;
								command.Parameters.Add("surname", DbType.String).Value = surname;
								command.Parameters.Add("patronymic", DbType.String).Value = patronymic;
								command.Parameters.Add("gender", DbType.String).Value = gender;
								command.Parameters.Add("classNumber", DbType.String).Value = classNumber;
								command.Parameters.Add("dataOfBirthDay", DbType.Date).Value = dataOfBirthDay;
								command.Parameters.Add("image", DbType.Binary, 8000).Value = photo;
								command.Parameters.Add("id", DbType.Int32).Value = id;

								MessageBox.Show("Данные были изменены!", "", MessageBoxButtons.OK);
							}
							command.ExecuteNonQuery();
						}
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				this.Close();
				conn.Disconnect();
			}
		}

		private void button_exitFromFrom_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region[Prohibition of entering letters or numbers]
		private void nameOfTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar)) return;
			else
				e.Handled = true;
		}

		private void surnameOfTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar)) return;
			else
				e.Handled = true;
		}

		private void patronymicOfTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar)) return;
			else
				e.Handled = true;
		}
		
		#endregion

	}
}
