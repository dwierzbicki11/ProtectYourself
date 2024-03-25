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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public Game()
        {
            InitializeComponent();
        }

        private void szyfuj(object sender, RoutedEventArgs e)
        {
            int klucz = Convert.ToInt32(key.Text);
            string msg= hasloDoHashu.Text;
            output.Content = encrypt(msg,klucz);
        }
        string encrypt(string msg,int key) {
            string encMSG ="";
            for (int i = 0; i < msg.Length; i++) {
                 var znak = msg[i] + key;
                  encMSG += znak;
            }
            return encMSG;
        }
    }
}
