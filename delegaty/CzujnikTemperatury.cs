using System;
using System.Collections.Generic;
using System.Text;
using static Program;

namespace delegaty
{
    public class CzujnikTemperatury
    {


        public event AlertTemperaturyHandler PrzegrzanieWykryte;
        public string Nazwa { get; }
        public int Temperatura { get; set; }
        

        public CzujnikTemperatury(string nazwa)
        {
            Nazwa = nazwa;
        }



        public void SprawdzTemperature(int temperatura)
        {
            Temperatura = temperatura;

            Console.WriteLine($"[{Nazwa}] Aktualna temperatura wynosi: {Temperatura}°C");

            if(Temperatura > 100)
            {
                PrzegrzanieWykryte?.Invoke(Nazwa, Temperatura);
            }

        }

    }
}
