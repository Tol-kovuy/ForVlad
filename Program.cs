using System;

namespace ForVlad
{
    class Program
    {
        static void Main()
        {
            MaksymMeskov ja = new MaksymMeskov();
            ja.ToBiuldTheBoatBrabus();
            ja.ToGo();
            ja.ToLearnProgramming();
            ja.ToPlayGuita();
            ja.ToThinth();
            ja.ToUpHeand();

            Console.WriteLine(ja.Age.ToString(), ja.Growth, ja.Name, ja.SerName, ja.Weight);

            Console.ReadKey();
        }
    }
}
