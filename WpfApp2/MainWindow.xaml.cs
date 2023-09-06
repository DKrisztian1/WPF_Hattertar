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

namespace WpfApp2
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
        private void Szamol(object sender, RoutedEventArgs e)
        {
            int kapacitas = Convert.ToInt32(txtKapacitas.Text);
            int sebesseg = Convert.ToInt32(slSebesseg.Value);
            int eredmeny = 0;

            if (cmbSebesseg.SelectedIndex == 1)
                sebesseg = sebesseg * 1000;


            if (cmbKapacitas.SelectedIndex == 1)
                kapacitas = kapacitas * 1000;

            else if (cmbKapacitas.SelectedIndex == 2)
                kapacitas = kapacitas * 1000 * 1000;

            else if (cmbKapacitas.SelectedIndex == 3)
                kapacitas = kapacitas * 1000 * 1000 * 1000;

            eredmeny = kapacitas / sebesseg;

            lbEredmeny.Content = EredmenySzamitas(eredmeny);
        }


        
        public string EredmenySzamitas(int kapottMasodperc)
        {
            TimeSpan t = TimeSpan.FromSeconds(kapottMasodperc);
            string bontottEredmeny = string.Format("{0:D2}:{1:D2}:{2:D2}",
                            t.Hours,
                            t.Minutes,
                            t.Seconds);
            return bontottEredmeny;
        }
        
        /*
        public string EredmenySzamitas(int kapottMasodperc)
        {
            int masodperc = kapottMasodperc % 60;
            int perc = kapottMasodperc / 60 % 60;
            int ora = perc / 60;

            string bontottEredmeny = $"{ora} óra, {perc} perc, {masodperc} mp";
            return bontottEredmeny;
        }
        */
    }
}
