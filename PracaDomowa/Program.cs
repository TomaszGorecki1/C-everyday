using System;

namespace ConsoleApp4
{
    class Program
    {


        static void Main(string[] args)
        {

            uint liczbaWe = 0; //deklaracja liczby wejsciowej
            uint podstawaSystemu; //deklaracja podstawy systemu
            int[] wagaCyfry = new int[25]; //deklaracja tablicy liczącej wagi cyfry, pozostałość po wczesniejszym podejsciu do problemu, tożsame z tym co wysłałem w trakcie lekcji
            int[] tab = new int[25]; //deklaracja tablicy na której robię wszystkie obliczenia
            int liczbaWeTmp = 0;  //deklaracja tymczasowej zmiennej aby wyświetlić na końcu podsumowanie obliczeń
            string liczbaWyStr =""; // deklaracja stirnga w którym jako tekst zostanie wyświetlony wynik


            Console.WriteLine($"Wpisz liczbe: "); 
            liczbaWe = Convert.ToUInt32(Console.ReadLine()); //wprowadzenie liczby  przez użytkownika
            Console.WriteLine($"Liczba : {liczbaWe} ");
            if (liczbaWe < 0) //sprawdzenie poprawności danych wpisanych przez użytkownika
            {
                Console.WriteLine("zle dane");
                return;
            }
            liczbaWeTmp= (int)liczbaWe; //wstawienie do tymczasowej zmiennej wpisanej przez użytkownika liczby
            Console.WriteLine($"Wpisz podstawe systemu: ");
            podstawaSystemu = Convert.ToUInt32(Console.ReadLine());
            if (podstawaSystemu < 2 || podstawaSystemu > 20)  //sprawdzenie poprawnośći danych wpisanych przez użytkownika
            {
                Console.WriteLine("zle dane");
                return;
            }
            wagaCyfry[0] = (int)podstawaSystemu; //przelicznie wagi cyfy
            for (int i = 1; i <= 10; i++)
            {
                wagaCyfry[i] = wagaCyfry[i - 1] * (int)podstawaSystemu; //generalnie zbędne, pozostałość po poprzednim podejściu, podobne zrobiłem na lekcji, lecz nie ma to żadnego wykorzystania.
            }

            int n = 0; //deklaruję zmienną na której opreuje pętla
            while(liczbaWe !=0)
            {
                int rest; //deklaracja zmiennej
                rest = (int)(liczbaWe % podstawaSystemu); // reszta z dzielenia
                if (rest >= 10) // warunek dla którego ma się wykonać switch.
                {
                    switch (rest) //switch który nie wiedzieć czemu nie działa, nie zdołałem się z tym uporać do późnego wieczora niestety
                    {
                        case 10:
                            tab[n] = 'A';
                            break;
                        case 11:
                            tab[n] = 'B';
                            break;
                        case 12:
                            tab[n] = 'C';
                            break;
                        case 13:
                            tab[n] = 'D';
                            break;
                        case 14:
                            tab[n] = 'E';
                            break;
                        case 15:
                            tab[n] = 'F';
                            break;
                        case 16:
                            tab[n] = 'G';
                            break;
                        case 17:
                            tab[n] = 'H';
                            break;
                        case 18:
                            tab[n] = 'i';
                            break;
                        case 19:
                            tab[n] = 'J';
                            break;
                        case 20:
                            tab[n] = 'K';
                            break;
                        default:
                            tab[n] = 'L';
                            break;
                    }
                }
                tab[n] = rest; //ustawienie komórki n-tej w zmiennej na wartość reszty
                liczbaWe = liczbaWe / podstawaSystemu; // ustawienie liczby na pozostałość po dzieleniu liczby przez podstawę
                Console.WriteLine(tab[n]); // wypisanie n-tej komórki tabelii
                n++; // zwiększamy wartość zmiennej na której operuje pętla
            }
            while(n > 0) //pętla 
            {
                n--; //dekrementacja zmiennej na której operuje pętla
                liczbaWyStr = liczbaWyStr + tab[n]; // wstawienie/połączenie do stringa komórek tablicy
            }
            Console.WriteLine($"Liczba {liczbaWeTmp} w systemie {podstawaSystemu} wynosi {liczbaWyStr}"); // wypisanie w estetyczny sposób wszystkich wyników
            
        }

    }
} 
//                                                              Tomasz Górecki 2D 14.01.2022r. 