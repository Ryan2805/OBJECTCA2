/*===================================================
 * Program Purpose: CA2 Object Oriented rogramming
 * Date Created 14/12/2023
 * Author: RYan Daly S00237889
 * Github repo link: https://github.com/Ryan2805/OBJECTCA2
 * 
 * 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OBJECTCA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void GetData()
        {

            //create the teams 
            Team t1 = new Team() { Name = "France" };
            Team t2 = new Team() { Name = "Italy" };
            Team t3 = new Team() { Name = "Spain" };


            //French players
            Player p1 = new Player() { Name = "Marie", ResultRecord = "WWDDL" };
            Player p2 = new Player() { Name = "Claude", ResultRecord = "DDDLW" };
            Player p3 = new Player() { Name = "Antoine", ResultRecord = "LWDLW" };

            //Italian players
            Player p4 = new Player() { Name = "Marco", ResultRecord = "WWDLL" };
            Player p5 = new Player() { Name = "Giovanni", ResultRecord = "LLLLD" };
            Player p6 = new Player() { Name = "Valentina", ResultRecord = "DLWWW" };

            //Spanish players
            Player p7 = new Player() { Name = "Maria", ResultRecord = "WWWWW" };
            Player p8 = new Player() { Name = "Jose", ResultRecord = "LLLLL" };
            Player p9 = new Player() { Name = "Pablo", ResultRecord = "DDDDD" };

            //adding the players to the 3 teams
            t1.Players = new List<Player> { p1, p2, p3 };
            t2.Players = new List<Player> { p4, p5, p6 };
            t3.Players = new List<Player> { p7, p8, p9 };

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // create     
        }

        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
