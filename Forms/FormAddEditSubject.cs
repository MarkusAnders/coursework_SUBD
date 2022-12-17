using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace coursework
{
	public partial class FormAddEditSubject : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		readonly int id = -1;

		string checkingForChangesNameSubject = string.Empty;
		string checkingForChangesHoursSubject = string.Empty;
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

			// Проверка изменение данных. Если не изменились, то мы не вызываем запрос update.
			checkingForChangesNameSubject = nameSubject;
			checkingForChangesHoursSubject = hourSubject.ToString();
		}

		#region[[Add new subject or edit info]
		private void button_editRecord_Click(object sender, EventArgs e)
		{
			conn.Connect();
			try
			{
				SqlCommand command = new SqlCommand();

				if (id == -1) // Добавление нового ученика
				{
					command = new SqlCommand(
						"insert into academic_subject (subject, hours) values (@subject, @hours)", conn.connection);
					command.Parameters.Add("@subject", SqlDbType.VarChar).Value = nameSubjectTextBox.Text;
					command.Parameters.Add("@hours", SqlDbType.Int).Value = hourSubjectOfTextBox.Text;
					command.ExecuteNonQuery();

					MessageBox.Show("Запись добавлена!", "", MessageBoxButtons.OK);

					this.Close();
				}
				else // Редактирование информации ученика
				{
					if (checkingForChangesNameSubject == nameSubjectTextBox.Text && checkingForChangesHoursSubject == hourSubjectOfTextBox.Text)
					{
						MessageBox.Show("Данные не изменились!", "", MessageBoxButtons.OK);
					}
					else
					{
						if (MessageBox.Show("Вы прадва хотите изменить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							command = new SqlCommand(
							"update academic_subject set subject = @subject, hours = @hours where id = @id", conn.connection);
							command.Parameters.Add("id", SqlDbType.Int).Value = id;
							command.Parameters.Add("subject", SqlDbType.VarChar).Value = nameSubjectTextBox.Text;
							command.Parameters.Add("hours", SqlDbType.Int).Value = hourSubjectOfTextBox.Text;
							command.ExecuteNonQuery();

							MessageBox.Show("Данные были изменены!", "", MessageBoxButtons.OK);

							this.Close();
						}
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
