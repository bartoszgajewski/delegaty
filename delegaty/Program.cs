using delegaty;

public class Program
{

    public delegate void AlertTemperaturyHandler(string nazwaUrzadzenia, int aktualnaTemperatura);

    public static void Main(string[] args)
    {


        CzujnikTemperatury Czujnik = new CzujnikTemperatury("Serwerownia Główna");
        CentralaKlimatyzacji Centrala = new CentralaKlimatyzacji();


        Czujnik.PrzegrzanieWykryte += Centrala.ReagujNaPrzegrzanie;




        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");


        Console.WriteLine("\n---Test1: Temperatura w normie---");
        Czujnik.SprawdzTemperature(45);

        Console.WriteLine("\n---Test2: Przekroczenie limitu---");
        Czujnik.SprawdzTemperature(105);


        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");



    }



}


