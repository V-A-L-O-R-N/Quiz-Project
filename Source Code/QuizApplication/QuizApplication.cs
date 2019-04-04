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
        }
        /// <summary>
        /// top movable mousehover

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /// </summary>


        private void QuizApplication_Load(object sender, EventArgs e)
        {
            lblquest.Text = counter.ToString();
            lblanswer.Visible = false;
            quizlistpanel.Visible = false;

        }

        SqlConnection a = new SqlConnection("Data Source=HUZEYFE\\SQLEXPRESS;Initial Catalog=QuizApp;Integrated Security=True");
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            ///timer opacity exitt
            if (this.Opacity > 0)
            { this.Opacity -= 0.050; }

            else
            {
                timer1.Stop();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void exitbox_Click(object sender, EventArgs e)
        {
            //exit timer start
            timer1.Start();
        }

        private void maximizebox_Click(object sender, EventArgs e)
        {
            //maximizebox
            maximizebox.Visible = false;
            minimizebox.Visible = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimizebox_Click(object sender, EventArgs e)
        {
            //minimizebox
            this.WindowState = FormWindowState.Normal;
            maximizebox.Visible = true;
            minimizebox.Visible = false;
        }

        private void dropminbox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //dropminbox
        }

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            //moveble form
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

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

            if (scoreboardbutton.selected)
            {
                scoreboardactivatebox.Visible = true;
                scoreboardactivatelabel.Visible = true;
            }

            if (languagebutton.selected)
            {
                languageactivatebox.Visible = true;
                languageactivatelabel.Visible = true;
            }

            if (contactbutton.selected)
            {
                contactactivatebox.Visible = true;
                contactactivatelabel.Visible = true;
            }


        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void contactactivatelabel_Click(object sender, EventArgs e)
        {

        }




        private void homebutton_Click_1(object sender, EventArgs e)
        {

            quizlistpanel.Visible = false;

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

        private void quizlistbutton_Click_1(object sender, EventArgs e)
        {

            quizlistpanel.Visible = true;

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

            quizlistpanel.BringToFront();
        }

        private void scoreboardbutton_Click_1(object sender, EventArgs e)
        {


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
            welcome.Visible = false;



            homeactivatebox.Visible = false;
            homeactivatelabel.Visible = false;
            quizactivatebox.Visible = false;
            quizactivatelabel.Visible = false;
            scoreboardactivatebox.Visible = true;
            scoreboardactivatelabel.Visible = true;
            languageactivatebox.Visible = false;
            languageactivatelabel.Visible = false;
            contactactivatebox.Visible = false;
            contactactivatelabel.Visible = false;

        }

        private void languagebutton_Click_1(object sender, EventArgs e)
        {
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
            quizactivatebox.Visible = false;
            quizactivatelabel.Visible = false;
            scoreboardactivatebox.Visible = false;
            scoreboardactivatelabel.Visible = false;
            languageactivatebox.Visible = true;
            languageactivatelabel.Visible = true;
            contactactivatebox.Visible = false;
            contactactivatelabel.Visible = false;

        }

        private void contactbutton_Click_1(object sender, EventArgs e)
        {
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

        private void a_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void c5_Click(object sender, EventArgs e)
        {
            string name = c8.Text;
            string email = c7.Text;
            string message = c6.Text;

            MessageBox.Show("Thank You For Your Sumbit    " + "--" + name + "--");
        }

        private void h2_Click(object sender, EventArgs e)
        {

        }

        private void quizlistpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        int counter = 0;
        int score = 0;
        int time = 20;

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            time = 20;

            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;

            button5.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            button5.Text = "NEXT";

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
                button5.Enabled = false;
                button5.Text = "GAME OVER";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                textBox1.Clear();
                textBox1.Enabled = false;
                timer2.Enabled = false;

                MessageBox.Show("YOUR SCORE İS:" + score);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
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

            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
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

            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
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

            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        

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
                button5.Enabled = true;

                    

                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }
    }

}