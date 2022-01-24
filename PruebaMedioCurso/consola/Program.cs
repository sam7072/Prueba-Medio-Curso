using System;
using Modelo.entidades;

namespace consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Category cat1 = new Category()
            {
                Name ="terror",
                lastUpdate = "terror"
            };
            Category cat2 = new Category()
            {
                Name="Ficcion",
                lastUpdate="Ficcion"
            };
            Category cat3 = new Category()
            {
                Name="Animada",
                lastUpdate="Animada"
            };



            Actor act1 = new Actor()
            {
                firstName ="Allan",
                lastName = "Gonzales",
                lastUpdate = "godzilla"
            };
            Actor act2 = new Actor()
            {
                firstName="Mateo",
                lastName ="Yepez",
                lastUpdate = "matix"
            };
            Actor act3 = new Actor()
            {
                firstName="Diego",
                lastName="Suarez",
                lastUpdate="the room"
            };

            Language legE = new Language()
            {
                name="Spanish",
                lastUpdate= "Spanish"
            };
            Language legI = new Language()
            {
                name ="Ingles",
                lastUpdate= "Ingles"
            };


            Film film1 = new Film()
            {
                title = "godzilla",
                description= "El gran inicio de una brillante historia",

            };
            


        }
    }
}
