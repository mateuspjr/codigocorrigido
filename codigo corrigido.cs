using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;

namespace Romanos { // Existem 5 problemas para resolver. Que comecem os jogos.
                    // Usem os breakpoints para achar e arrumar. Prof. Augusto
    public class NumerosRomanos {
        public static string rom = "";
        public static bool v = true;

        static void Main(string[] args) {
            try {
                Console.Write("Digite um número entre 1 a 3999: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0 && numero < 4000) {
                    NumerosRomanos.ConverterParaRomano(numero);
                    Console.WriteLine("O algarismo romano: " + rom);
                } else {
                    Console.WriteLine("Número fora do intervalo!");
                }
            } catch (FormatException) {
                Console.WriteLine("Entrada de número inteiro inválida.");
            }

            Console.ReadKey();
        }

        public static bool ConverterParaRomano(int n) {
            do {
                // De 1000 a 3999
                if (n < 4000 && n > 999) {
                    switch (n / 1000) {
                        case 1: rom += "M"; break;
                        case 2: rom += "MM"; break;
                        case 3: rom += "MMM"; break;
                        default: v = false; return v;
                    }
                    n -= 1000 * (n / 1000);
                    return v;
                }

                // De 100 a 999
                else if (n < 1000 && n > 99) {
                    switch (n / 100) {
                        case 1: rom += "C"; break;
                        case 2: rom += "CC"; break;
                        case 3: rom += "CCC"; break;
                        case 4: rom += "CD"; break;
                        case 5: rom += "D"; break;
                        case 6: rom += "DC"; break;
                        case 7: rom += "DCC"; break;
                        case 8: rom += "DCCC"; break;
                        case 9: rom += "CM"; break;
                        default: v = false; return v;
                    }
                    n -= 100 * (n / 100);
                    return v;
                }

                // De 10 a 99
                else if (n < 100 && n > 9) {
                    switch (n / 10) {
                        case 1: rom += "X"; break;
                        case 2: rom += "XX"; break;
                        case 3: rom += "XXX"; break;
                        case 4: rom += "XL"; break;
                        case 5: rom += "L"; break;
                        case 6: rom += "LX"; break;
                        case 7: rom += "LXX"; break;
                        case 8: rom += "LXXX"; break;
                        case 9: rom += "XC"; break;
                        default: v = false; return v;
                    }
                    n -= 10 * (n / 10);
                    return v;
                }

                // De 1 a 9
                else if (n < 10 && n > 0) {
                    switch (n) {
                        case 1: rom += "I"; break;
                        case 2: rom += "II"; break;
                        case 3: rom += "III"; break;
                        case 4: rom += "IV"; break;
                        case 5: rom += "V"; break;
                        case 6: rom += "VI"; break;
                        case 7: rom += "VII"; break;
                        case 8: rom += "VIII"; break;
                        case 9: rom += "IX"; break;
                        default: v = false; return v;
                    }
                    n -= n;
                    return v;
                }
            } while (n != 0);
            return v;
        }
    }
}
