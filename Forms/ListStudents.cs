using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace coursework
{
	public partial class ListStudents : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		MemoryStream ms = null;
		byte[] ArrayImage;
		Image photo;
		Bitmap b;

		public ListStudents()
		{
			InitializeComponent();
		}	
		private void ListStudents_Load(object sender, EventArgs e)
		{
			conn.Connect();
			GridListStudents.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
			try
			{
				int counter = 0;
				SQLiteCommand cmd = new SQLiteCommand("select * from list_students", conn.connection);
				SQLiteDataReader reader = null;
				reader = cmd.ExecuteReader();
			
				while (reader.Read())
				{
					//ArrayImage = new byte[((byte[])reader["image"]).Length];
					//ArrayImage = (byte[])reader["image"];
					//ms = new MemoryStream(ArrayImage);
					//b = new Bitmap(ms);
					//photo = new Bitmap(b, 150, 100);

					GridListStudents.Rows.Add();
					GridListStudents.Rows[counter].Cells[0].Value = Convert.ToString(reader["name"]);
					GridListStudents.Rows[counter].Cells[1].Value = Convert.ToString(reader["surname"]);
					GridListStudents.Rows[counter].Cells[2].Value = Convert.ToString(reader["patronymic"]);
					GridListStudents.Rows[counter].Cells[3].Value = Convert.ToString(reader["class"]).ToUpper();
					GridListStudents.Rows[counter].Cells[4].Value = reader["dataOfBirthday"];
					//GridListStudents.Rows[counter].Cells[5].Value = photoArray;
					counter++;
				}
				//ms.Close();
			}
			catch
			{
				MessageBox.Show("Ошибка подключения к таблице", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
		}

		private void button_addStudent_Click(object sender, EventArgs e)
		{
			AddStudent AS = new AddStudent();
			AS.ShowDialog();
		}

		private void button_editStudent_Click(object sender, EventArgs e)
		{
			EditInfoStudent EIS = new EditInfoStudent();
			EIS.Show();
		}

		private void button_deleteStudent_Click(object sender, EventArgs e)
		{
			SQLiteCommand delete = new SQLiteCommand("delete from list_students where name=@name", conn.connection);
			delete.Parameters.Add("@name", (DbType)this.GridListStudents.CurrentRow.Cells["name"].Value);
			delete.ExecuteNonQuery();
		}
	}
}
