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

namespace Tehtava1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int leveys, korkeus, kleveys;
            float tulos1, tulos2, tulos3;
            leveys = int.Parse(leveystext.Text);
            korkeus = int.Parse(korkeustext.Text);
            kleveys = int.Parse(kleveystext.Text);
            tulos1 = leveys * korkeus;
            tulos2 = (2 * (leveys + 2*kleveys) + 2 * (korkeus + 2*kleveys));
            tulos3 = ((leveys + 2 * kleveys) * (korkeus + 2 * kleveys) - tulos1);
            tulosArea.Text = tulos1.ToString();
            tulosKpiiri.Text = tulos2.ToString();
            tulosKArea.Text = tulos3.ToString();
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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
