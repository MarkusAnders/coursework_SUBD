using System;
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
		}

		#region[Загрузка  таблицы]
		#endregion

		#region[Обновление таблиц]
		private void ReloadTable()
		{

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
				labelSearch.ForeColor = ThemeColor.PrimaryColor;
			}
		}
		#endregion
	}
}
