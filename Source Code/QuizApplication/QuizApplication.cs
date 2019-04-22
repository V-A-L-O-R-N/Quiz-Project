using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace QuizApplication
{
    public partial class QuizApplication : Form
    {
        public QuizApplication()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            lblanswer1.Visible = false;
            btnenterletter.Enabled = false;
            btnguess3.Enabled = false;
        }
		///////////////////////////////////////////////////////////////////////////////
		///REFERENCE MOVABLE TOP SECTİON
		public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
		///////////////////////////////////////////////////////////////////////////////
		///QUİZ LOAD
		private void QuizApplication_Load(object sender, EventArgs e)
        {
            lblquest.Text = counter.ToString();
            lblanswer.Visible = false;
            quiz1panel.Visible = false;
        }
		///////////////////////////////////////////////////////////////////////////////
		/// DATABASE CONNECTİON	
		SqlConnection a = new SqlConnection("Data Source=HUZEYFE\\SQLEXPRESS;Initial Catalog=QuizApp;Integrated Security=True");
		///////////////////////////////////////////////////////////////////////////////
		/// EXİT OPACİTİY TİMER
		private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            { this.Opacity -= 0.050; }

            else
            {
                timer1.Stop();
                System.Windows.Forms.Application.Exit();
            }
        }
		///////////////////////////////////////////////////////////////////////////////
		//exit timer start
		private void exitbox_Click(object sender, EventArgs e)
        {    
            timer1.Start();
        }
		///////////////////////////////////////////////////////////////////////////////
		//dropminbox
		private void dropminbox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }
		///////////////////////////////////////////////////////////////////////////////
		///MOVABLE FORM
		private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
		///////////////////////////////////////////////////////////////////////////////
		///LEFT MENU DECREASE
		private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (leftpanel.Width == 250)
            {
                leftpanel.Width = 50;
                panel2.Width = 50;
                logobox.Visible = false;
                leftbox.Visible = false;
                rightbox.Visible = true;
                versionlabel.Visible = false;
                valorpanel.Visible = true;
            }
            welcome.Visible = false;
            homeactivatebox.Visible = false;
            quizactivatebox.Visible = false;
            scoreboardactivatebox.Visible = false;
            languageactivatebox.Visible = false;
            contactactivatebox.Visible = false;

        }
		///////////////////////////////////////////////////////////////////////////////
		///RİGHT MENU EXPAND
		private void rightbox_Click(object sender, EventArgs e)
        {
            if (leftpanel.Width == 50)
            {
                leftpanel.Width = 250;
                panel2.Width = 250;
                logobox.Visible = true;
                leftbox.Visible = true;
                rightbox.Visible = false;
                valorpanel.Visible = false;
                versionlabel.Visible = true;
                homeactivatebox.Visible = false;
                homeactivatelabel.Visible = false;
            }

            if (homebutton.selected)
            {
                homeactivatebox.Visible = true;
                homeactivatelabel.Visible = true;
            }

            if (quizlistbutton.selected)
            {
                quizactivatebox.Visible = true;
                quizactivatelabel.Visible = true;
            }
      
            if (contactbutton.selected)
            {
                contactactivatebox.Visible = true;
                contactactivatelabel.Visible = true;
            }
        }
		///////////////////////////////////////////////////////////////////////////////
		private void pictureBox1_Click(object sender, EventArgs e)
        {
			///EMPTY
        }
		///////////////////////////////////////////////////////////////////////////////
		private void label3_Click(object sender, EventArgs e)
        {
			///EMPTY
		}
		///////////////////////////////////////////////////////////////////////////////
		private void contactactivatelabel_Click(object sender, EventArgs e)
        {
			///EMPTY
		}
		//HOME BUTTON
		private void homebutton_Click_1(object sender, EventArgs e)
        {
            quiz1panel.Visible = false;
			quiz2panel.Visible = false;
			quiz3panel.Visible = false;
			quizmenupanel.Visible = false;
			welcome.Visible = false;
            h1.Visible = true;
            h2.Visible = true;
            h3.Visible = true;
            h4.Visible = true;
            h5.Visible = true;
            h6.Visible = true;
            h7.Visible = true;
            h8.Visible = true;
            h9.Visible = true;
            h10.Visible = true;
            h11.Visible = true;
            h12.Visible = true;
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
            c7.Visible = false;
            c8.Visible = false;
            homeactivatelabel.Visible = true;
            quizactivatelabel.Visible = false;
            homeactivatebox.Visible = true;
            homeactivatelabel.Visible = true;
            quizactivatebox.Visible = false;
            quizactivatelabel.Visible = false;
            scoreboardactivatebox.Visible = false;
            scoreboardactivatelabel.Visible = false;
            languageactivatebox.Visible = false;
            languageactivatelabel.Visible = false;
            contactactivatebox.Visible = false;
            contactactivatelabel.Visible = false;
			
		}
      	//QUİZ LİST BUTTON
        private void quizlistbutton_Click_1(object sender, EventArgs e)
        {
            counter = 0;
            score = 0;
            time = 20;
            timer2.Enabled = true;
            btnstart.Text = "START";

            quizmenupanel.Visible = true;         
           
			welcome.Visible = false;
            h1.Visible = false;
            h2.Visible = false;
            h3.Visible = false;
            h4.Visible = false;
            h5.Visible = false;
            h6.Visible = false;
            h7.Visible = false;
            h8.Visible = false;
            h9.Visible = false;
            h10.Visible = false;
            h11.Visible = false;
            h12.Visible = false;
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
            c5.Visible = false;
            c6.Visible = false;
            c7.Visible = false;
            c8.Visible = false;
            homeactivatebox.Visible = false;
            homeactivatelabel.Visible = false;
            quizactivatebox.Visible = true;
            quizactivatelabel.Visible = true;
            scoreboardactivatebox.Visible = false;
            scoreboardactivatelabel.Visible = false;
            languageactivatebox.Visible = false;
            languageactivatelabel.Visible = false;
            contactactivatebox.Visible = false;
            contactactivatelabel.Visible = false;
            quiz1panel.BringToFront();
        }
		///////////////////////////////////////////////////////////////////////////////
		//CONTACT BUTTON
		private void contactbutton_Click_1(object sender, EventArgs e)
        {
			
			welcome.Visible = false;
			quiz1panel.Visible = false;
			quiz2panel.Visible = false;
			quiz3panel.Visible = false;
			quizmenupanel.Visible = false;
			h1.Visible = false;
            h2.Visible = false;
            h3.Visible = false;
            h4.Visible = false;
            h5.Visible = false;
            h6.Visible = false;
            h7.Visible = false;
            h8.Visible = false;
            h9.Visible = false;
            h10.Visible = false;
            h11.Visible = false;
            h12.Visible = false;
            c1.Visible = true;
            c2.Visible = true;
            c3.Visible = true;
            c4.Visible = true;
            c5.Visible = true;
            c6.Visible = true;
            c7.Visible = true;
            c8.Visible = true;
            homeactivatebox.Visible = false;
            homeactivatelabel.Visible = false;
            quizactivatebox.Visible = false;
            quizactivatelabel.Visible = false;
            scoreboardactivatebox.Visible = false;
            scoreboardactivatelabel.Visible = false;
            languageactivatebox.Visible = false;
            languageactivatelabel.Visible = false;
            contactactivatebox.Visible = true;
            contactactivatelabel.Visible = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {
			///EMPTY
		}

		/// MAİL SENDER
		///////////////////////////////////////////////////////////////////////////////
		private void c5_Click(object sender, EventArgs e)
        {
            string name = c8.Text;
            string email = c7.Text;
            string message = c6.Text;

            MessageBox.Show("Thank You For Your Sumbit    " + "--" + name + "--");


			MailMessage msg = new MailMessage("thevalorn@gmail.com", c10.Text,c6.Text,c8.Text);
			msg.IsBodyHtml = true;
			SmtpClient sc = new SmtpClient("smtp.gmail.com",587);
			sc.UseDefaultCredentials = false;
			NetworkCredential cre = new NetworkCredential("thevalorn@gmail.com","programmer124");
			sc.Credentials = cre;
			sc.EnableSsl = true;
			sc.Send(msg);
        }
		///////////////////////////////////////////////////////////////////////////////
		private void h2_Click(object sender, EventArgs e)
        {
			///EMPTY
		}
		///////////////////////////////////////////////////////////////////////////////
		private void h8_Click(object sender, EventArgs e)
		{
			
		}
		///////////////////////////////////////////////////////////////////////////////
		private void h11_SelectedIndexChanged(object sender, EventArgs e)
		{
			//
		}
		///////////////////////////////////////////////////////////////////////////////
		/////QUİZ MENU PANEL
		private void btnquiz1_Click_3(object sender, EventArgs e)
		{
			quiz1panel.Visible = true;
			quiz2panel.Visible = false;
			quiz3panel.Visible = false;
			quizmenupanel.Visible = false;
		}
		///////////////////////////////////////////////////////////////////////////////
		private void btnquiz2_Click_3(object sender, EventArgs e)
		{
			quiz1panel.Visible = false;
			quiz2panel.Visible = true;
			quiz3panel.Visible = false;
			quizmenupanel.Visible = false;
		}
		///////////////////////////////////////////////////////////////////////////////
		private void btnquiz3_Click_3(object sender, EventArgs e)
		{
			quiz1panel.Visible = false;
			quiz2panel.Visible = false;
			quiz3panel.Visible = true;
			quizmenupanel.Visible = false;
		}
		//FIRST QUIZ GAME
		int counter = 0;
		int score = 0;
		int time = 20;
		///////////////////////////////////////////////////////////////////////////////
		private void btnstart_Click(object sender, EventArgs e)
		{
			timer2.Enabled = true;
			time = 21;
            textBox1.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(0,72,121);
			button2.BackColor = Color.FromArgb(0, 72, 121);
            button3.BackColor = Color.FromArgb(0, 72, 121);
            button4.BackColor = Color.FromArgb(0, 72, 121);
            btnstart.Enabled = false;
			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = true;
			btnstart.Text = "NEXT";
			counter++;
			lblquest.Text = counter.ToString();
			if (counter == 1)
			{
				a.Open();
				SqlCommand b = new SqlCommand("Select * from quest1 order by NEWID()", a);
				SqlDataReader read = b.ExecuteReader();
				while (read.Read())
				{
					button1.Text = (read["a"].ToString());
					button2.Text = (read["b"].ToString());
					button3.Text = (read["c"].ToString());
					button4.Text = (read["d"].ToString());
					textBox1.Text = (read["Question"].ToString());
					lblanswer.Text = (read["True"].ToString());
				}
				a.Close();
			}

			if (counter == 2)
			{
				a.Open();
				SqlCommand b = new SqlCommand("Select * from quest2 order by NEWID()", a);
				SqlDataReader read = b.ExecuteReader();
				while (read.Read())
				{
					button1.Text = (read["a"].ToString());
					button2.Text = (read["b"].ToString());
					button3.Text = (read["c"].ToString());
					button4.Text = (read["d"].ToString());
					textBox1.Text = (read["Question"].ToString());
					lblanswer.Text = (read["True"].ToString());
				}
				a.Close();
			}

			if (counter == 3)
			{
				a.Open();
				SqlCommand b = new SqlCommand("Select * from quest3 order by NEWID()", a);
				SqlDataReader read = b.ExecuteReader();
				while (read.Read())
				{
					button1.Text = (read["a"].ToString());
					button2.Text = (read["b"].ToString());
					button3.Text = (read["c"].ToString());
					button4.Text = (read["d"].ToString());
					textBox1.Text = (read["Question"].ToString());
					lblanswer.Text = (read["True"].ToString());
				}
				a.Close();
			}

			if (counter == 4)
			{
				a.Open();
				SqlCommand b = new SqlCommand("Select * from quest4 order by NEWID()", a);
				SqlDataReader read = b.ExecuteReader();
				while (read.Read())
				{
					button1.Text = (read["a"].ToString());
					button2.Text = (read["b"].ToString());
					button3.Text = (read["c"].ToString());
					button4.Text = (read["d"].ToString());
					textBox1.Text = (read["Question"].ToString());
					lblanswer.Text = (read["True"].ToString());
				}
				a.Close();
			}

			if (counter == 5)

			{
				a.Open();
				SqlCommand b = new SqlCommand("Select * from quest5 order by NEWID()", a);
				SqlDataReader read = b.ExecuteReader();

				while (read.Read())
				{
					button1.Text = (read["a"].ToString());
					button2.Text = (read["b"].ToString());
					button3.Text = (read["c"].ToString());
					button4.Text = (read["d"].ToString());
					textBox1.Text = (read["Question"].ToString());
					lblanswer.Text = (read["True"].ToString());
				}
				a.Close();
			}

			if (counter == 6)
			{
				lblquest.Text = "FİNİSH";
				btnstart.Enabled = false;
				btnstart.Text = "GAME OVER";
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
				button4.Enabled = false;
				textBox1.Clear();
				textBox1.Enabled = false;				
                textBox1.ForeColor = Color.White;
                MessageBox.Show("YOUR SCORE İS:" + score);

                btnstart.Text = "TRY AGAIN";

                if (btnstart.Text == "TRY AGAIN")
                {
                    counter = 0;
                    score = 0;
                    time = 21;
                    textBox1.Enabled = true;
                    btnstart.Text = "TRY AGAIN";
                    btnstart.Enabled = true;
                    lblscore.Text = "00";
                    lbltime.Text = "00";
                    textBox1.ForeColor = Color.White;
                }

			}
		}
		///////////////////////////////////////////////////////////////////////////////
		private void timer2_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            lbltime.Text = time.ToString();

            if (time == 0)
            {      
                    timer2.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnstart.Enabled = true;                           
            }
        }
		///////////////////////////////////////////////////////////////////////////////
		private void button1_Click_1(object sender, EventArgs e)
		{
			if (button1.Text == lblanswer.Text)
			{
				score = score + 10;
				lblscore.Text = score.ToString();
				button1.BackColor = Color.Green;
			}
			else
			{
				button1.BackColor = Color.Red;
			}
			btnstart.Enabled = true;
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
		}
		///////////////////////////////////////////////////////////////////////////////
		private void button2_Click_1(object sender, EventArgs e)
		{
			if (button2.Text == lblanswer.Text)
			{
				score = score + 10;
				lblscore.Text = score.ToString();
				button2.BackColor = Color.Green;
			}
			else
			{
				button2.BackColor = Color.Red;
			}

			btnstart.Enabled = true;
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
		}
		///////////////////////////////////////////////////////////////////////////////
		private void button3_Click_1(object sender, EventArgs e)
		{
			if (button3.Text == lblanswer.Text)
			{
				score = score + 10;
				lblscore.Text = score.ToString();
				button3.BackColor = Color.Green;
			}
			else
			{
				button3.BackColor = Color.Red;
			}
			btnstart.Enabled = true;
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
		}
		///////////////////////////////////////////////////////////////////////////////
		private void button4_Click_1(object sender, EventArgs e)
		{
			if (button4.Text == lblanswer.Text)
			{
				score = score + 10;
				lblscore.Text = score.ToString();
				button4.BackColor = Color.Green;
			}
			else
			{
				button4.BackColor = Color.Red;
			}
			btnstart.Enabled = true;
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
		}
		//SECOND QUIZ GAME 
		int counter1 = 0;
		int score1 = 0;
		int time1 = 21;
		///////////////////////////////////////////////////////////////////////////////
		private void btncalculate_Click_1(object sender, EventArgs e)
		{
			btncalculate.Enabled = false;

			if (lblanswer1.Text == entervalue.Text)
			{
				score1 = score1 + 10;
				lblscore1.Text = score1.ToString();
			}
			entervalue.Clear();
			btnstart1.Enabled = true;
			timer3.Enabled = false;
		}
		///////////////////////////////////////////////////////////////////////////////
		private void timer3_Tick(object sender, EventArgs e)
		{
			time1 = time1 - 1;
			lbltime1.Text = time1.ToString();

			if (time1 == 0)
			{
				timer3.Enabled = false;
				btncalculate.Enabled = false;
				btnstart1.Enabled = true;
			}
			btncalculate.Enabled = true;
		}
		///////////////////////////////////////////////////////////////////////////////
		private void btnstart1_Click_1(object sender, EventArgs e)
		{

			time1 = 21;
			timer3.Enabled = true;
			btnstart1.Text = "NEXT";
			counter1++;
			lblcounter1.Text = counter1.ToString();
			btnstart1.Enabled = false;
			a.Open();
			SqlCommand c = new SqlCommand("Select * from quiz2value1 order by NEWID()", a);
			SqlDataReader readc = c.ExecuteReader();
			while (readc.Read())
			{
				lblvalue1.Text = (readc["value"].ToString());


			}
			a.Close();

			a.Open();
			SqlCommand d = new SqlCommand("Select * from quiz2arop order by NEWID()", a);
			SqlDataReader readd = d.ExecuteReader();
			while (readd.Read())
			{
				lblarop.Text = (readd["arop"].ToString());


			}
			a.Close();

			a.Open();
			SqlCommand g = new SqlCommand("Select * from quiz2value2 order by NEWID()", a);
			SqlDataReader readg = g.ExecuteReader();
			while (readg.Read())
			{
				lblvalue2.Text = (readg["value2"].ToString());


			}
			a.Close();

			float v1, v2, arop, sum;
			v1 = Convert.ToInt32(lblvalue1.Text);
			v2 = Convert.ToInt32(lblvalue2.Text);
			arop = Convert.ToInt32(lblarop.Text);
			if (arop == 1)
			{
				lblarop.Text = "+";
				sum = v1 + v2;
				lblanswer1.Text = sum.ToString();

			}
			if (arop == 2)
			{
				lblarop.Text = "-";
				sum = v1 - v2;
				lblanswer1.Text = sum.ToString();

			}
			if (arop == 3)
			{
				lblarop.Text = "*";
				sum = v1 * v2;
				lblanswer1.Text = sum.ToString();

			}
			if (arop == 4)
			{
				if (v2 == 0)

				{
					v2 = 1;
					lblvalue2.Text = v2.ToString();

				}
				lblarop.Text = "/";
				sum = v1 / v2;
				lblanswer1.Text = sum.ToString();
			}
			if (lblcounter1.Text == "6")
			{
				btnstart1.Enabled = false;
				btncalculate.Enabled = false;
				btnstart1.Text = "GAME OVER";
				lblcounter1.Text = "GAME OVER";
				timer3.Enabled = false;
				MessageBox.Show("YOUR SCORE İS:" + score1);

               

                if (btnstart1.Text == "GAME OVER")
                {
                    counter1 = 0;
                    score1 = 0;
                    time1 = 21;

                    btnstart1.Text = "TRY AGAIN";
                    btnstart1.Enabled = true;
                    lblscore1.Text = "00";
                    lbltime1.Text = "00";
                    lblcounter1.Text = "00";
                    
                }
            }
		}
		//THIRD QUIZ GAME
		int foundletters = 0;
		int remaining = 4;
		String capitolName = "";
		///////////////////////////////////////////////////////////////////////////////
		private void btnenterletter_Click_1(object sender, EventArgs e)
		{

			bool isThereletter = false;
			if (txtboxenterletter3.Text.Length != 1)
			{
				MessageBox.Show("Please enter only one letter!");
			}
			else
			{
				if (lblenteredletters.Text.Contains(txtboxenterletter3.Text))
				{
					MessageBox.Show("You already entered that letter!");
					txtboxenterletter3.Text = "";
					txtboxenterletter3.Focus();

					return;
				}
				foreach (Control item in grpboxquestion.Controls)
				{
					if (item is Label)
					{
						Label label = item as Label;
						if (label.Text.ToUpper() == txtboxenterletter3.Text.ToUpper())
						{
							label.ForeColor = Color.Black;
							label.BackColor = Color.Lime;
							isThereletter = true;
							foundletters++;
						}
					}
				}
			}
			if (!isThereletter)
			{
				remaining--;
				lblremaining.Text = remaining.ToString();
				if (remaining == 0)
				{
					btnenterletter.Enabled = false;
					btnguess3.Enabled = false;
					MessageBox.Show("Game is over,you lose! Answer is :" + capitolName);

				}
			}
			lblenteredletters.Text += txtboxenterletter3.Text + " ";
			if (foundletters == capitolName.Length)
			{
				btnenterletter.Enabled = false;
				btnguess3.Enabled = false;
				MessageBox.Show("Game is over,congratulations you won!");
			}
			txtboxenterletter3.Text = "";
			txtboxenterletter3.Focus();
		}
		///////////////////////////////////////////////////////////////////////////////
		private void btnstart3_Click(object sender, EventArgs e)
		{
            btnstart3.Text = "NEXT QUESTION";
            lblremaining.Text = "4";
            remaining = 4;
            txtboxenterletter3.Controls.Clear();
            txtboxguess3.Controls.Clear();

            a.Open();
			SqlCommand l = new SqlCommand("Select * from quiz3 order by NEWID()", a);
			SqlDataReader readl = l.ExecuteReader();
			while (readl.Read())
			{
				foundletters = 0;
				btnenterletter.Enabled = true;
				btnguess3.Enabled = true;
				lblenteredletters.Text = "";
				remaining = 4;
				grpboxquestion.Controls.Clear();

				capitolName = (readl["Capitals"].ToString());

				for (int i = 0; i < capitolName.Length; i++)
				{

					Label label = new Label();
					label.Location = new Point(35 * i + 30, 30);
					label.Text = capitolName[i].ToString();
					label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
					label.Size = new System.Drawing.Size(30, 35);
					label.BackColor = Color.Red;
					label.ForeColor = Color.Red;
					grpboxquestion.Controls.Add(label);

				}
			}
			a.Close();
		}
		///////////////////////////////////////////////////////////////////////////////
		private void btnguess3_Click(object sender, EventArgs e)
		{           
            if (capitolName.ToUpper() == txtboxguess3.Text.ToUpper())
			{
				foreach (Control item in grpboxquestion.Controls)
				{
					if (item is Label)
					{
						Label label = item as Label;
						label.ForeColor = Color.Black;
						label.BackColor = Color.Lime;
					}

				}
				MessageBox.Show("Game is over,congratulations you won!");
			}
			else
			{
				MessageBox.Show("Game is over,you lose Answer is:" + capitolName);
			}
			btnenterletter.Enabled = false;
			btnguess3.Enabled = false;
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			quiz1panel.Visible = false;
			quiz2panel.Visible = true;
			quiz3panel.Visible = false;
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
			quiz1panel.Visible = false;
			quiz2panel.Visible = false;
			quiz3panel.Visible = true;
		}

		private void pictureBox6_Click_1(object sender, EventArgs e)
		{
			quiz1panel.Visible = false;
			quiz2panel.Visible = false;
			quiz3panel.Visible = true;
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			quiz1panel.Visible = true;
			quiz2panel.Visible = false;
			quiz3panel.Visible = false;
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			quiz1panel.Visible = true;
			quiz2panel.Visible = false;
			quiz3panel.Visible = false;
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			quiz1panel.Visible = false;
			quiz2panel.Visible = true;
			quiz3panel.Visible = false;
		}

		private void quiz3panel_Paint(object sender, PaintEventArgs e)
		{
			//
		}
	}
}