using System;

namespace CSharpOOPExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de quartos alugados");
            int quantityRooms = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Room[] rooms = new Room[10];

            for (int i = 0; i < quantityRooms; i++)
            {
                Console.WriteLine("Digite o Nome");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o Email");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o numero do quarto");
                int numberRoom = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Room room = new Room(name, email, numberRoom);
                for (int j = 0; j <= quantityRooms; j++)
                {
                    if (j == room.numberRoom)
                    {
                        rooms[j] = room;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine(rooms[i].ToString());
                    Console.WriteLine();
                }
            }
        }
    }
}