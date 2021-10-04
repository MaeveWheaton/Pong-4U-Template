using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public static string correctUsername = "Maeve";
        public static string correctPassword = "ICS4U";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginScreen lgs = new LoginScreen();
            this.Controls.Add(lgs);
        }
    }
}
