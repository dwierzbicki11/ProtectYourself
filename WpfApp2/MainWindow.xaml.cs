using Protect_yourself.script.protect;
using System.Windows;
using System.Windows.Documents;

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        polecenia polecenia = new polecenia();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Send_OnClick(object sender, RoutedEventArgs e) {
            string dana = cmd.Text.ToLower();
            switch (dana) {
                case "?help":
                    polecenia.help();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?clear":
                    result.Document.Blocks.Clear();
                    break;
                case "?robak":
                    polecenia.Robak();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?haker":
                    polecenia.hacker();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?wirus":
                    polecenia.wirus();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?trojan":
                    polecenia.trojan();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?phishing":
                    polecenia.phising();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?hacking":
                    polecenia.Hacking();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?ransomware":
                    polecenia.Ransomware();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?spyware":
                    polecenia.Spyware();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?malware":
                    polecenia.Malware();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?zlosliwe oprogramowanie bankowe":
                    polecenia.Zlosliwe_oprogramowanie_bankowe();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?zlosliwe oprogramowanie typu cryptojacking":
                    polecenia.Zlosliwe_oprogramowanie_typu_cryptojacking();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?Rootkit":
                    polecenia.Rootkit();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?zlosliwe oprogramowanie bez plikow":
                    polecenia.Zlosliwe_oprogramowanie_bez_plikow();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?adware":
                    polecenia.Adware();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?cyberbezpieczeństwo":
                    polecenia.cyberbezpieczenstwo();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?adres ip":
                    polecenia.AdresIP();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?anonimizacja":
                    polecenia.Anonimizacja();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?atak na dns":
                    polecenia.Atak_na_DNS();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?backdoor":
                    polecenia.Backdoor();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?backup":
                    polecenia.Backup();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?bitcoin":
                    polecenia.Bitcoin();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?blockchain":
                    polecenia.Blockchain();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?botnet":
                    polecenia.Botnet();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?brute force attack":
                    polecenia.Brute_force_attack();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?browser hijacker":
                    polecenia.Browser_hijacker();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?cracking":
                    polecenia.Cracking();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?dlp":
                    polecenia.DLP();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?dos":
                    polecenia.DoS();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?ddos":
                    polecenia.DDoS();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?doxing":
                    polecenia.Doxing();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?exploit":
                    polecenia.Exploit();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?exploit zero day":
                    polecenia.Exploit_zero_day();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?fake mail":
                    polecenia.Fake_mail();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?gray hat":
                    polecenia.Gray_hat();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?black hat":
                    polecenia.Black_hat();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?honeypot":
                    polecenia.Honeypot();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?ip spoofing":
                    polecenia.IP_Spoofing();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?javascript injection":
                    polecenia.JavaScript_injection();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?keylogger":
                    polecenia.Keylogger();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?kryptowaluta":
                    polecenia.Kryptowaluta();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?rdp":
                    polecenia.RDP();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?shadow it":
                    polecenia.Shadow_IT();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?sniffing":
                    polecenia.Sniffing();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?vpn":
                    polecenia.VPN();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?wirtualizacja":
                    polecenia.Wirtualizacja();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?white hat":
                    polecenia.White_hat();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?wyciek danych":
                    polecenia.Wyciek_danych();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;
                case "?zero trust":
                    polecenia.Zero_trust();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    break;


            }
        }
    }
}
