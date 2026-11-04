using System;
using System.Collections.Generic;
using System.Text;

namespace delegaty
{
    public class CentralaKlimatyzacji
    {


        public void ReagujNaPrzegrzanie(string Urzadzenie, int Temperatura)
        {

            Console.WriteLine($"[CENTRALA] ALARM! Urządzenie [{Urzadzenie}] osiągneło {Temperatura}°C! Włączam chłodzenie awaryjne");
            

        }


    }
}
