using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace coursework
{
	public partial class FormAddEditAchievements : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		readonly int id = -1;

		public FormAddEditAchievements()
		{
			InitializeComponent();
		}

		public FormAddEditAchievements(int id, string classOfReward, string typeOfReward, string subjectOfReward) : base()
		{
			InitializeComponent();
			this.id = id;
			textBox1.Text = classOfReward;
			textBox2.Text = typeOfReward;
			textBox3.Text = subjectOfReward;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			conn.Connect();
			try
			{
				SqlCommand command = new SqlCommand();

				if (id == -1) // Добавление нового ученика
				{
					command = new SqlCommand("insert into achievements_students (classOfReward, typeOfReward, subjectOfReward) " +
											"values (@classOfReward, @typeOfReward, @subjectOfReward)", conn.connection);
					//command.Parameters.Add("classOfReward", DbType.String).Value = textBox1.Text;
					//command.Parameters.Add("typeOfReward", DbType.String).Value = textBox2.Text;
					//command.Parameters.Add("subjectOfReward", DbType.String).Value = textBox3.Text;
					command.ExecuteNonQuery();
					MessageBox.Show("Запись добавлена!", "", MessageBoxButtons.OK);
				}
				else // Редактирование информации ученика
				{
					command = new SqlCommand(
						$"update achievements_students set classOfReward = 'test', typeOfReward = 'test', subjectOfReward = 'test' where id = 5", conn.connection);
					//$"update achievements_students set classOfReward = @сlassOfReward, typeOfReward = '{textBox2.Text}', subjectOfReward = '{textBox3.Text}' where id = '{id}'", conn.connection);

					//command.Parameters.Add("сlassOfReward", DbType.String).Value = textBox1.Text;
					//command.Parameters.Add("typeOfReward", DbType.String).Value = textBox2.Text;
					//command.Parameters.Add("subjectOfReward", DbType.Int32).Value = textBox3.Text;
					//command.Parameters.Add("id", DbType.Int32).Value = id;
					//command.ExecuteNonQuery();
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this.Close();
			conn.Disconnect();
		}
	}
}
