using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
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

		private void списокКлассовToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void списокПредметовToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormListSubjects Lsubjects = new FormListSubjects();
			Lsubjects.ShowDialog();
		}

		private void списокУчениковToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormListStudents Lstudents = new FormListStudents();
			Lstudents.ShowDialog();
		}
	}
}
