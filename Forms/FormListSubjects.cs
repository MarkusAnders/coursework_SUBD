using System;
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
		private void ListSubjects_Load(object sender, EventArgs e)
		{
			conn.Connect();

			try
			{
				ReloadTableSubjects();
			}
			catch
			{
				MessageBox.Show("Ошибка подключения к таблице", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
			conn.Disconnect();
		}

		public void ReloadTableSubjects()
		{
			conn.Connect();
			GridListSubjects.Rows.Clear();
			int counter = 0;
			SQLiteCommand cmd = new SQLiteCommand("select * from academic_subject", conn.connection);
			SQLiteDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				GridListSubjects.Rows.Add();
				GridListSubjects.Rows[counter].Cells[0].Value = Convert.ToInt32(reader["id"]);
				GridListSubjects.Rows[counter].Cells[1].Value = Convert.ToString(reader["nameSubject"]);
				GridListSubjects.Rows[counter].Cells[2].Value = Convert.ToString(reader["hours"]);
				counter++;
			}
			conn.Disconnect();
		}
		#endregion

		#region[Кнопки добавление, редактирование, удаления и закрытия]
		private void button_addRecord_Click(object sender, EventArgs e)
		{
			FormAddEditSubject formAES = new FormAddEditSubject();
			formAES.label7.Text = "Добавление нового предмета";
			formAES.button_editRecord.Text = "  Добавить";
			formAES.button_editRecord.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"icon/add-subject.png"));
			formAES.ShowDialog();
			ReloadTableSubjects();
		}

		private void button_editRecord_Click(object sender, EventArgs e)
		{
			int id = int.Parse(GridListSubjects.SelectedRows[0].Cells["id"].Value.ToString());
			string nameSubject = GridListSubjects.SelectedRows[0].Cells["Subjects"].Value.ToString();
			int hourSubject = int.Parse(GridListSubjects.SelectedRows[0].Cells["Hours"].Value.ToString());
			new FormAddEditSubject(id, nameSubject, hourSubject).ShowDialog();
			ReloadTableSubjects();
		}

		private void button_deleteRecord_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы прадва хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				conn.Connect();
				int id = int.Parse(GridListSubjects.SelectedRows[0].Cells["id"].Value.ToString());
				SQLiteCommand delete = new SQLiteCommand("delete from academic_subject where id=" + id, conn.connection);
				delete.ExecuteNonQuery();
				MessageBox.Show("Запись удалена!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ReloadTableSubjects();
				conn.Disconnect();
			}
		}

		private void button_exitFromFrom_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion


	}
}