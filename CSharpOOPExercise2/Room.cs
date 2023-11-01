using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPExercise2
{
    public class Room
    {
        public string name {  get; set; }
        public string email {  get; set; }
        public int numberRoom { get; set; }

        public Room(string name, string email, int numberRoom)
        {
            this.name = name;
            this.email = email;
            this.numberRoom = numberRoom;
        }

        public override string ToString()
        {
            return $"Nome: {name}, Email {email}, Quarto: {numberRoom}";
        }
    }
}
