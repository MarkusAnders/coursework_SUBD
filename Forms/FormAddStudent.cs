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

		public FormAddStudent()
		{
			InitializeComponent();
		}

		public FormAddStudent(int id, string name, string surname, string patronymic, string classNumber, string dateOfBirth, Bitmap photo) : base()
		{
			InitializeComponent();
			this.id = id;
			nameOfTextBox.Text = name;
			surnameOfTextBox.Text = surname;
			patronymicOfTextBox.Text = patronymic;
			classOfTextBox.Text = classNumber;
			dateOfBirthDay.Text = dateOfBirth;
			picturePhotoStudent.Image = photo;
		}

		#region[Add new student or edit info]
		private void button_confirmTask_Click(object sender, EventArgs e)
		{
			conn.Connect();

			string name = nameOfTextBox.Text;
			string surname = surnameOfTextBox.Text;
			string patronymic = patronymicOfTextBox.Text;
			string classNumber = classOfTextBox.Text;
			DateTime dataOfBirthDay = Convert.ToDateTime(dateOfBirthDay.Value);
			MemoryStream ms = new MemoryStream();

			if (picturePhotoStudent.Image == null || nameOfTextBox.Text == null || surnameOfTextBox.Text == null 
				|| patronymicOfTextBox.Text == null || classOfTextBox.Text == null || dateOfBirthDay.Text == null)
			{
				MessageBox.Show("Не вся данные заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				picturePhotoStudent.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				var photo = ms.ToArray();
				try
				{
					SQLiteCommand command;

					if (id == -1) // Добавление нового ученика
					{
						label1.Text = "Добавление нового ученика";

						command = new SQLiteCommand(
							"insert into list_students (name, surname, patronymic, class, dataOfBirthDay, image) " +
							"values (@name, @surname, @patronymic, @classNumber, @dataOfBirthDay, @image)", conn.connection);
						command.Parameters.Add("name", DbType.String).Value = name;
						command.Parameters.Add("surname", DbType.String).Value = surname;
						command.Parameters.Add("patronymic", DbType.String).Value = patronymic;
						command.Parameters.Add("classNumber", DbType.String).Value = classNumber;
						command.Parameters.Add("dataOfBirthDay", DbType.Date).Value = dataOfBirthDay;
						command.Parameters.Add("image", DbType.Binary, 8000).Value = photo;

						MessageBox.Show("Запись добавлена!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else // Редактирование информации ученика
					{
						label1.Text = "Редактирование информации обучающегося";

						command = new SQLiteCommand(
							"update list_students " +
							"set name = @name, surname = @surname, patronymic = @patronymic, class = @classNumber, dataOfBirthDay = @dataOfBirthDay, image = @image " +
							"where id = @id", conn.connection);
						command.Parameters.Add("name", DbType.String).Value = name;
						command.Parameters.Add("surname", DbType.String).Value = surname;
						command.Parameters.Add("patronymic", DbType.String).Value = patronymic;
						command.Parameters.Add("classNumber", DbType.String).Value = classNumber;
						command.Parameters.Add("dataOfBirthDay", DbType.Date).Value = dataOfBirthDay;
						command.Parameters.Add("image", DbType.Binary, 8000).Value = photo;
						command.Parameters.Add("id", DbType.Int32).Value = id;

						MessageBox.Show("Данные были изменены!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}

					command.ExecuteNonQuery();
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				this.Close();
				conn.Disconnect();
			}
		}
		#endregion

		#region[Add photo for student]
		private void button_addPhotoStudent_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
			if (ofd.ShowDialog() == DialogResult.OK && Path.GetExtension(ofd.FileName) == ".png" || Path.GetExtension(ofd.FileName) == ".jpeg" || Path.GetExtension(ofd.FileName) == ".jpg")
			{
				picturePhotoStudent.Image = Image.FromFile(ofd.FileName);
			}
		}
		#endregion

		private void button_cancellation_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		
	}
}
