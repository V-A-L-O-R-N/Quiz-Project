using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication
{
	public partial class Splash : Form
	{
		public Splash()
		{
			InitializeComponent();
		}

		private void Splash_Load(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			QuizApplication quiz = new QuizApplication();
			quiz.Show();
			this.Hide();
			timer1.Stop();
		}
	}
}
