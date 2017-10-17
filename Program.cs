using System;
using System.Collections.Generic;

namespace Sorteo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaParticipantes = new List<string>();
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Para participar del sorteo por favor ingrese su nombre.");
                string participante = Console.ReadLine();
                listaParticipantes.Add(participante);
                Console.WriteLine("Ya está participando!");
            }

            Console.WriteLine("El sorteo ha finalizado! Esta es la lista de participantes:");
            
            foreach(string item in listaParticipantes)
            {
                Console.WriteLine(item);
            }
            int ganador = new Random().Next(listaParticipantes.Count+1);
            Console.WriteLine("El ganador es " + listaParticipantes[ganador] + "! Felicitaciones!!!!!");

        }
    }
}
