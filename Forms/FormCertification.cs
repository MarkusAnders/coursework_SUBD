using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace coursework
{
	public partial class FormCertification : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		public FormCertification()
		{
			InitializeComponent();
			LoadTheme();
		}

		#region[Загрузка таблицы]

		#endregion

		#region[Обновление таблиц]
		private void ReloadTable()
		{

		}
		#endregion

		#region[Кнопки добавления, редактирования и удаления ]
		private void button_addRecord_Click(object sender, EventArgs e)
		{
			if (GridListStudents.RowCount > 0)
			{
				
			}
			else
			{
				MessageBox.Show("Не возможно добавить запись!", "Отсутствуют записи учеников", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			ReloadTable();
		}

		private void button_editRecord_Click(object sender, EventArgs e)
		{
			if (GridListCertification.RowCount > 0)
			{
				
			}
			else
			{
				MessageBox.Show("Нет информации о достижениях!", "Отсутствуют достижения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			ReloadTable();
		}

		private void button_deleteRecord_Click(object sender, EventArgs e)
		{
			if (GridListCertification.RowCount > 0)
			{
				if (MessageBox.Show("Вы прадва хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					conn.Connect();

					string id = GridListCertification.SelectedRows[0].Cells["id"].Value.ToString();
					SqlCommand delete = new SqlCommand("delete from certification where id=" + id, conn.connection);
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
				GridListCertification.DefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
				labelSearch.ForeColor = ThemeColor.PrimaryColor;
			}
		}

		#endregion

		private void FormCertification_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "subd_schoolDataSet.certification". При необходимости она может быть перемещена или удалена.
			this.certificationTableAdapter.Fill(this.subd_schoolDataSet.certification);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "subd_schoolDataSet.students". При необходимости она может быть перемещена или удалена.
			this.studentsTableAdapter.Fill(this.subd_schoolDataSet.students);

		}
	}
}
