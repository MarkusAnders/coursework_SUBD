using System;
using System.Data;
using System.Data.SqlClient;
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
		string checkGender = string.Empty;

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

		public FormAddStudent(int id, string surname, string name, string patronymic, string gender, string classNumber, string dateOfBirth, Bitmap photo) : base()
		{
			InitializeComponent();
			this.id = id;
			nameOfTextBox.Text = name;
			surnameOfTextBox.Text = surname;
			patronymicOfTextBox.Text = patronymic;
			checkGender = gender;

			if (gender == "Мужской")
			{
				radioButtonMale.Checked = true;
				radioButtonFemale.Checked = false;
			}
			else if(gender == "Женский")
			{
				radioButtonMale.Checked = false;
				radioButtonFemale.Checked = true;
			}

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
			string classNumber = classOfTextBox.Text;
			DateTime dataOfBirthDay = Convert.ToDateTime(dateOfBirthDay.Value);
			MemoryStream ms = new MemoryStream();

			if (nameOfTextBox.Text == null || surnameOfTextBox.Text == null || patronymicOfTextBox.Text == null
				|| classOfTextBox.Text == null || dateOfBirthDay.Text == null || picturePhotoStudent.Image == null)
			{
				MessageBox.Show("Не все данные заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				picturePhotoStudent.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				var photo = ms.ToArray();
				try
				{
					SqlCommand command = new SqlCommand();

					if (id == -1) // Добавление нового ученика
					{
						command = new SqlCommand(
							"insert into students (surname, firstname, patronymic, gender, class, dataOfBirthDay, image) " +
							"values (@name, @surname, @patronymic, @gender, @classNumber, @dataOfBirthDay, @image)", conn.connection);
						command.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
						command.Parameters.Add("surname", SqlDbType.NVarChar).Value = surname;
						command.Parameters.Add("patronymic", SqlDbType.NVarChar).Value = patronymic;
						if (radioButtonMale.Checked == true && radioButtonFemale.Checked == false)
						{
							command.Parameters.Add("@gender", SqlDbType.VarChar).Value = "Мужской";
						}
						else if (radioButtonMale.Checked == false && radioButtonFemale.Checked == true) 
						{
							command.Parameters.Add("@gender", SqlDbType.VarChar).Value = "Женский";
						}
						
						command.Parameters.Add("classNumber", SqlDbType.NVarChar).Value = classNumber;
						command.Parameters.Add("dataOfBirthDay", SqlDbType.Date).Value = dataOfBirthDay;
						command.Parameters.Add("image", SqlDbType.Image).Value = photo;
						command.ExecuteNonQuery();

						MessageBox.Show("Запись добавлена!", "", MessageBoxButtons.OK);

						this.Close();
					}
					else // Редактирование информации ученика
					{
						if (checkingForChangesNameStudent == nameOfTextBox.Text && checkingForChangesSurnameStudent == surnameOfTextBox.Text &&
							checkingForChangesPatronymicStudent == patronymicOfTextBox.Text && checkingForChangesClassStudent == classOfTextBox.Text && checkingForChangesDataOfBirthDayStudent == Convert.ToString(dateOfBirthDay.Value) &&
							checkingForChangesPhotoStudent == picturePhotoStudent.Image &&
							checkGender == "Мужской" && radioButtonMale.Checked == true && radioButtonFemale.Checked == false ||
							checkGender == "Женский" && radioButtonMale.Checked == false && radioButtonFemale.Checked == true) // Проверка изменение данных. Если не изменились, то мы не вызываем запрос update.
						{
							MessageBox.Show("Данные не изменились!", "", MessageBoxButtons.OK);
						}
						else // Одно из данных изменилось. Вызываем запрос update.
						{
							if (MessageBox.Show("Внести изменения в запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
							{
								command = new SqlCommand(
								"update students " +
								"set firstname = @name, surname = @surname, patronymic = @patronymic, gender = @gender, class = @classNumber, dataOfBirthDay = @dataOfBirthDay, image = @image " +
								"where id = @id", conn.connection);
								command.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
								command.Parameters.Add("surname", SqlDbType.NVarChar).Value = surname;
								command.Parameters.Add("patronymic", SqlDbType.NVarChar).Value = patronymic;
								if (checkGender == "Мужской" && radioButtonMale.Checked == false && radioButtonFemale.Checked == true)
								{
									command.Parameters.Add("gender", SqlDbType.VarChar).Value = "Женский";
								}
								else if(checkGender == "Женский" && radioButtonMale.Checked == true && radioButtonFemale.Checked == false)
								{
									command.Parameters.Add("gender", SqlDbType.VarChar).Value = "Мужской";
								}
								else
								{
									command.Parameters.Add("gender", SqlDbType.VarChar).Value = checkGender;
								}
								command.Parameters.Add("classNumber", SqlDbType.NVarChar).Value = classNumber;
								command.Parameters.Add("dataOfBirthDay", SqlDbType.Date).Value = dataOfBirthDay;
								command.Parameters.Add("image", SqlDbType.Image, 8000).Value = photo;
								command.Parameters.Add("id", SqlDbType.Int).Value = id;
								command.ExecuteNonQuery();

								MessageBox.Show("Данные были изменены!", "", MessageBoxButtons.OK);

								this.Close();
							}
						}
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
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
