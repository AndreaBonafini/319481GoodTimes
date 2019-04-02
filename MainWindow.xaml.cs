using System;
using System.Collections.Generic;
using System.Linq;
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

namespace U2AndreaGoodTimes
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

        private void btnTime_Click(object sender, RoutedEventArgs e)
        {
            string TextEntered = txtTime.Text;
            int Time = 0;
            int.TryParse(TextEntered, out Time);

            int Vic = Time - 300;
            int Ed = Time - 200;
            int Win = Time - 100;
            int Tor = Time;
            int Hal = Time + 100;
            int STJ = Time + 130;

            if (Vic <= 0)
            {
                Vic += 2400;
            }
            if (Ed <= 0)
            {
                Ed += 2400;
            }
            if (Win <= 0)
            {
                Win += 2400;
            }
            if (Tor <= 0)
            {
                Tor += 2400;
            }
            if (Hal >= 2400)
            {
                Hal -= 2400;
            }
            if (STJ >= 2400)
            {
                STJ -= 2400;
            }

            lblOutput.Content += Time + " in Ottawa" + "\r" + "\n";
            lblOutput.Content += Vic + " in Victoria" + "\r" + "\n";
            lblOutput.Content += Ed + " in Edmonton" + "\r" + "\n";
            lblOutput.Content += Win + " in Winnipeg" + "\r" + "\n";
            lblOutput.Content += Tor + " in Toronto" + "\r" + "\n";
            lblOutput.Content += Hal + " in Halifax" + "\r" + "\n";
            lblOutput.Content += STJ + " in St. John’s" + "\r" + "\n";

        }
    }
}

