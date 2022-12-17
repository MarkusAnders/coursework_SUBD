using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace coursework
{
	public class DatabaseConnect
	{
		//public SQLiteConnection connection;
		public SqlConnection connection;
		public void Connect()

		{
			try
			{
				//connection = new SQLiteConnection("Data Source=AIS_school.db; Version=3; FailIfMissing=False");
				connection = new SqlConnection(@"Data Source=localhost; Initial Catalog=subd_school; Integrated Security=true");
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
