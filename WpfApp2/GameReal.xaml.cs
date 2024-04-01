using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Threading;
using WpfApp2.script.simulated.protect.boost;

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy GameReal.xaml
    /// </summary>

    public partial class GameReal : Window
    {
        //timers
        DispatcherTimer timerVirus;
        DispatcherTimer timerTrojan;
        DispatcherTimer timerRansomware;
        DispatcherTimer timerErrors;
        DispatcherTimer timer;
        DispatcherTimer timerUpdate;

        //object random
        Random rnd = new Random();

        //Integers
        public int prog = 10;
        public int iloscVirus { get; set; } = 0;
        public int iloscTrojan { get; set; } = 0;
        public int iloscRansomware { get; set; } = 0;
        public int iloscErrors { get; set; } = 0;

        int ileRazyUpdate = 0;
        public int gold =0;
        public int timeVirus, timeTrojan, timeRansomware, timeErrors;
        int errors;
        
        //Constructor
        public GameReal()
        {
            InitializeComponent();
            timeVirus = rnd.Next(1, 3);
            timerVirus = new DispatcherTimer();
            timerVirus.Interval = TimeSpan.FromSeconds(timeVirus);
            timerVirus.Tick += Timer_Tick;
            timerVirus.Start();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer5_Tick;
            timer.Start();

            timeTrojan = rnd.Next(1, 5);
            timerTrojan = new DispatcherTimer();
            timerTrojan.Interval = TimeSpan.FromSeconds(timeTrojan);
            timerTrojan.Tick += Timer2_Tick;
            timerTrojan.Start();

            timeRansomware = rnd.Next(3, 8);
            timerRansomware = new DispatcherTimer();
            timerRansomware.Interval = TimeSpan.FromSeconds(timeRansomware);
            timerRansomware.Tick += Timer3_Tick;
            timerRansomware.Start();


            timeErrors = rnd.Next(5, 15);
            timerErrors = new DispatcherTimer();
            timerErrors.Interval = TimeSpan.FromSeconds(timeErrors);
            timerErrors.Tick += Timer4_Tick;
            timerErrors.Start();

            timerUpdate = new DispatcherTimer();
            timerUpdate.Interval = TimeSpan.FromSeconds(0.1);
            timerUpdate.Tick += TimerUpdate_Tick;
            timerUpdate.Start();

            virus.Content = iloscVirus;
            trojan.Content = iloscTrojan;
            ransomware.Content = iloscRansomware;
            error.Content = iloscErrors;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Call your functions here to add threats
            AddVirus();
        }
        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            Update();
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            // Call your functions here to add threats
            AddTrojan();
        }
        private void Timer3_Tick(object sender, EventArgs e)
        {
            // Call your functions here to add threats
            AddRansomware();
        }
        private void Timer4_Tick(object sender, EventArgs e)
        {
            // Call your functions here to add threats
            AddErrors();
        }
        private void Timer5_Tick(object sender, EventArgs e)
        {
            errors = Convert.ToInt32(virus.Content) + Convert.ToInt32(trojan.Content) + Convert.ToInt32(ransomware.Content) + Convert.ToInt32(error.Content);
            liczbaZagrozen.Content = errors.ToString();
        }
        
        private void Update() {
            if (errors > prog)
            {
                updates.IsEnabled = true;
                prog += rnd.Next(10, 30);
            }
            else updates.IsEnabled = false;
        }
        private void AddVirus()
        {
            iloscVirus++;
            virus.Content = iloscVirus; // Update the virus count
        }

        private void AddTrojan()
        {
            iloscTrojan++;
            trojan.Content = iloscTrojan; // Update the trojan count
        }

        private void AddRansomware()
        {
            iloscRansomware++;
            ransomware.Content = iloscRansomware; // Update the ransomware count
        }

        private void AddErrors()
        {
            iloscErrors++;
            error.Content = iloscErrors; // Update the errors count
        }

        private void updates_Click(object sender, RoutedEventArgs e)
        {
            ileRazyUpdate++;
            gold+=rnd.Next(1,5);
            iloscErrors-= (int)(iloscErrors * 0.8);
            iloscRansomware-= (int)(iloscRansomware * 0.8);
            iloscTrojan-= (int)(iloscTrojan * 0.8);
            iloscVirus-=(int)(iloscVirus*0.8);
            if (iloscVirus < 0) iloscVirus = 0;
            if (iloscTrojan < 0) iloscTrojan = 0;
            if (iloscRansomware < 0) iloscRansomware = 0;
            if (iloscErrors < 0) iloscErrors = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var shop = new shop();
            shop.Show();
        }
    }
}