using System;
using System.Timers;
using System.Windows;
using WpfApp2.script.simulated.protect.boost;

namespace WpfApp2
{
    public partial class GameReal : Window
    {
        // Timers
        private Timer timerVirus;
        private Timer timerTrojan;
        private Timer timerRansomware;
        private Timer timerErrors;
        private Timer timerUpdate;

        // Obiekt Random
        private Random rnd = new Random();

        // Liczby całkowite
        private int prog = 10;
        public int iloscVirus { get; set; } = 0;
        public int iloscTrojan { get; set; } = 0;
        public int iloscRansomware { get; set; } = 0;
        public int iloscErrors { get; set; } = 0;

        private int ileRazyUpdate = 0;
        public int gold { get; set; } = 0;
        public int timeVirus, timeTrojan, timeRansomware, timeErrors;
        private int errors;

        // Konstruktor
        public GameReal()
        {
            InitializeComponent();
            timeVirus = Protected.slowDownVirusTime();
            timerVirus = new Timer(timeVirus * 1000);
            timerVirus.Elapsed += TimerVirus_Elapsed;
            timerVirus.AutoReset = true;
            timerVirus.Start();

            timeTrojan = Protected.slowDownTrojanTime();
            timerTrojan = new Timer(timeTrojan * 1000);
            timerTrojan.Elapsed += TimerTrojan_Elapsed;
            timerTrojan.AutoReset = true;
            timerTrojan.Start();

            timeRansomware = Protected.slowDownRansomwareTime();
            timerRansomware = new Timer(timeRansomware * 1000);
            timerRansomware.Elapsed += TimerRansomware_Elapsed;
            timerRansomware.AutoReset = true;
            timerRansomware.Start();

            timeErrors = Protected.slowDownErrorsTime();
            timerErrors = new Timer(timeErrors * 1000);
            timerErrors.Elapsed += TimerErrors_Elapsed;
            timerErrors.AutoReset = true;
            timerErrors.Start();

            timerUpdate = new Timer(Protected.WaitForSecond());
            timerUpdate.Elapsed += TimerUpdate_Elapsed;
            timerUpdate.Start();

            virus.Content = iloscVirus;
            trojan.Content = iloscTrojan;
            ransomware.Content = iloscRansomware;
            error.Content = iloscErrors;
        }

        private void TimerVirus_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                DodajVirusa();
            });
        }

        private void TimerTrojan_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                DodajTrojana();
            });
        }

        private void TimerRansomware_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                DodajRansomware();
            });
        }

        private void TimerErrors_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                DodajBledy();
            });
        }

        private void TimerUpdate_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                Aktualizuj();
            });
        }

        private void Aktualizuj()
        {
            errors = iloscVirus + iloscTrojan + iloscRansomware + iloscErrors;

            if (prog < errors)
            {
                updates.IsEnabled = true; // Ustaw przycisk na aktywny
            }
            else
            {
                updates.IsEnabled = false; // Ustaw przycisk na nieaktywny
            }
        }


        private void DodajVirusa()
        {
            iloscVirus++;
            virus.Content = iloscVirus;
        }

        private void DodajTrojana()
        {
            iloscTrojan++;
            trojan.Content = iloscTrojan;
        }

        private void DodajRansomware()
        {
            iloscRansomware++;
            ransomware.Content = iloscRansomware;
        }


        private void DodajBledy()
        {
            iloscErrors++;
            error.Content = iloscErrors;
        }

        private void updates_Click(object sender, RoutedEventArgs e)
        {
            ileRazyUpdate++;
            prog = rnd.Next(5, 15);
            gold += rnd.Next(1, 5);
            ileZlota.Content = gold;
            iloscErrors -= (int)(iloscErrors * 0.8);
            iloscRansomware -= (int)(iloscRansomware * 0.8);
            iloscTrojan -= (int)(iloscTrojan * 0.8);
            iloscVirus -= (int)(iloscVirus * 0.8);
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
