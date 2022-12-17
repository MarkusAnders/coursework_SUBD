using System;
using System.Data;
using System.Data.SqlClient;
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
				RefreshTable(GridListSubjects);
			}
			catch
			{
				MessageBox.Show("Ошибка подключения к таблице", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
			conn.Disconnect();

			GridListSubjects.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
			GridListSubjects.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
		}

		private void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
			dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2));
		}

		private void RefreshTable(DataGridView dgw)
		{
			conn.Connect();
			GridListSubjects.Rows.Clear();

			SqlCommand command = new SqlCommand($"select * from academic_subject", conn.connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				ReadSingleRow(dgw, reader);

				for (int i = 0; i < GridListSubjects.Rows.Count; i++)
				{
					GridListSubjects.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
					i++;
				}
			}
			reader.Close();
			conn.Disconnect();
		}

		#endregion

		#region[Кнопки добавление, редактирование, удаления и закрытия]
		private void button_addRecord_Click_1(object sender, EventArgs e)
		{
			FormAddEditSubject formAES = new FormAddEditSubject();
			formAES.label7.Text = "Добавление нового предмета";
			formAES.button_editRecord.Text = "Добавить  ";
			formAES.button_editRecord.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"icon/add-subject.png"));
			formAES.ShowDialog();
			RefreshTable(GridListSubjects);

		}

		private void button_editRecord_Click_1(object sender, EventArgs e)
		{
			int id = int.Parse(GridListSubjects.SelectedRows[0].Cells["id"].Value.ToString());
			string nameSubject = GridListSubjects.SelectedRows[0].Cells["Subjects"].Value.ToString();
			int hourSubject = int.Parse(GridListSubjects.SelectedRows[0].Cells["Hours"].Value.ToString());
			new FormAddEditSubject(id, nameSubject, hourSubject).ShowDialog();
			RefreshTable(GridListSubjects);

		}

		private void button_deleteRecord_Click_1(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы прадва хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				conn.Connect();

				int id = int.Parse(GridListSubjects.SelectedRows[0].Cells["id"].Value.ToString());
				SqlCommand delete = new SqlCommand("delete from academic_subject where id=" + id, conn.connection);
				delete.ExecuteNonQuery();
				MessageBox.Show("Запись удалена!", "", MessageBoxButtons.OK);
				RefreshTable(GridListSubjects);
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
			SearchData(GridListSubjects);
		}

		private void SearchData(DataGridView dgw)
		{
			conn.Connect();

			if (searchDateInTextBox.Text != "Поиск")
			{
				dgw.Rows.Clear();

				string search = $"select * from academic_subject where concat (subject, hours) like '%" + searchDateInTextBox.Text + "%'";
																	

				SqlCommand command = new SqlCommand(search, conn.connection);

				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					ReadSingleRow(dgw, reader);

					for (int i = 0; i < GridListSubjects.Rows.Count; i++)
					{
						GridListSubjects.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
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