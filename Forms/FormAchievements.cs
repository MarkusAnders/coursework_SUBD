using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace coursework
{
	public partial class FormAchievements : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();

		public FormAchievements()
		{
			InitializeComponent();
		}

		private void FormAchievements_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "subd_schoolDataSet.lstudents". При необходимости она может быть перемещена или удалена.
			this.lstudentsTableAdapter.Fill(this.subd_schoolDataSet.lstudents);
			conn.Connect();
			ReloadTableStudents();
			conn.Disconnect();
		}

		public void ReloadTableStudents()
		{
			conn.Connect();
			dataGridView1.Rows.Clear();
			int counter = 0;
			SqlCommand cmd = new SqlCommand("select * from achievements_students", conn.connection);
			SqlDataReader reader = null;
			reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				dataGridView1.Rows.Add();
				dataGridView1.Rows[counter].Cells[0].Value = Convert.ToInt32(reader["id"]);
				dataGridView1.Rows[counter].Cells[1].Value = Convert.ToString(reader["classOfReward"]);
				dataGridView1.Rows[counter].Cells[2].Value = Convert.ToString(reader["typeOfReward"]);
				dataGridView1.Rows[counter].Cells[3].Value = Convert.ToString(reader["subjectOfReward"]);
				counter++;
			}
			conn.Disconnect();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormAddEditAchievements formAEA = new FormAddEditAchievements();
			formAEA.ShowDialog();

			ReloadTableStudents();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int id = int.Parse(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
			string classOfReward = dataGridView1.SelectedRows[0].Cells["classNagrada"].Value.ToString();
			string typeOfReward = dataGridView1.SelectedRows[0].Cells["typeNagrada"].Value.ToString();
			string subjectOfReward = dataGridView1.SelectedRows[0].Cells["predmetNagrada"].Value.ToString();

			new FormAddEditAchievements(id, classOfReward, typeOfReward, subjectOfReward).ShowDialog();

			ReloadTableStudents();
		}
	}
}
