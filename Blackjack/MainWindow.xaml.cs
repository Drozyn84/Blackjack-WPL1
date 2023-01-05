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
        private Random random2 = new Random();
        private Random random1 = new Random();
        private StringBuilder sb;
        private StringBuilder sb1;
        
       
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

            btnHit.IsEnabled = false ;
            btnDeel.IsEnabled = true;


            

        }


        
       
        private void btnDeel_Click(object sender, RoutedEventArgs e)

        {

            btnHit.IsEnabled = true;
            btnStand.IsEnabled = true;
            btnDeel.IsEnabled = true;

            //SPELER RANDOM

            Random Random2 = new Random();

            int willekeurigeKaart = random2.Next(1, 11);
            if ( willekeurigeKaart < 2 )
            {
                willekeurigeKaart = 11;
            }
            int kaartTwee = random2.Next(1, 11);         
          
            
            int opTelling = kaartTwee + willekeurigeKaart;
            
            
            
            sb.AppendLine($"{willekeurigeKaart}");          
            sb.AppendLine($"{kaartTwee}");
           
            

            txtSpelSpeler.Text = sb.ToString();
            scoreSpeler.Text = Convert.ToString(opTelling);

            if (opTelling == 21 )
            {
                TxtUitSlag.Text = "gewonnen";
            }






            //BANK RANDOM



            int willekeurigeKaartBank = random2.Next(1, 11);
            if (willekeurigeKaartBank < 2 )
            {
                willekeurigeKaartBank = 11;
            }
            int kaartTweeBank = random2.Next(1, 11);
            int opTellingBank = kaartTweeBank + willekeurigeKaartBank;


            sb1.AppendLine($"{willekeurigeKaartBank}");
            sb1.AppendLine($"{kaartTweeBank}");
            

            txtSpelBank.Text = sb1.ToString();
            ScoreBank.Text = Convert.ToString(opTellingBank);




                       
        }
        
       
        private void btnHit_Click(object sender, RoutedEventArgs e)
        {

            //TxtUitSlag.Text = Convert.ToString();
        }
    }
}
