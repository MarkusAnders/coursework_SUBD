using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			conn.Connect();
			ReloadTableStudents();
			conn.Disconnect();
		}

		public void ReloadTableStudents()
		{
			conn.Connect();
			dataGridView1.Rows.Clear();
			int counter = 0;
			SQLiteCommand cmd = new SQLiteCommand("select * from achievements_students", conn.connection);
			SQLiteDataReader reader = null;
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
