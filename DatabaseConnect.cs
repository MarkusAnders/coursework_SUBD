using System.Windows.Forms;
using System.Data.SQLite;

namespace coursework
{
	public class DatabaseConnect
	{
		public SQLiteConnection connection;
		public void Connect()

		{
			try
			{
				connection = new SQLiteConnection("Data Source=AIS_school.db; Version=3; FailIfMissing=False");
				connection.Open();
			}
			catch(SQLiteException exception)
			{
				MessageBox.Show("Ошибка подключения к базе данных", exception.Message , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Disconnect()
		{
			connection.Close();
		}
	}
}
