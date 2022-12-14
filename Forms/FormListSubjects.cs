using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace coursework
{
	public partial class FormListSubjects : Form
	{
        readonly DatabaseConnect conn = new DatabaseConnect();
        
        public FormListSubjects()
		{
			InitializeComponent();
		}

		#region[Загрузка таблицы]

		private void FormListSubjects_Load(object sender, EventArgs e)
		{
			conn.Connect();

			try
			{
				//ReloadTableStudents();
				RefreshTable(GridListSubjects);
			}
			catch
			{
				MessageBox.Show("Ошибка подключения к таблице", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
			conn.Disconnect();
		}

		//public void ReloadTableStudents()
		//{
		//	conn.Connect();
		//	GridListSubjects.Rows.Clear();
		//	int counter = 0;
		//	SQLiteCommand cmd = new SQLiteCommand("select * from academic_subject", conn.connection);
		//	SQLiteDataReader reader = null;
		//	reader = cmd.ExecuteReader();

		//	while (reader.Read())
		//	{
		//		GridListSubjects.Rows.Add();
		//		GridListSubjects.Rows[counter].Cells[0].Value = Convert.ToInt32(reader["id"]);
		//		GridListSubjects.Rows[counter].Cells[1].Value = Convert.ToString(reader["nameSubject"]);
		//		GridListSubjects.Rows[counter].Cells[2].Value = Convert.ToString(reader["hours"]);
		//		counter++;
		//	}
		//	conn.Disconnect();
		//}

		private void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
			dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2));
		}

		private void RefreshTable(DataGridView dgw)
		{
			conn.Connect();
			GridListSubjects.Rows.Clear();

			SQLiteCommand command = new SQLiteCommand($"select * from academic_subject", conn.connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				ReadSingleRow(dgw, reader);
			}
			reader.Close();
			conn.Disconnect();
		}

		#endregion

		#region[Кнопки добавление, редактирование, удаления и закрытия]
		private void button_addRecord_Click(object sender, EventArgs e)
		{
			FormAddEditSubject formAES = new FormAddEditSubject();
			formAES.label7.Text = "Добавление нового предмета";
			formAES.button_editRecord.Text = "Добавить  ";
			formAES.button_editRecord.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"icon/add-subject.png"));
			formAES.ShowDialog();
		}
		private void button_editRecord_Click(object sender, EventArgs e)
		{
			int id = int.Parse(GridListSubjects.SelectedRows[0].Cells["id"].Value.ToString());
			string nameSubject = GridListSubjects.SelectedRows[0].Cells["Subjects"].Value.ToString();
			int hourSubject = int.Parse(GridListSubjects.SelectedRows[0].Cells["Hours"].Value.ToString());
			new FormAddEditSubject(id, nameSubject, hourSubject).ShowDialog();
		}

		private void button_deleteRecord_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы прадва хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				conn.Connect();

				int id = int.Parse(GridListSubjects.SelectedRows[0].Cells["id"].Value.ToString());
				SQLiteCommand delete = new SQLiteCommand("delete from academic_subject where id=" + id, conn.connection);
				delete.ExecuteNonQuery();
				MessageBox.Show("Запись удалена!", "", MessageBoxButtons.OK);

				conn.Disconnect();
			}
		}

		private void button_exitFromFrom_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region[Search Data in table]
		private void searchDateInTextBox_TextChanged(object sender, EventArgs e)
		{
			SearchData(GridListSubjects);
		}

		private void SearchData(DataGridView dgw)
		{
			conn.Connect();

			if (searchDateInTextBox.Text != "Поиск")
			{
				dgw.Rows.Clear();

				string search = $"select * from academic_subject where [nameSubject] || ' ' || [hours]  like '%" + searchDateInTextBox.Text + "%'";

				SQLiteCommand command = new SQLiteCommand(search, conn.connection);

				SQLiteDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					ReadSingleRow(dgw, reader);
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