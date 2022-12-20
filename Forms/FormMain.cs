using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace coursework
{
	public partial class FormMain : Form
	{
		readonly DatabaseConnect conn = new DatabaseConnect();

		//fields
		private Button currentButton;
		private Random random;
		private int tempIndex;
		public Form activeForm = null;

		//constructor
		public FormMain()
		{
			InitializeComponent();
			random = new Random();
			button_closeChildForm.Visible = false;
			this.Text = string.Empty;
			this.ControlBox = false;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}

		#region[conn/disc database]
		private void FormMain_Load(object sender, EventArgs e)
		{
			conn.Connect();
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			conn.Disconnect();
		}
		#endregion

		//methods
		#region[Измение цвета]
		private Color SelectThemeColor()
		{
			int index = random.Next(ThemeColor.ColorList.Count);
			while (tempIndex == index)
			{
				index = random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];
			return ColorTranslator.FromHtml(color);

		}
		#endregion

		#region[Активная кнопка]
		private void ActivateButton(object btnSender)
		{
			if (btnSender != null)
			{
				if (currentButton != (Button)btnSender)
				{
					DisableButton();
					Color color = SelectThemeColor();
					currentButton = (Button)btnSender;
					currentButton.BackColor = color;
					currentButton.ForeColor = Color.White;
					panelTitle.BackColor = color;
					panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
					ThemeColor.PrimaryColor = color;
					ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
					button_closeChildForm.Visible = true;
				}
			}
		}
		private void DisableButton()
		{
			foreach (Control previousBtn in panelMenu.Controls)
			{
				if (previousBtn.GetType() == typeof(Button))
				{
					previousBtn.BackColor = Color.FromArgb(31, 30, 68);
					previousBtn.ForeColor = Color.Gainsboro;
				}
			}
		}
		#endregion

		#region[Открытие формы в форме]
		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Close();
			ActivateButton(btnSender);
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
		#endregion

		#region[Кнопка закрытия формы]
		private void button_closeChildForm_Click(object sender, EventArgs e)
		{
			if (activeForm != null)
				activeForm.Close();
			Reset();
		}
		private void Reset()
		{
			DisableButton();
			labelTitle.Text = "ГЛАВНАЯ";
			panelTitle.BackColor = Color.FromArgb(0, 150, 136);
			panelLogo.BackColor = Color.FromArgb(31, 30, 68);
			currentButton = null;
			button_closeChildForm.Visible = false;
		}
		#endregion

		#region[Переход на другие формы]
		private void button_certification_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			OpenChildForm(new FormCertification(), sender);
			labelTitle.Text = "АТТЕСТАЦИЯ";
		}

		private void button_achievements_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			//OpenChildForm(new FormAchievements(), sender);
			labelTitle.Text = "ДОСТИЖЕНИЯ";
		}

		private void button_listStudents_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			OpenChildForm(new FormListStudents(), sender);
			labelTitle.Text = "УЧЕНИКИ";
		}

		private void button_listSubjects_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			OpenChildForm(new FormListSubjects(), sender);
			labelTitle.Text = "ПРЕДМЕТЫ";
		}
		#endregion

		#region[Перетаскивание программы за панель]
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void panelTitle_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion

		#region[Кнопки min, max, exit]
		private void button_exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void button_maximize_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
				this.WindowState = FormWindowState.Maximized;
			else
				this.WindowState = FormWindowState.Normal;
		}

		private void button_minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		#endregion
	}
}
 