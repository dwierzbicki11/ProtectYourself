using System;
using System.Windows;

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
                  char znak = Convert.ToChar(msg[i] + key);
                  encMSG += znak;
            }
            return encMSG;
        }
    }
}
