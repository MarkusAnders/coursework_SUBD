using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace coursework
{
	public partial class ListSubjects : Form
	{
        readonly DatabaseConnect conn = new DatabaseConnect();
        
        public ListSubjects()
		{
			InitializeComponent();
		}

		private void ListSubjects_Load(object sender, EventArgs e)
		{
			try
			{
				int counter = 0;
				conn.Connect();
				SQLiteCommand cmd = new SQLiteCommand("select * from academic_subject", conn.connection);
				SQLiteDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{

					GridListSubjects.Rows.Add();
					GridListSubjects.Rows[counter].Cells[0].Value = Convert.ToString(reader["nameSubject"]);
					GridListSubjects.Rows[counter].Cells[1].Value = Convert.ToString(reader["hours"]);
					counter++;
				}
			}

			catch
			{
				MessageBox.Show("Ошибка подключения к таблице", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
		}

		private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}