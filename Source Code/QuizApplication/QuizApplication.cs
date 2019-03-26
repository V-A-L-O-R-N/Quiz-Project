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
    public partial class QuizApplication : Form
    {
        public QuizApplication()
        {
            InitializeComponent();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ///////////
        }

        private void QuizApplication_Load(object sender, EventArgs e)
        {
            /////////////
        }

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

            if(homebutton.selected)
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

        private void logobox_Click(object sender, EventArgs e)
        {

        }

        

        private void homebutton_Click(object sender, EventArgs e)
        {
           
          
        }

        private void quizlistbutton_Click(object sender, EventArgs e)
        {
           

            
        }

        private void scoreboardbutton_Click(object sender, EventArgs e)
        {
            

          
        }

        private void languagebutton_Click(object sender, EventArgs e)
        {
           
          
        }

        private void contactbutton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {
            //////////////
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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

        private void homepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logobox_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void logobox_MouseLeave(object sender, EventArgs e)
        {
       
        }

        private void homebutton_Click_1(object sender, EventArgs e)
        {
            welcome.Visible = false;
            homepanel.Visible = true;
            homeactivatelabel.Visible = true;
            quizlistpanel.Visible = false;
            quizactivatelabel.Visible = false;
            scoreboardpanel.Visible = false;
            languagepanel.Visible = false;
            contactpanel.Visible = false;


            
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
            welcome.Visible = false;
            homepanel.Visible = false;
            quizlistpanel.Visible = true;
            scoreboardpanel.Visible = false;
            languagepanel.Visible = false;
            contactpanel.Visible = false;
            

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
             
            
        }

        private void scoreboardbutton_Click_1(object sender, EventArgs e)
        {
            welcome.Visible = false;
            homepanel.Visible = false;
            quizlistpanel.Visible = false;
            scoreboardpanel.Visible = true;
            languagepanel.Visible = false;
            contactpanel.Visible = false;
            

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
            homepanel.Visible = false;
            quizlistpanel.Visible = false;
            scoreboardpanel.Visible = false;
            languagepanel.Visible = true;
            contactpanel.Visible = false;
            
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
            homepanel.Visible = false;
            quizlistpanel.Visible = false;
            scoreboardpanel.Visible = false;
            languagepanel.Visible = false;
            contactpanel.Visible = true;
           
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
    }
}
