using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace coursework
{
	public partial class EditInfoStudent : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();
		public EditInfoStudent()
		{
			InitializeComponent();
		}
		#region[EditInfoStudent]

		private void button_confirmEditInfo_Click(object sender, EventArgs e)
		{
			
		}

		#endregion

		#region[PhotoStudent]
		private void button_addPhotoStudent_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
			if (ofd.ShowDialog() == DialogResult.OK && Path.GetExtension(ofd.FileName) == ".png" || Path.GetExtension(ofd.FileName) == ".jpeg" || Path.GetExtension(ofd.FileName) == ".jpg")
			{
				picturePhotoStudent.Image = Image.FromFile(ofd.FileName);
			}
		}
		private void button_deletePhotoStudent_Click(object sender, EventArgs e)
		{
			picturePhotoStudent.Image = null;
		}

		#endregion

		private void button_cancellation_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
