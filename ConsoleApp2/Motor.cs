using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Motor
    {

        // Atributos privados
        private int litros_de_aceite;
        private int potencia;


        // Constructor con un parámetro para la potencia
        public Motor(int potencia)
        {
            this.litros_de_aceite = 0; // Valor por defecto
            this.potencia = potencia;
        }

        // Getter para litros_de_aceite
        public int GetLitrosDeAceite()
        {
            return litros_de_aceite;
        }

        // Setter para litros_de_aceite
        public void SetLitrosDeAceite(int litros)
        {
            litros_de_aceite = litros;
        }

        // Getter para potencia
        public int GetPotencia()
        {
            return potencia;
        }

        // Setter para potencia
        public void SetPotencia(int potencia)
        {
            this.potencia = potencia;
        }
    }
}
