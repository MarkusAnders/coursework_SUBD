using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace coursework
{
	public partial class FormMain : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		public SQLiteCommand cmd = new SQLiteCommand();
		public FormMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			conn.Connect();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			conn.Disconnect();
		}

		#region[Переход на другие формы]
		private void button_listStudent_Click(object sender, EventArgs e)
		{
			FormListStudents Lstudents = new FormListStudents();
			Lstudents.ShowDialog();

			//	button_listStudent.BackColor = Color.FromArgb(0, 140, 243);
		}

		private void button_achievementStudent_Click(object sender, EventArgs e)
		{
			FormAchievements formA = new FormAchievements();
			formA.ShowDialog();
			//button_achievementStudent.BackColor = Color.FromArgb(0, 140, 243);
		}

		private void button_listSubjects_Click(object sender, EventArgs e)
		{
			FormListSubjects Lsubjects = new FormListSubjects();
			Lsubjects.ShowDialog();
			//button_listSubjects.BackColor = Color.FromArgb(0, 140, 243);
		}
		#endregion

	}
}
 