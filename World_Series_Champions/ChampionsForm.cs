/**
* 16 Apr 2023
* CSC 153
* Daniel Parks
* World Series Winners
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
using System.IO;
using WorldSeriesClassLibrary;

namespace World_Series_Champions
{
    public partial class frmChampions : Form
    {
        public frmChampions()
        {
            InitializeComponent();
            LoadTeams();
        }
        public void LoadTeams()
        {
            try
            {
                string[] lines = File.ReadAllLines(@"..\..\txtFiles\Teams.txt");
                lbxTeams.Items.AddRange(lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void lbxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected team name from the ListBox
            var selectedTeam = lbxTeams.SelectedItem.ToString();

            // Read the WorldSeriesWinners.txt file and count the number of occurrences of the selected team name
            var winners = File.ReadAllLines(@"..\..\txtFiles\WorldSeriesWinners.txt");
            int count = winners.Count(line => line.Contains(selectedTeam));

            // Display the count in a messageBox
            MessageBox.Show(selectedTeam + " has won the World Series " + count + " times.");


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChampions_Load(object sender, EventArgs e)
        {

        }

        private void lbxTeams_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
