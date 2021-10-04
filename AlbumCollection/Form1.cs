using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumCollection
{
    public partial class Form1 : Form
    {
        List<string> originalList = new List<string>();
        List<string> sortList = new List<string>();

        string albumInfo;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            albumInfo = albumInput.Text;

            if (albumInfo == "")
            {
                errorLabel.Text = $"Please enter album information";
            }
            else if (originalList.Contains(albumInfo) == true)
            {
                errorLabel.Text = $"{albumInfo} already exists";
            }
            else
            {
                originalList.Add(albumInfo);
                sortList.Add(albumInfo);
                sortList.Sort();
            }

            albumInput.Clear();

            originalListLabel.Text = "Original Order\n****************\n";
            sortedListLabel.Text = "Sorted Order\n****************\n";

            for (int i = 0; i < originalList.Count; i++)
            {
                originalListLabel.Text += "\n" + originalList[i];
                sortedListLabel.Text += "\n" + sortList[i];
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            albumInfo = albumInput.Text;

            if (albumInfo == "")
            {
                errorLabel.Text = $"Please enter album information";
            }
            else if (originalList.Contains(albumInfo) == true)
            {
                originalList.Remove(albumInfo);
                sortList.Remove(albumInfo);
                sortList.Sort();
            }
            else
            {
                errorLabel.Text = $"{albumInfo} does not exist";
            }

            albumInput.Clear();

            originalListLabel.Text = "Original Order\n**********\n";
            sortedListLabel.Text = "Sorted Order\n**********\n";

            for (int i = 0; i < originalList.Count; i++)
            {
                originalListLabel.Text += "\n" + originalList[i];
                sortedListLabel.Text += "\n" + sortList[i];
            }
        }
    }
}
