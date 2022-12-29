using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace coursework
{
	public partial class FormAddEditCertification : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		readonly int id = -1;
		int idStudent;
		double averageAnnual;
		string checkingForChangesSubject = string.Empty;
		string checkingForChangesFirstQuater = string.Empty;
		string checkingForChangesSecondQuater = string.Empty;
		string checkingForChangesThirdQuater = string.Empty;
		string checkingForChangesFourthQuater = string.Empty;

		public FormAddEditCertification()
		{
			InitializeComponent();
		}
		private void FormAddEditCertification_Load(object sender, System.EventArgs e)
		{
			this.academic_subjectTableAdapter.Fill(this.subd_schoolDataSet.academic_subject);
			listSubjectsBox.SelectedValue = checkingForChangesSubject;
		}

		#region[Передача данных]
		public FormAddEditCertification(int id_Student) : base()
		{
			InitializeComponent();
			idStudent = id_Student;
			labelTitle.Text = "Добавление оценок";
			button_editRecord.Text = "Добавить  ";
			button_editRecord.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"icon\certification.png"));
		}

		public FormAddEditCertification(int id, string subject, int firstQuarter, int secondQuarter, int thirdQuarter, int fourthQuarter, int annual, int id_Student) : base()
		{
			InitializeComponent();
			this.id = id;
			firstQuaterOfTextBox.Text = firstQuarter.ToString();
			secondQuaterOfTextBox.Text = secondQuarter.ToString();
			thirdQuaterOfTextBox.Text = thirdQuarter.ToString();
			fourthQuaterOfTextBox.Text = fourthQuarter.ToString();
			idStudent = id_Student;

			checkingForChangesSubject = subject;
			checkingForChangesFirstQuater = firstQuarter.ToString();
			checkingForChangesSecondQuater = secondQuarter.ToString();
			checkingForChangesThirdQuater = thirdQuarter.ToString();
			checkingForChangesFourthQuater = fourthQuarter.ToString();
		}
		#endregion

		#region[Кнопки добавления, редактирования и закрытия формы]
		private void button_editRecord_Click(object sender, System.EventArgs e)
		{
			AverageAnnual();
			conn.Connect();
			try
			{
				SqlCommand command = new SqlCommand();
				if (id == -1) // Добавление нового записи
				{
					command = new SqlCommand("insert into certification (subject, firstQuarter, secondQuarter, thirdQuarter, fourthQuarter, annual, id_Student) " +
											"values (@subject, @firstQuarter, @secondQuarter, @thirdQuarter, @fourthQuarter, @annual, @id_Student)", conn.connection);
					command.Parameters.Add("subject", SqlDbType.VarChar).Value = listSubjectsBox.Text;
					command.Parameters.Add("firstQuarter", SqlDbType.Int).Value = firstQuaterOfTextBox.Text;
					command.Parameters.Add("secondQuarter", SqlDbType.Int).Value = secondQuaterOfTextBox.Text;
					command.Parameters.Add("thirdQuarter", SqlDbType.Int).Value = thirdQuaterOfTextBox.Text;
					command.Parameters.Add("fourthQuarter", SqlDbType.Int).Value = fourthQuaterOfTextBox.Text;
					command.Parameters.Add("annual", SqlDbType.Int).Value = averageAnnual;
					command.Parameters.Add("id_Student", SqlDbType.Int).Value = idStudent;

					command.ExecuteNonQuery();
					MessageBox.Show("Запись добавлена!", "", MessageBoxButtons.OK);

					this.Close();
				}
				else // Редактирование записи
				{
					if (checkingForChangesFirstQuater == firstQuaterOfTextBox.Text && checkingForChangesSecondQuater == secondQuaterOfTextBox.Text &&
						checkingForChangesThirdQuater == thirdQuaterOfTextBox.Text && checkingForChangesFourthQuater == fourthQuaterOfTextBox.Text &&
						listSubjectsBox.SelectedValue.ToString() == checkingForChangesSubject)
					{
						MessageBox.Show("Данные не изменились!", "");
					}
					else
					{
						if (MessageBox.Show("Вы прадва хотите изменить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							command = new SqlCommand($"update certification set subject = @subject, firstQuarter = @firstQuarter, secondQuarter = @secondQuarter, thirdQuarter = @thirdQuarter, " +
								$"fourthQuarter = @fourthQuarter, annual = @annual where id = @id", conn.connection);
							command.Parameters.Add("@subject", SqlDbType.VarChar).Value = listSubjectsBox.Text;
							command.Parameters.Add("@firstQuarter", SqlDbType.VarChar).Value = firstQuaterOfTextBox.Text;
							command.Parameters.Add("@secondQuarter", SqlDbType.VarChar).Value = secondQuaterOfTextBox.Text;
							command.Parameters.Add("@thirdQuarter", SqlDbType.VarChar).Value = thirdQuaterOfTextBox.Text;
							command.Parameters.Add("@fourthQuarter", SqlDbType.VarChar).Value = fourthQuaterOfTextBox.Text;
							command.Parameters.Add("@annual", SqlDbType.VarChar).Value = averageAnnual;
							command.Parameters.Add("@id", SqlDbType.Int).Value = id;
							command.Parameters.Add("@id_student", SqlDbType.Int).Value = idStudent;
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
			conn.Disconnect();
		}
		private void button_exitFromFrom_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region[Перетаскивание]
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void panelMainTitle_MouseDown_1(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}


		#endregion

		#region[Запрет ввода букв]
		private void firstQuaterOfTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;

			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}
		private void annualOfTextBox_TextChanged(object sender, EventArgs e)
		{
			if (firstQuaterOfTextBox.Text != "")
			{
				int number = Convert.ToInt32(Regex.Match(firstQuaterOfTextBox.Text, @"\d+").Value);
				if (number > 5 || number < 1)
				{
					MessageBox.Show("Число должно быть от 1 до 5!");
					firstQuaterOfTextBox.Text = string.Empty;
				}
			}

			if (secondQuaterOfTextBox.Text != "")
			{
				int number = Convert.ToInt32(Regex.Match(secondQuaterOfTextBox.Text, @"\d+").Value);
				if (number > 5 || number < 1)
				{
					MessageBox.Show("Число должно быть от 1 до 5!");
					secondQuaterOfTextBox.Text = string.Empty;
				}
			}

			if (thirdQuaterOfTextBox.Text != "")
			{
				int number = Convert.ToInt32(Regex.Match(thirdQuaterOfTextBox.Text, @"\d+").Value);
				if (number > 5 || number < 1)
				{
					MessageBox.Show("Число должно быть от 1 до 5!");
					thirdQuaterOfTextBox.Text = string.Empty;
				}
			}

			if (fourthQuaterOfTextBox.Text != "")
			{
				int number = Convert.ToInt32(Regex.Match(fourthQuaterOfTextBox.Text, @"\d+").Value);
				if (number > 5 || number < 1)
				{
					MessageBox.Show("Число должно быть от 1 до 5!");
					fourthQuaterOfTextBox.Text = string.Empty;
				}
			}
		}
		#endregion

		#region[Средняя оценка]
		private void AverageAnnual()
		{
			double averageEstimation, first, second, third, fourth;
			if (firstQuaterOfTextBox.Text != string.Empty && secondQuaterOfTextBox.Text != string.Empty && thirdQuaterOfTextBox.Text != string.Empty && fourthQuaterOfTextBox.Text != string.Empty)
			{
				first = double.Parse(firstQuaterOfTextBox.Text);
				second = double.Parse(secondQuaterOfTextBox.Text);
				third = double.Parse(thirdQuaterOfTextBox.Text);
				fourth = double.Parse(fourthQuaterOfTextBox.Text);
				averageEstimation = Math.Round((first + second + third + fourth) / 4, MidpointRounding.AwayFromZero);
				averageAnnual = averageEstimation;
			}
		}
		#endregion
	}
}
