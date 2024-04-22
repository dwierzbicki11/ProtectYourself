using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WpfApp2.script.simulated.protect.boost;

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy shop.xaml
    /// </summary>
    public partial class shop : Window
    {
        static List<List<string>> listaRzeczy = new List<List<string>>();
        GameReal real = new GameReal();
        public shop()
        {
            InitializeComponent();
            Price();

            foreach (var item in listaRzeczy)
            {
                string nazwa = item[0];
                string cena = item[1];
                lista.Items.Add(nazwa + cena);
            }
        }
        public static void Price()
        {
            listaRzeczy.Add(new List<string>() { "Slow Down Wirus", "15" });
            listaRzeczy.Add(new List<string>() { "Slow Down Trojan", "28" });
            listaRzeczy.Add(new List<string>() { "Slow Down Ransomware", "40" });
            listaRzeczy.Add(new List<string>() { "Slow Down Errors", "100" });
            listaRzeczy.Add(new List<string>() { "FireWall", "150" });
            listaRzeczy.Add(new List<string>() { "Speed Updates", "300" });


            
        }

        private void lista_Selected(object sender, RoutedEventArgs e)
        {
            string selectedItem = lista.SelectedItem.ToString();
            string[] item = selectedItem.Split(' ');
            int itemPrice;
            if (item.Length >= 1 && int.TryParse(item[1], out itemPrice))
            {
                if (real.gold < Convert.ToInt32(item[1]))
                {
                    switch (item[0])
                    {
                        case "Slow Down Wirus":
                            real.timeVirus = Protected.slowDownVirusTime();
                            real.gold -= Convert.ToInt32(item[1]);
                            break;
                        case "Slow Down Trojan":
                            real.timeTrojan = Protected.slowDownTrojanTime();
                            real.gold -= Convert.ToInt32(item[1]);
                            break;
                        case "Slow Down Ransomware":
                            real.timeRansomware = Protected.slowDownRansomwareTime();
                            real.gold -= Convert.ToInt32(item[1]);
                            break;
                        case "Slow Down Errors":
                            real.timeErrors = Protected.slowDownErrorsTime();
                            real.gold -= Convert.ToInt32(item[1]);
                            break;
                        case "FireWall":
                            if (Protected.FireWall())
                            {
                                real.iloscVirus -= (int)(real.iloscVirus * 0.8);
                                real.gold -= Convert.ToInt32(item[1]);
                            }
                            break;
                        case "Speed Updates":
                            Protected.boostUpdateTime();
                            real.gold -= Convert.ToInt32(item[1]);
                            break;
                    }
                }
            }
        }
    }  
}
