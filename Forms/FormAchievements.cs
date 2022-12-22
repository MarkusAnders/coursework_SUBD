using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace coursework
{
	public partial class FormAchievements : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		public FormAchievements()
		{
			InitializeComponent();
			LoadTheme();
			CountRecord(GridListSudentCountAchievements);
		}

		#region[Загрузка  таблицы]
		private void FormAchievements_Load(object sender, EventArgs e)
		{
			this.achievements_studentsTableAdapter.Fill(this.subd_schoolDataSet.achievements_students);
			this.studentsTableAdapter.Fill(this.subd_schoolDataSet.students) ;
			this.GridListStudents.Sort(this.GridListStudents.Columns["surnameDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
			//ColorGridTable();
		}
		#endregion

		#region[Обновление таблиц]
		private void ReloadTable()
		{
			this.achievements_studentsTableAdapter.Fill(this.subd_schoolDataSet.achievements_students);
			this.studentsTableAdapter.Fill(this.subd_schoolDataSet.students);
		}
		#endregion

		#region[Кнопки добавления, редактирования и удаления]
		private void button_addRecord_Click(object sender, EventArgs e)
		{
			FormAddEditAchievements formAEA = new FormAddEditAchievements();
			formAEA.labelTitle.Text = "Добавление достижения";
			formAEA.button_editRecord.Text = "Добавить  ";
			formAEA.button_editRecord.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"icon\reward.png"));

			if (GridListStudents.RowCount > 0)
			{
				int id_Student = int.Parse(GridListStudents.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value.ToString());
				new FormAddEditAchievements(id_Student).ShowDialog();
			}
			else
			{
				MessageBox.Show("Не возможно добавить запись!", "Отсутствуют записи учеников", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			ReloadTable();
			CountRecord(GridListSudentCountAchievements);
		}

		private void button_editRecord_Click(object sender, EventArgs e)
		{
			if (GridListAchievements.RowCount > 0)
			{
				int id = int.Parse(GridListAchievements.SelectedRows[0].Cells["id"].Value.ToString());
				string classOfReward = GridListAchievements.SelectedRows[0].Cells["classOfReward"].Value.ToString();
				string typeOfReward = GridListAchievements.SelectedRows[0].Cells["typeOfReward"].Value.ToString();
				string subjectOfReward = GridListAchievements.SelectedRows[0].Cells["subjectOfReward"].Value.ToString();
				int id_Student = int.Parse(GridListStudents.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value.ToString());
				new FormAddEditAchievements(id, classOfReward, typeOfReward, subjectOfReward, id_Student).ShowDialog();
			}
			else
			{
				MessageBox.Show("Нет информации о достижениях!", "Отсутствуют достижения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			ReloadTable();
			CountRecord(GridListSudentCountAchievements);
		}

		private void button_deleteRecord_Click(object sender, EventArgs e)
		{
			if (GridListAchievements.RowCount > 0)
			{
				if (MessageBox.Show("Вы прадва хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					conn.Connect();

					string id = GridListAchievements.SelectedRows[0].Cells["id"].Value.ToString();
					SqlCommand delete = new SqlCommand("delete from achievements_students where id=" + id, conn.connection);
					delete.ExecuteNonQuery();
					MessageBox.Show("Запись удалена!", "", MessageBoxButtons.OK);

					ReloadTable();
					CountRecord(GridListSudentCountAchievements);

					conn.Disconnect();
				}
			}
			else
			{
				MessageBox.Show("Удаление не возможно!", "Отсутствуют записи", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		#endregion

		#region[Поиск данных]
		private void searchDataTextBox_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void SearchData(DataGridView dgw)
		{
			conn.Connect();

			//string search = $"select * from students where concat (id, surname, firstname, patronymic, class) like '%" + searchDataTextBox.Text + "%'";
			//SqlCommand command = new SqlCommand(search, conn.connection);
			//SqlDataReader reader = command.ExecuteReader();

			//while (reader.Read())
			//{
			//	ReadSingleRow(dgw, reader);
			//	for (int i = 0; i < GridListSudentCountAchievements.Rows.Count; i++)
			//	{
			//		GridListSudentCountAchievements.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
			//		i++;
			//	}
			//}
			//reader.Close();

			conn.Disconnect();
		}
		#endregion

		#region[Цвета кнопок]
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
				GridListStudents.DefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
				GridListAchievements.DefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
				GridListSudentCountAchievements.DefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
				labelSearch.ForeColor = ThemeColor.PrimaryColor;
			}
		}
		#endregion	}

		#region[Вывод кол-во достиежний и выключение кнопок]
		private void ReadSingleRow(DataGridView dgw, IDataRecord record)
		{
			dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4).ToString());
		}

		private void CountRecord(DataGridView dgw)
		{
			dgw.Rows.Clear();

			conn.Connect();
			SqlCommand counter = new SqlCommand($"select STUDENTS.[surname], STUDENTS.[firstname], STUDENTS.[patronymic], STUDENTS.[class], " +
				$"count([subd_school].[dbo].[achievements_students].[id_Student]) as Reward FROM STUDENTS " +
				$"JOIN[subd_school].[dbo].[achievements_students] on[subd_school].[dbo].[achievements_students].[id_Student] = STUDENTS.Id " +
				$"GROUP BY STUDENTS.[surname], STUDENTS.[firstname], STUDENTS.[patronymic], STUDENTS.[class]", conn.connection);
			SqlDataReader reader = counter.ExecuteReader();

			while (reader.Read())
			{
				ReadSingleRow(dgw, reader);
				//ColorGridTable();
				for (int i = 0; i < GridListSudentCountAchievements.Rows.Count; i++)
				{
					GridListSudentCountAchievements.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
					i++;
				}
			}
			reader.Close();

			conn.Disconnect();
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Convert.ToBoolean(tabControl.SelectedTab.Controls.Count.Equals(1)) == true)
			{
				button_addRecord.Enabled = false;
				button_editRecord.Enabled = false;
				button_deleteRecord.Enabled = false;
			}
			else
			{
				button_addRecord.Enabled = true;
				button_editRecord.Enabled = true;
				button_deleteRecord.Enabled = true;
			}
		}
		#endregion

		#region[Перекрас строк таблиц]
		//private void ColorGridTable()
		//{
		//	for (int i = 0; i < GridListStudents.Rows.Count; i++)
		//	{
		//		GridListStudents.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
		//		i++;
		//	}

		//	for (int i = 0; i < GridListAchievements.Rows.Count; i++)
		//	{
		//		GridListAchievements.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
		//		i++;
		//	}

		//	for (int i = 0; i < GridListSudentCountAchievements.Rows.Count; i++)
		//	{
		//		GridListSudentCountAchievements.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
		//		i++;
		//	}
		//}
		#endregion

		
	}
}
