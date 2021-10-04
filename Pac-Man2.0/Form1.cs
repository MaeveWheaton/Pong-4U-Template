﻿/*
 * Maeve Wheaton
 * Mr. T
 * October 4, 2021
 * Pac-Man game, player must collect all the pellets on the screen without being caught by a ghost.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pac_Man2._0
{
    public partial class Form1 : Form
    {
        List<Pellet> pellets = new List<Pellet>();
        List<Character> ghosts = new List<Character>();

        public static SolidBrush pacManBrush = new SolidBrush(Color.Yellow);
        public static SolidBrush pelletsBrush = new SolidBrush(Color.PapayaWhip);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Program goes directly to the GameScreen method on start
            MainScreen gs = new MainScreen();
            this.Controls.Add(gs);
        }
    }
}
