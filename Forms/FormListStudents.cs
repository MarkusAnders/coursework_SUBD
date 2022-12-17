using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace coursework
{
	public partial class FormListStudents : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		MemoryStream ms = null;
		byte[] ArrayImage;
		Image photo;
		Bitmap b;

		public FormListStudents()
		{
			InitializeComponent();
		}

		#region[Загрузка таблицы]
		private void ListStudents_Load(object sender, EventArgs e)
		{
			try
			{
				RefreshTable(GridListStudents);
			}
			catch(Exception EX)
			{
				MessageBox.Show(EX.Message);
				MessageBox.Show("Ошибка подключения к таблице", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
			conn.Disconnect();
		}

		private void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
			dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4),
				record.GetString(5).ToUpper(), record.GetDateTime(6));
		}

		private void RefreshTable(DataGridView dgw)
		{
			conn.Connect();


			GridListStudents.Rows.Clear();

			int counter = 0;
			SqlCommand command = new SqlCommand($"select * from students", conn.connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				ArrayImage = new byte[((byte[])reader["image"]).Length];
				ArrayImage = (byte[])reader["image"];
				ms = new MemoryStream(ArrayImage);
				b = new Bitmap(ms);
				photo = new Bitmap(b, 255, 295);

				ReadSingleRow(dgw, reader);

				GridListStudents.Rows[counter].Cells[7].Value = photo;
				counter++;

				for (int i = 0; i < GridListStudents.Rows.Count; i++)
				{
					GridListStudents.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
					i++;
				}
			}
			reader.Close();
			conn.Disconnect();
		}

		//public void ReloadTableStudents()
		//{
		//	conn.Connect();
		//	GridListStudents.Rows.Clear();
		//	int counter = 0;
		//	SqlCommand cmd = new SqlCommand("select * from list_students", conn.connection);
		//	SqlDataReader reader = null;
		//	reader = cmd.ExecuteReader();

		//	while (reader.Read())
		//	{

		//		ArrayImage = new byte[((byte[])reader["image"]).Length];
		//		ArrayImage = (byte[])reader["image"];
		//		ms = new MemoryStream(ArrayImage);
		//		b = new Bitmap(ms);
		//		photo = new Bitmap(b, 200, 250);

		//		GridListStudents.Rows.Add();
		//		GridListStudents.Rows[counter].Cells[0].Value = Convert.ToInt32(reader["id"]);
		//		GridListStudents.Rows[counter].Cells[1].Value = Convert.ToString(reader["name"]);
		//		GridListStudents.Rows[counter].Cells[2].Value = Convert.ToString(reader["surname"]);
		//		GridListStudents.Rows[counter].Cells[3].Value = Convert.ToString(reader["patronymic"]);
		//		GridListStudents.Rows[counter].Cells[4].Value = Convert.ToString(reader["gender"]);
		//		GridListStudents.Rows[counter].Cells[5].Value = Convert.ToString(reader["class"]).ToUpper();
		//		GridListStudents.Rows[counter].Cells[6].Value = Convert.ToDateTime(reader["dataOfBirthDay"]);
		//		GridListStudents.Rows[counter].Cells[7].Value = photo;
		//		counter++;
		//	}
		//	ms.Close();
		//	conn.Disconnect();
		//}

		#endregion

		#region[Button add, edit, delete information and close]

		private void button_addRecord_Click(object sender, EventArgs e)
		{
			FormAddStudent formAS = new FormAddStudent();
			formAS.label7.Text = "Добавление нового ученика";
			formAS.button_editRecord.Text = "Добавить  ";
			formAS.button_addImageForRecord.Text = "Загрузить фото  ";
			formAS.button_editRecord.Image = Image.FromFile(Path.Combine(Application.StartupPath ,@"icon\add-user.png"));
			formAS.ShowDialog();
			RefreshTable(GridListStudents);
		}

		private void button_editRecord_Click(object sender, EventArgs e)
		{
			int id = int.Parse(GridListStudents.SelectedRows[0].Cells["id"].Value.ToString());
			string surname = GridListStudents.SelectedRows[0].Cells["surname"].Value.ToString();
			string name = GridListStudents.SelectedRows[0].Cells["name"].Value.ToString();
			string patronymic = GridListStudents.SelectedRows[0].Cells["patronymic"].Value.ToString();
			string gender = GridListStudents.SelectedRows[0].Cells["gender"].Value.ToString();
			string classNumber = GridListStudents.SelectedRows[0].Cells["classNumber"].Value.ToString();
			string dateOfBirthDay = GridListStudents.SelectedRows[0].Cells["dataOfBirthDay"].Value.ToString();
			Bitmap photo = (Bitmap)GridListStudents.SelectedRows[0].Cells["image"].Value;
			new FormAddStudent(id, name, surname, patronymic, gender, classNumber, dateOfBirthDay, photo).ShowDialog();
			RefreshTable(GridListStudents);
		}

		private void button_deleteRecord_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы прадва хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				conn.Connect();

				string id = GridListStudents.SelectedRows[0].Cells["id"].Value.ToString();
				SqlCommand delete = new SqlCommand("delete from students where id=" + id, conn.connection);
				delete.ExecuteNonQuery();
				MessageBox.Show("Запись удалена!", "", MessageBoxButtons.OK);
				RefreshTable(GridListStudents);
				conn.Disconnect();
			}
		}

		private void button_closeForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region[Search Data in table]

		private void searchDateInTextBox_TextChanged(object sender, EventArgs e)
		{
			SearchData(GridListStudents);
		}

		private void SearchData(DataGridView dgw)
		{
			conn.Connect();

			if (searchDateInTextBox.Text != "Поиск")
			{
				dgw.Rows.Clear();
				int counter = 0;

				string search = $"select * from students where concat (id, surname, firstname, patronymic, class) like '%" + searchDateInTextBox.Text + "%'";
				SqlCommand command = new SqlCommand(search, conn.connection);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					ArrayImage = new byte[((byte[])reader["image"]).Length];
					ArrayImage = (byte[])reader["image"];
					ms = new MemoryStream(ArrayImage);
					b = new Bitmap(ms);
					photo = new Bitmap(b, 255, 295);

					ReadSingleRow(dgw, reader);

					GridListStudents.Rows[counter].Cells[7].Value = photo;
					counter++;

					for (int i = 0; i < GridListStudents.Rows.Count; i++)
					{
						GridListStudents.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
						i++;
					}
				}
				reader.Close();
			}
			else
				return;

			conn.Disconnect();
		}

		private void searchDateInTextBox_Click(object sender, EventArgs e)
		{
			if (searchDateInTextBox.Text == "Поиск")
				searchDateInTextBox.Text = "";
		}

		private void searchDateInTextBox_Leave(object sender, EventArgs e)
		{
			if (searchDateInTextBox.Text == "")
				searchDateInTextBox.Text = "Поиск";
		}
		#endregion

	}
}
