using System.Windows.Forms;
using System.Data.SQLite;

namespace coursework
{
	public class DatabaseConnect
	{
<<<<<<< HEAD
		public SQLiteConnection connection;
		public void Connect()
=======
		static SQLiteConnection connection;
		static public void Connect()
>>>>>>> 7c18ac7 (Добавление класса подключение базы данных)
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

<<<<<<< HEAD
		public void Disconnect()
=======
		static public void Disconnect()
>>>>>>> 7c18ac7 (Добавление класса подключение базы данных)
		{
			connection.Close();
		}
	}
}
