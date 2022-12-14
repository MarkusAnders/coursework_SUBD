using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace coursework
{
	public partial class FormAddEditAchievements : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		readonly int id = -1;
		int idStudent;
		string checkingForChangesNameOfReward = string.Empty;
		string checkingForChangesClassOfReward = string.Empty;
		string checkingForChangesTypeOfReward = string.Empty;
		string checkingForChangesSubjectOfReward = string.Empty;

		public FormAddEditAchievements()
		{
			InitializeComponent();
		}
		private void FormAddEditAchievements_Load(object sender, EventArgs e)
		{
			this.academic_subjectTableAdapter.Fill(this.subd_schoolDataSet.academic_subject);
			listSubjectsBox.SelectedValue = checkingForChangesSubjectOfReward;
		}

		#region[Передача данных]
		public FormAddEditAchievements(int id_Student) : base() // Для добавления
		{
			InitializeComponent();
			idStudent = id_Student;
			labelTitle.Text = "Добавление достижения";
			button_editRecord.Text = "Добавить  ";
			button_editRecord.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"icon\reward.png"));
		}

		public FormAddEditAchievements(int id, string nameOfReward, string classOfReward, string typeOfReward, string subjectOfReward, int id_Student) : base() // Для редактирования 
		{
			InitializeComponent();
			this.id = id;

			nameOfRewardOfTextBox.Text = nameOfReward;
			classOfRewardOfTextBox.Text = classOfReward;
			typeOfRewardOfTextBox.Text = typeOfReward;
			idStudent = id_Student;

			checkingForChangesNameOfReward = nameOfReward;
			checkingForChangesClassOfReward = classOfReward;
			checkingForChangesTypeOfReward = typeOfReward;
			checkingForChangesSubjectOfReward = subjectOfReward;
		}
		#endregion

		#region[Кнопки редактирования и закрытия]
		private void button_editRecord_Click_1(object sender, EventArgs e)
		{
			if (classOfRewardOfTextBox.Text == string.Empty || typeOfRewardOfTextBox.Text == string.Empty || listSubjectsBox.SelectedValue == null)
			{
				MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				conn.Connect();
				try
				{
					SqlCommand command = new SqlCommand();
					if (id == -1) // Добавление нового ученика
					{
						command = new SqlCommand("insert into achievements_students (nameOfReward, classOfReward, typeOfReward, subjectOfReward, id_Student) " +
												"values (@nameOfReward, @classOfReward, @typeOfReward, @subjectOfReward, @id_Student)", conn.connection);
						command.Parameters.Add("nameOfReward", SqlDbType.VarChar).Value = nameOfRewardOfTextBox.Text;
						command.Parameters.Add("classOfReward", SqlDbType.VarChar).Value = classOfRewardOfTextBox.Text;
						command.Parameters.Add("typeOfReward", SqlDbType.VarChar).Value = typeOfRewardOfTextBox.Text;
						command.Parameters.Add("subjectOfReward", SqlDbType.VarChar).Value = listSubjectsBox.Text;
						command.Parameters.Add("id_Student", SqlDbType.Int).Value = idStudent;

						command.ExecuteNonQuery();
						MessageBox.Show("Запись добавлена!", "", MessageBoxButtons.OK);

						this.Close();
					}
					else // Редактирование информации ученика
					{
						if (checkingForChangesNameOfReward == nameOfRewardOfTextBox.Text && checkingForChangesClassOfReward == classOfRewardOfTextBox.Text && checkingForChangesTypeOfReward == typeOfRewardOfTextBox.Text &&
							listSubjectsBox.SelectedValue.ToString() == checkingForChangesSubjectOfReward)
						{
							MessageBox.Show("Данные не изменились!", "");
						}
						else
						{
							if (MessageBox.Show("Вы прадва хотите изменить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
							{
								command = new SqlCommand( $"update achievements_students set  nameOfReward = @nameOfReward, classOfReward = @classOfReward, typeOfReward = @typeOfReward, subjectOfReward = @subjectOfReward where id = @id", conn.connection);
								command.Parameters.Add("@nameOfReward", SqlDbType.VarChar).Value = nameOfRewardOfTextBox.Text;
								command.Parameters.Add("@classOfReward", SqlDbType.VarChar).Value = classOfRewardOfTextBox.Text;
								command.Parameters.Add("@typeOfReward", SqlDbType.VarChar).Value = typeOfRewardOfTextBox.Text;
								command.Parameters.Add("@subjectOfReward", SqlDbType.VarChar).Value = listSubjectsBox.Text;
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
		}

		private void button_exitFromFrom_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region[Перетаскивание]
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

		#region[Запрет ввода символов и цифр]
		private void classOfRewardOfTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar)) return;
			else
				e.Handled = true;
		}

		private void nameOfRewardOfTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar)) return;
			else
				e.Handled = true;
		}
		#endregion
	}
}
