using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;

namespace coursework
{
	public partial class AddStudent : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();

		public AddStudent()
		{
			InitializeComponent();
		}

		#region[AddNewStudent]
		private void button_addStudent_Click(object sender, EventArgs e)
		{
			conn.Connect();

			string name = nameOfTextBox.Text;
			string surname = surnameOfTextBox.Text;
			string patronymic = patronymicOfTextBox.Text;
			string classNumber = classOfTextBox.Text;
			DateTime dataOfBirthDay = Convert.ToDateTime(dateOfBirthDay.Value);
			MemoryStream ms = new MemoryStream();
			if (picturePhotoStudent.Image == null)
			{
				MessageBox.Show("Не добавлена фотография", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				picturePhotoStudent.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				var photo = ms.ToArray();
				try
				{
					SQLiteCommand insert = new SQLiteCommand("insert into list_students (name, surname, patronymic, class, dataOfBirthDay, image) values (@name, @surname, @patronymic, @classNumber, @dataOfBirthDay, @image)", conn.connection);
					insert.Parameters.Add("name", DbType.String).Value = name;
					insert.Parameters.Add("surname", DbType.String).Value = surname;
					insert.Parameters.Add("patronymic", DbType.String).Value = patronymic;
					insert.Parameters.Add("classNumber", DbType.String).Value = classNumber;
					insert.Parameters.Add("dataOfBirthDay", DbType.Date).Value = dataOfBirthDay;
					insert.Parameters.Add("image", DbType.Binary, 8000).Value = photo;
					insert.ExecuteNonQuery();
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

		#region[PhotoAddForStudent]
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
