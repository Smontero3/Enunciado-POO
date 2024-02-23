
using ConsoleApp2;


//Creacion del objeto garaje
Garaje garaje = new Garaje();

//Creacion de los 2 objetos coches
Coche coche1 = new Coche("Toyota","Corolla");
Coche coche2 = new Coche("Honda", "Civic");

for (int i = 0; i < 2; i++) {
    // Aceptar y devolver el primer coche
    if (garaje.AceptarCoche(coche1, "Frenos"))
    {
        Console.WriteLine("Coche aceptado en el garaje: " + coche1.GetMarca() + " " + coche1.GetModelo());
        garaje.DevolverCoche(coche1);
    }
    else
    {
        Console.WriteLine("El garaje está ocupado, no se puede aceptar el coche.");
    }

    // Aceptar y devolver el segundo coche
    if (garaje.AceptarCoche(coche2, "Aceite"))
    {
        Console.WriteLine("Coche aceptado en el garaje: " + coche2.GetMarca() + " " + coche2.GetModelo());
        garaje.DevolverCoche(coche2);
    }
    else
    {
        Console.WriteLine("El garaje está ocupado, no se puede aceptar el coche.");
    }




}
Console.WriteLine("Información de los coches:");
Console.WriteLine("Coche 1 - Marca: " + coche1.GetMarca() + ", Modelo: " + coche1.GetModelo() + ", Importe de Averías: " + coche1.GetPrecioAverias() + "€, Litros de Aceite: " + coche1.GetMotor().GetLitrosDeAceite());
Console.WriteLine("Coche 2 - Marca: " + coche2.GetMarca() + ", Modelo: " + coche2.GetModelo() + ", Importe de Averías: " + coche2.GetPrecioAverias() + "€, Litros de Aceite: " + coche2.GetMotor().GetLitrosDeAceite());





