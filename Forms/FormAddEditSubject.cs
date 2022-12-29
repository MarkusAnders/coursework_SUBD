using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
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
		private void button_editRecord_Click_1(object sender, EventArgs e)
		{
			conn.Connect();
			if (nameSubjectTextBox.Text == string.Empty || hourSubjectOfTextBox.Text == string.Empty)
			{
				MessageBox.Show("Не все поля заполнены","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
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

								this.Close();
							}
						}
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			conn.Disconnect();
		}
		private void button_closeForm_Click(object sender, EventArgs e)
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

		private void hourSubjectOfTextBox_TextChanged(object sender, EventArgs e)
		{
			if (hourSubjectOfTextBox.Text != "")
			{
				int checkHour = Convert.ToInt32(Regex.Match(hourSubjectOfTextBox.Text, @"\d+").Value);
				if (checkHour == 0)
				{
					MessageBox.Show("Кол-во часов не может быть равно нулю", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					hourSubjectOfTextBox.Text = string.Empty;
				}
			}
		}
		#endregion

		#region[Перетаскивание формы]
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void panelMainTitle_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion
	}
}
