using System;
using System.Data;
using System.Data.SqlClient;
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
			LoadTheme();
		}
		private void FormListSubjects_Load(object sender, EventArgs e)
		{
			LoadTable();
		}

		#region[Загрука таблицы]
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

		private void LoadTable()
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
		}
		#endregion

		#region[Кнопки добавления, редактирования, удаления]
		private void button_addRecord_Click(object sender, EventArgs e)
		{
			FormAddEditSubject formAES = new FormAddEditSubject();
			formAES.labelTitle.Text = "Добавление нового предмета";
			formAES.button_editRecord.Text = "Добавить  ";
			formAES.button_editRecord.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"icon/add-subject.png"));
			formAES.ShowDialog();
			RefreshTable(GridListSubjects);
		}

		private void button_editRecord_Click(object sender, EventArgs e)
		{
			int id = int.Parse(GridListSubjects.SelectedRows[0].Cells["id"].Value.ToString());
			string nameSubject = GridListSubjects.SelectedRows[0].Cells["nameSubject"].Value.ToString();
			int hourSubject = int.Parse(GridListSubjects.SelectedRows[0].Cells["hoursSubject"].Value.ToString());
			new FormAddEditSubject(id, nameSubject, hourSubject).ShowDialog();
			RefreshTable(GridListSubjects);
		}

		private void button_deleteRecord_Click(object sender, EventArgs e)
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
		#endregion

		#region[Поиск данных]
		private void searchDataTextBox_TextChanged(object sender, EventArgs e)
		{
			SearchData(GridListSubjects);
		}
		private void SearchData(DataGridView dgw)
		{
			conn.Connect();

			if (searchDataTextBox.Text != "Поиск")
			{
				dgw.Rows.Clear();

				string search = $"select * from academic_subject where concat (subject, hours) like '%" + searchDataTextBox.Text + "%'";


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
		#endregion

		#region[Изменение цвета]
		private void LoadTheme()
		{
			foreach (Control btns in this.Controls)
			{
				if (btns.GetType() == typeof(Button))
				{
					Button btn = (Button)btns;
					btn.BackColor = ThemeColor.PrimaryColor;
					btn.ForeColor = Color.White;
					btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
				}
				GridListSubjects.DefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
				labelSearch.ForeColor = ThemeColor.PrimaryColor;
			}
		}
		#endregion
	}
}
