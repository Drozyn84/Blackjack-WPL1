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

namespace Blackjack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private Random random1 = new Random();
        private StringBuilder sb;
        private StringBuilder sb1;
        private int willekeurigeKaart;
        private int willekeurigeKaartBank;
        private int volgBank;
        private int volgSpel;
        public MainWindow()
        {

            InitializeComponent();

            btnHit.IsEnabled = false;
            btnStand.IsEnabled = false;

            sb = new StringBuilder();
            sb1 = new StringBuilder();

            
            


        }


        private void btnStand_click(object sender, RoutedEventArgs e)
        {




        }




        private void btnDeel_Click(object sender, RoutedEventArgs e)

        {

            btnHit.IsEnabled = true;
            btnStand.IsEnabled = true;
            btnDeel.IsEnabled = false;



            Random random = new Random();

            willekeurigeKaart = random.Next(1, 7);



            sb.AppendLine($"{willekeurigeKaart}");
            txtSpelSpeler.Text = sb.ToString();
            scoreSpeler.Text = Convert.ToString(willekeurigeKaart);





            willekeurigeKaartBank = random.Next(1, 7);


            sb1.AppendLine($"{willekeurigeKaartBank}");

            txtSpelBank.Text = sb1.ToString();
            ScoreBank.Text = Convert.ToString(willekeurigeKaartBank);

            




        }



        private void btnHit_Click(object sender, RoutedEventArgs e)
        {
            //het tweede cijfer + optelling bij het scorebord van Speler
            Random random = new Random();   
            int willeKaartSpeler = random.Next(1, 7);
            
            sb.AppendLine($"{willekeurigeKaart}");
            txtSpelSpeler.Text = sb.ToString();
            scoreSpeler.Text = Convert.ToString(willekeurigeKaart + willeKaartSpeler );

            //het tweede cijfer + optelling bij het scorebord van Bank
            int willeKaartBank = random1.Next(1, 7);

            sb1.AppendLine($"{willekeurigeKaartBank}");
            txtSpelBank.Text = sb.ToString();  
            ScoreBank.Text = Convert.ToString( + willeKaartBank);
        }
    }
}
