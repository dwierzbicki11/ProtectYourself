using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protect_yourself.script.simulated.protect
{
    public class CheckPasswd
    {
        public class zaawansowane2
        {
            public string[] previousPasswords = { "admin", "12346789", "daniel11", "Poska28" };
            public bool len,upperChar,lowChar,number,specialChar,unikalnoscZnakow,zlozonoscHasla;
            public int CalculatePasswordStrength(string password)
            {
                int score = 0;

                // Sprawdzenie długości hasła
                if (password.Length >= 8)
                {
                    score++;
                    len = true;
                }

                // Sprawdzenie obecności małych liter
                if (password.Any(char.IsLower))
                {
                    score++;
                    lowChar = true;
                }

                // Sprawdzenie obecności wielkich liter
                if (password.Any(char.IsUpper))
                {
                    score++;
                    upperChar = true;
                }

                // Sprawdzenie obecności cyfr
                if (password.Any(char.IsDigit))
                {
                    score++;
                    number = true;
                }

                // Sprawdzenie obecności znaków specjalnych
                if (password.Any(IsSpecialCharacter))
                {
                    score++;
                    specialChar = true;
                }

                // Sprawdzenie unikalności znaków
                if (password.Distinct().Count() == password.Length)
                {
                    score++;
                    unikalnoscZnakow = true;
                }

                // Sprawdzenie złożoności hasła
                if (IsPasswordComplex(password))
                {
                    score++;
                    zlozonoscHasla = true;
                }

                // Sprawdzenie obecności słowa ze słownika
                if (!IsPasswordDictionaryWord(password))
                {
                    score++;
                }

                // Sprawdzenie unikalności hasła w porównaniu do poprzednich haseł
                if (!IsPasswordPreviouslyUsed(password))
                {
                    score++;
                }

                return score;
            }

            bool IsSpecialCharacter(char c)
            {
                return !char.IsLetterOrDigit(c);
            }

            bool IsPasswordComplex(string password)
            {
                // Sprawdzenie złożoności na podstawie niestandardowych kryteriów
                // Możesz dodać własne kryteria złożoności tutaj
                return password.Length >= 10 && password.Any(char.IsLetter) && password.Any(char.IsDigit) && password.Any(IsSpecialCharacter);
            }

            bool IsPasswordDictionaryWord(string password)
            {
                // Sprawdzenie, czy hasło zawiera słowo ze słownika
                // Możesz dostosować tę logikę, aby używać własnego słownika lub usług zewnętrznych
                string[] dictionary = { "password", "123456", "qwerty" };
                return !dictionary.Contains(password.ToLower());
            }

            bool IsPasswordPreviouslyUsed(string password)
            {
                // Sprawdzenie, czy hasło zostało wcześniej użyte
                // Możesz dostosować tę logikę, aby sprawdzać w bazie danych lub innych źródłach
                return !previousPasswords.Contains(password);
            }
        }
        public class proste
        {
            public int CalculatePasswordStrength(string password)
            {
                int score = 0;

                // Sprawdzenie długości hasła
                if (password.Length >= 8)
                {
                    score++;
                }

                // Sprawdzenie zawartości hasła
                if (ContainsLowercaseLetter(password))
                {
                    score++;
                }

                if (ContainsUppercaseLetter(password))
                {
                    score++;
                }

                if (ContainsDigit(password))
                {
                    score++;
                }

                if (ContainsSpecialCharacter(password))
                {
                    score++;
                }

                return score;
            }

            bool ContainsLowercaseLetter(string password)
            {
                foreach (char c in password)
                {
                    if (char.IsLower(c))
                    {
                        return true;
                    }
                }

                return false;
            }

            bool ContainsUppercaseLetter(string password)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        return true;
                    }
                }

                return false;
            }

            bool ContainsDigit(string password)
            {
                foreach (char c in password)
                {
                    if (char.IsDigit(c))
                    {
                        return true;
                    }
                }

                return false;
            }

            bool ContainsSpecialCharacter(string password)
            {
                foreach (char c in password)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        return true;
                    }
                }

                return false;
            }
        }
        public class zaawansowane
        {
            public int CalculatePasswordStrength(string password)
            {
                int score = 0;

                // Sprawdzenie długości hasła
                if (password.Length >= 8)
                {
                    score++;
                }

                // Sprawdzenie złożoności znaków
                if (ContainsLowercaseLetter(password) && ContainsUppercaseLetter(password))
                {
                    score++;
                }

                if (ContainsDigit(password))
                {
                    score++;
                }

                if (ContainsSpecialCharacter(password))
                {
                    score++;
                }

                // Sprawdzenie unikalności
                if (IsUnique(password))
                {
                    score++;
                }

                // Sprawdzenie siły z wykorzystaniem heurystyki
                score += CalculateStrengthHeuristic(password);

                return score;
            }

            bool ContainsLowercaseLetter(string password)
            {
                return password.Any(char.IsLower);
            }

            bool ContainsUppercaseLetter(string password)
            {
                return password.Any(char.IsUpper);
            }

            bool ContainsDigit(string password)
            {
                return password.Any(char.IsDigit);
            }

            bool ContainsSpecialCharacter(string password)
            {
                return password.Any(c => !char.IsLetterOrDigit(c));
            }

            bool IsUnique(string password)
            {
                return password.Distinct().Count() == password.Length;
            }

            int CalculateStrengthHeuristic(string password)
            {
                int strength = 0;

                // Dodatkowe punkty za długość hasła
                strength += Math.Min(2, password.Length / 4);

                // Dodatkowe punkty za złożoność znaków
                int complexity = 0;
                if (ContainsLowercaseLetter(password))
                {
                    complexity++;
                }
                if (ContainsUppercaseLetter(password))
                {
                    complexity++;
                }
                if (ContainsDigit(password))
                {
                    complexity++;
                }
                if (ContainsSpecialCharacter(password))
                {
                    complexity++;
                }
                strength += Math.Min(2, complexity);

                // Dodatkowe punkty za różnorodność znaków
                int diversity = 0;
                if (password.Any(char.IsLetter))
                {
                    diversity++;
                }
                if (password.Any(char.IsDigit))
                {
                    diversity++;
                }
                if (password.Any(char.IsSymbol))
                {
                    diversity++;
                }
                strength += Math.Min(2, diversity);

                return strength;
            }
        }
    }
}
