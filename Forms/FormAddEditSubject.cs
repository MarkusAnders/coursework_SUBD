using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace coursework
{
	public partial class FormAddEditSubject : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		readonly int id = -1;
		public FormAddEditSubject()
		{
			InitializeComponent();
		}

		public FormAddEditSubject(int id, string nameSubject, int hourSubject) : base()
		{
			InitializeComponent();
			this.id = id;
			nameSubjectTextBox.Text = nameSubject;
			hourSubjectOfTextBox.Text = hourSubject.ToString();
		}

		#region[[Add new subject or edit info]
		private void button_editRecord_Click(object sender, EventArgs e)
		{
			conn.Connect();
			try
			{
				SQLiteCommand command;

				if (id == -1) // Добавление нового ученика
				{
					command = new SQLiteCommand(
						"insert into academic_subject (nameSubject, hours) values (@nameSubject, @hourSubject)", conn.connection);
					command.Parameters.Add("nameSubject", DbType.String).Value = nameSubjectTextBox.Text;
					command.Parameters.Add("hourSubject", DbType.Int32).Value = hourSubjectOfTextBox.Text;

					MessageBox.Show("Запись добавлена!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else // Редактирование информации ученика
				{
					if (MessageBox.Show("Вы прадва хотите изменить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						command = new SQLiteCommand(
						"update academic_subject set nameSubject = @nameSubject, hours = @hourSubject where id = @id", conn.connection);
						command.Parameters.Add("nameSubject", DbType.String).Value = nameSubjectTextBox.Text;
						command.Parameters.Add("hourSubject", DbType.Int32).Value = hourSubjectOfTextBox.Text;
						command.Parameters.Add("id", DbType.Int32).Value = id;

						MessageBox.Show("Данные были изменены!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					return;
				}

				command.ExecuteNonQuery();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this.Close();
			conn.Disconnect();
		}

		private void button_exitFromFrom_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion


		#region[Запрет ввода чисел и букв]
		private void nameSubjectTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar)) return;
			else
				e.Handled = true;
		}

		private void hourSubjectOfTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;

			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}
		#endregion

		
	}
}
