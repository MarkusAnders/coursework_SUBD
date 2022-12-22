using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace coursework
{
	public class DatabaseConnect
	{
		public SqlConnection connection;
		public void Connect()

		{
			try
			{
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
