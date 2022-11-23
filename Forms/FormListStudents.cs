using System;
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
		private void ListStudents_Load(object sender, EventArgs e)
		{
			conn.Connect();

			GridListStudents.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
			try
			{
				int counter = 0;
				SQLiteCommand cmd = new SQLiteCommand("select * from list_students", conn.connection);
				SQLiteDataReader reader = null;
				reader = cmd.ExecuteReader();
			
				while (reader.Read())
				{
					ArrayImage = new byte[((byte[])reader["image"]).Length];
					ArrayImage = (byte[])reader["image"];
					ms = new MemoryStream(ArrayImage);
					b = new Bitmap(ms);
					photo = new Bitmap(b, 150, 100);

					GridListStudents.Rows.Add();
					GridListStudents.Rows[counter].Cells[0].Value = Convert.ToInt32(reader["id"]);
					GridListStudents.Rows[counter].Cells[1].Value = Convert.ToString(reader["name"]);
					GridListStudents.Rows[counter].Cells[2].Value = Convert.ToString(reader["surname"]);
					GridListStudents.Rows[counter].Cells[3].Value = Convert.ToString(reader["patronymic"]);
					GridListStudents.Rows[counter].Cells[4].Value = Convert.ToString(reader["class"]).ToUpper();
					GridListStudents.Rows[counter].Cells[5].Value = reader["dataOfBirthday"];
					GridListStudents.Rows[counter].Cells[6].Value = photo;
					counter++;
				}
				ms.Close();
			}
			catch
			{
				MessageBox.Show("Ошибка подключения к таблице", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
			conn.Disconnect();
		}

		private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			conn.Connect();
			GridListStudents.Rows.Clear();
			int counter = 0;
			SQLiteCommand cmd = new SQLiteCommand("select * from list_students", conn.connection);
			SQLiteDataReader reader = null;
			reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				ArrayImage = new byte[((byte[])reader["image"]).Length];
				ArrayImage = (byte[])reader["image"];
				ms = new MemoryStream(ArrayImage);
				b = new Bitmap(ms);
				photo = new Bitmap(b, 150, 100);

				GridListStudents.Rows.Add();
				GridListStudents.Rows[counter].Cells[0].Value = Convert.ToInt32(reader["id"]);
				GridListStudents.Rows[counter].Cells[1].Value = Convert.ToString(reader["name"]);
				GridListStudents.Rows[counter].Cells[2].Value = Convert.ToString(reader["surname"]);
				GridListStudents.Rows[counter].Cells[3].Value = Convert.ToString(reader["patronymic"]);
				GridListStudents.Rows[counter].Cells[4].Value = Convert.ToString(reader["class"]).ToUpper();
				GridListStudents.Rows[counter].Cells[5].Value = reader["dataOfBirthday"];
				GridListStudents.Rows[counter].Cells[6].Value = photo;
				counter++;
			}
			ms.Close();
		}

		private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormAddStudent AS = new FormAddStudent();
			AS.ShowDialog();
		}

		private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = int.Parse(GridListStudents.SelectedRows[0].Cells["id"].Value.ToString());
			string name = GridListStudents.SelectedRows[0].Cells["name"].Value.ToString();
			string surname = GridListStudents.SelectedRows[0].Cells["surname"].Value.ToString();
			string patronymic = GridListStudents.SelectedRows[0].Cells["patronymic"].Value.ToString();
			string classNumber = GridListStudents.SelectedRows[0].Cells["classNumber"].Value.ToString();
			string dateOfBirthDay = GridListStudents.SelectedRows[0].Cells["dataOfBirthDay"].Value.ToString();
			Bitmap photo = (Bitmap)GridListStudents.SelectedRows[0].Cells["image"].Value;
			new FormAddStudent(id, name, surname, patronymic, classNumber, dateOfBirthDay, photo).ShowDialog();
		}

		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы прадва хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				conn.Connect();
				string id = GridListStudents.SelectedRows[0].Cells["id"].Value.ToString();
				SQLiteCommand delete = new SQLiteCommand("delete from list_students where id=" + id, conn.connection);
				delete.ExecuteNonQuery();
				MessageBox.Show("Запись удалена!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				conn.Disconnect();
			}
		}
	}
}
