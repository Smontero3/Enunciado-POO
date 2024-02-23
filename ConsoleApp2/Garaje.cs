using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Garaje
    {
        // Atributos privados
        private Coche? cocheEnAtencion;
        private string averiaAsociada;
        private int numCochesAtendidos;
        private Random random = new Random();

        // Constructor
        public Garaje()
        {
            cocheEnAtencion = null;
            averiaAsociada = "";
            numCochesAtendidos = 0;
        }

        // Método para aceptar un coche
        public bool AceptarCoche(Coche coche, string averia)
        {
            // Verificar si ya está atendiendo un coche
            if (cocheEnAtencion != null)
            {
                return false; // Ya está atendiendo un coche, no se puede aceptar otro
            }


            // Atender el coche
            cocheEnAtencion = coche;
            averiaAsociada = averia;
            numCochesAtendidos++;

            return true;
        }

        // Método para devolver el coche y dejar el garaje en estado de aceptar uno nuevo
        public void DevolverCoche(Coche coche)
        {

            // Tratar la avería y acumular importe aleatorio
            double importeAveria = random.NextDouble() * 500; // Importe aleatorio entre 0 y 500
            coche.AcumularAveria(importeAveria);

            // Aumentar litros de aceite si la avería es "aceite"
            if (averiaAsociada.ToLower() == "aceite")
            {
                int litrosActuales = coche.GetMotor().GetLitrosDeAceite();
                coche.GetMotor().SetLitrosDeAceite(litrosActuales + 10);
            }

            // Dejar el garaje listo para aceptar un nuevo coche
            cocheEnAtencion = null;
            averiaAsociada = "";
        }

        // Getter para el número de coches atendidos
        public int GetNumCochesAtendidos()
        {
            return numCochesAtendidos;
        }
    }
}
