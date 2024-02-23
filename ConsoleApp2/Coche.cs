using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Coche
    {
        // Atributos privados
        private Motor motor;
        private string marca;
        private string modelo;
        private double precioAverias;

        // Constructor con dos parámetros para la marca y el modelo
        public Coche(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.motor = new Motor(0); // Se crea un motor con potencia 0 por defecto
            this.precioAverias = 0.0;
        }

        // Getter para motor
        public Motor GetMotor()
        {
            return motor;
        }

        // Getter para marca
        public string GetMarca()
        {
            return marca;
        }

        // Getter para modelo
        public string GetModelo()
        {
            return modelo;
        }

        // Getter para precioAverias
        public double GetPrecioAverias()
        {
            return precioAverias;
        }

        // Método para acumular averías
        public void AcumularAveria(double importe)
        {
            precioAverias += importe;
        }
    }
}
