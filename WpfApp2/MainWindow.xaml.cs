using Protect_yourself.script.protect;
using System.Windows;
using System.Windows.Documents;
using System.Speech.Synthesis;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        polecenia polecenia = new polecenia();
        public MainWindow()
        {
            InitializeComponent();
        }
        void PlayGame_OnClick(object sender, RoutedEventArgs e) { 
            var game = new Game();
            game.Show();
        }
        void playRealGame_OnClick(object sender, RoutedEventArgs e) {
            var win = new GameReal();
           win.Show();
        }
        private void Send_OnClick(object sender, RoutedEventArgs e) {
            var engine = new SpeechSynthesizer();
            engine.Volume = 100;
            engine.Rate = -1;
            string dana = cmd.Text.ToLower();
            switch (dana) {
                case "?help":
                    polecenia.help();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    cmd.Clear();
                    break;
                case "?clear":
                    result.Document.Blocks.Clear();
                    cmd.Clear();
                    break;
                case "?robak":
                    polecenia.Robak();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    cmd.Clear();
                    break;
                case "?haker":
                    cmd.Clear();
                    polecenia.hacker();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?wirus":
                    cmd.Clear();
                    polecenia.wirus();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?trojan":
                    cmd.Clear();
                    polecenia.trojan();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?phishing":
                    cmd.Clear();
                    polecenia.phising();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?hacking":
                    cmd.Clear();
                    polecenia.Hacking();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?ransomware":
                    cmd.Clear();
                    polecenia.Ransomware();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?spyware":
                    cmd.Clear();
                    polecenia.Spyware();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?malware":
                    cmd.Clear();
                    polecenia.Malware();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?zlosliwe oprogramowanie bankowe":
                    cmd.Clear();
                    polecenia.Zlosliwe_oprogramowanie_bankowe();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?zlosliwe oprogramowanie typu cryptojacking":
                    polecenia.Zlosliwe_oprogramowanie_typu_cryptojacking();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    cmd.Clear();
                    break;
                case "?Rootkit":
                    cmd.Clear();
                    polecenia.Rootkit();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?zlosliwe oprogramowanie bez plikow":
                    cmd.Clear();
                    polecenia.Zlosliwe_oprogramowanie_bez_plikow();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?adware":
                    cmd.Clear();
                    polecenia.Adware();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?cyberbezpieczeństwo":
                    cmd.Clear();
                    polecenia.cyberbezpieczenstwo();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?adres ip":
                    cmd.Clear();
                    polecenia.AdresIP();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?anonimizacja":
                    cmd.Clear();
                    polecenia.Anonimizacja();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?atak na dns":
                    cmd.Clear();
                    polecenia.Atak_na_DNS();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?backdoor":
                    cmd.Clear();
                    polecenia.Backdoor();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?backup":
                    cmd.Clear();
                    polecenia.Backup();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?bitcoin":
                    cmd.Clear();
                    polecenia.Bitcoin();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?blockchain":
                    cmd.Clear();
                    polecenia.Blockchain();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?botnet":
                    cmd.Clear();
                    polecenia.Botnet();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?brute force attack":
                    cmd.Clear();
                    polecenia.Brute_force_attack();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?browser hijacker":
                    cmd.Clear();
                    polecenia.Browser_hijacker();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?cracking":
                    cmd.Clear();
                    polecenia.Cracking();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?dlp":
                    cmd.Clear();
                    polecenia.DLP();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?dos":
                    cmd.Clear();
                    polecenia.DoS();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?ddos":
                    cmd.Clear();
                    polecenia.DDoS();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?doxing":
                    cmd.Clear();
                    polecenia.Doxing();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?exploit":
                    cmd.Clear();
                    polecenia.Exploit();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?exploit zero day":
                    cmd.Clear();
                    polecenia.Exploit_zero_day();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?fake mail":
                    cmd.Clear();
                    polecenia.Fake_mail();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?gray hat":
                    cmd.Clear();
                    polecenia.Gray_hat();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?black hat":
                    cmd.Clear();
                    polecenia.Black_hat();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?honeypot":
                    cmd.Clear();
                    polecenia.Honeypot();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?ip spoofing":
                    cmd.Clear();
                    polecenia.IP_Spoofing();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?javascript injection":
                    cmd.Clear();
                    polecenia.JavaScript_injection();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?keylogger":
                    cmd.Clear();
                    polecenia.Keylogger();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?kryptowaluta":
                    cmd.Clear();
                    polecenia.Kryptowaluta();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?rdp":
                    cmd.Clear();
                    polecenia.RDP();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?shadow it":
                    cmd.Clear();
                    polecenia.Shadow_IT();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?sniffing":
                    cmd.Clear();
                    polecenia.Sniffing();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?vpn":
                    cmd.Clear();
                    polecenia.VPN();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?wirtualizacja":
                    cmd.Clear();
                    polecenia.Wirtualizacja();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?white hat":
                    cmd.Clear();
                    polecenia.White_hat();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?wyciek danych":
                    cmd.Clear();
                    polecenia.Wyciek_danych();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                case "?zero trust":
                    cmd.Clear();
                    polecenia.Zero_trust();
                    result.Document.Blocks.Add(new Paragraph(new Run(polecenia.command)));
                    engine.Speak(polecenia.command);
                    break;
                default:
                    cmd.Clear();
                    result.Document.Blocks.Add(new Paragraph(new Run("Zła komenda. Sprawdź polecenie wpisując ?help")));
                    break;
            }
        }
    }
}