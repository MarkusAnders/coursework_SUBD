using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace coursework
{
	public partial class MainForm : Form
	{
		static SQLiteCommand cmd = new SQLiteCommand();

		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DatabaseConnect.Connect();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			DatabaseConnect.Disconnect();
		}


	}
}
