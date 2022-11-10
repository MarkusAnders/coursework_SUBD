using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace coursework
{
	public partial class ListStudents : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		public ListStudents()
		{
			InitializeComponent();
		}	
		private void ListStudents_Load(object sender, EventArgs e)
		{
			try
			{
				int counter = 0;
				conn.Connect();
				SQLiteCommand cmd = new SQLiteCommand("select * from list_students", conn.connection);
				SQLiteDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					GridListStudents.Rows.Add();
					GridListStudents.Rows[counter].Cells[0].Value = Convert.ToString(reader["name"]);
					GridListStudents.Rows[counter].Cells[1].Value = Convert.ToString(reader["surname"]);
					GridListStudents.Rows[counter].Cells[2].Value = Convert.ToString(reader["patronymic"]);
					GridListStudents.Rows[counter].Cells[3].Value = Convert.ToString(reader["class"]);
					GridListStudents.Rows[counter].Cells[4].Value = reader["dataOfBirthDay"];
					counter++;
				}
			}

			catch
			{
				MessageBox.Show("Ошибка подключения к таблице", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
		}

		private void button_addStudent_Click(object sender, EventArgs e)
		{
			EditInfoStudent EIS = new EditInfoStudent();
			EIS.ShowDialog();
		}

		private void button_editStudent_Click(object sender, EventArgs e)
		{

		}

		private void button_deleteStudent_Click(object sender, EventArgs e)
		{

		}
	}
}
