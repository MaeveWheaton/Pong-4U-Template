using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiScreens
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);

            //centre the screen on the form
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            counterLabel.Text = $"You have played {Form1.counter} times";
        }
    }
}
