using System;
using System.ComponentModel;
using System.Data;
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
		private void FormCertification_Load(object sender, EventArgs e)
		{
			this.certificationTableAdapter.Fill(this.subd_schoolDataSet.certification);
			this.studentsTableAdapter.Fill(this.subd_schoolDataSet.students);
			this.GridListStudents.Sort(this.GridListStudents.Columns["surnameDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
			this.GridListCertification.Sort(this.GridListCertification.Columns["subject"], ListSortDirection.Ascending);
		}
		#endregion

		#region[Обновление таблиц]
		private void ReloadTable()
		{
			this.certificationTableAdapter.Fill(this.subd_schoolDataSet.certification);
			this.studentsTableAdapter.Fill(this.subd_schoolDataSet.students);
		}
		#endregion

		#region[Кнопки добавления, редактирования и удаления ]
		private void button_addRecord_Click(object sender, EventArgs e)
		{
			if (GridListStudents.RowCount > 0)
			{
				int id_Student = int.Parse(GridListStudents.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value.ToString());
				new FormAddEditCertification(id_Student).ShowDialog();
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
				int id = int.Parse(GridListCertification.SelectedRows[0].Cells["id"].Value.ToString());
				string subject = GridListCertification.SelectedRows[0].Cells["subject"].Value.ToString();
				int firstQuarter = int.Parse(GridListCertification.SelectedRows[0].Cells["firstQuarter"].Value.ToString());
				int secondQuarter = int.Parse(GridListCertification.SelectedRows[0].Cells["secondQuarter"].Value.ToString());
				int thirdQuarter = int.Parse(GridListCertification.SelectedRows[0].Cells["thirdQuarter"].Value.ToString());
				int fourthQuarter = int.Parse(GridListCertification.SelectedRows[0].Cells["fourthQuarter"].Value.ToString());
				int annual = int.Parse(GridListCertification.SelectedRows[0].Cells["annual"].Value.ToString());
				int id_Student = int.Parse(GridListStudents.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value.ToString());
				new FormAddEditCertification(id, subject, firstQuarter, secondQuarter, thirdQuarter, fourthQuarter, annual, id_Student).ShowDialog();
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
		private void searchDataTextBox_TextChanged(object sender, EventArgs e)
		{
			conn.Connect();
			SqlCommand command = new SqlCommand("pr_SearchDataOnStudents", conn.connection);
			command.CommandType = CommandType.StoredProcedure;
			command.Parameters.Add(new SqlParameter("@Surname", SqlDbType.VarChar, 30));
			command.Parameters["@Surname"].Value = searchDataTextBox.Text;

			try
			{
				DataTable table = new DataTable();
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				adapter.Fill(table);
				BindingSource bs = new BindingSource();
				bs.DataSource = table;
				GridListStudents.DataSource = bs;
			}
			catch (Exception)
			{
				throw;
			}
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
				GridListCertification.DefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
				labelSearch.ForeColor = ThemeColor.PrimaryColor;
			}
		}

		#endregion

		
	}
}
