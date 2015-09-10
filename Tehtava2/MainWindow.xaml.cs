using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Tehtava2
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

        private void drawbutton_Click(object sender, RoutedEventArgs e)
        {
            int arvontojenmaara;
            Lotto lotto = new Lotto();
            if (maara.Text == "")
                arvontojenmaara = 1;
            else
                arvontojenmaara = int.Parse(maara.Text);
           
            for (int i = 0; i < arvontojenmaara; i++)
            {
                int[] rivi = lotto.ArvoRivi(comboBox.SelectedIndex);
                string srivi = string.Join(" ", rivi);
                listBox.Items.Add(srivi);
            }
        }

        private void comboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Suomi");
            data.Add("VikingLotto");
            data.Add("EuroJackpot");
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = data;
            comboBox.SelectedIndex = 0;
        }


        private void clearbutton_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
        }

        private void closebutton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void maara_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);//Tutkii onko syötetty input sallittu
        }
        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9]+"); //Sallii vain numero inputit
            return !regex.IsMatch(text);
        }
    }
}
