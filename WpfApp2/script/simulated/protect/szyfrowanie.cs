using System.Threading;

namespace Protect_yourself.script.simulated.protect
{
    internal class szyfrowanie
    {
        public static string msge;
        public static string Encrypt(string msg,int shift)
        {
            string encryptMSG = "";

            foreach (char c in msg) {
                
                if (char.IsLetter(c)) { 

                    char lowerC = char.ToLower(c);
                    char shifted = (char)(((lowerC + shift - 'a') % 26) + 'a');
                    encryptMSG += shifted;
                }
                else { encryptMSG += c; }
            }
            msge = encryptMSG;
            return encryptMSG;
        }
        
    }
}
