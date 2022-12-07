using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
			Application.Run(new FormMain());
=======
			Application.Run(new MainForm());
>>>>>>> 7c18ac7 (Добавление класса подключение базы данных)
		}
	}
}
