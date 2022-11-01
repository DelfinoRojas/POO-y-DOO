using System;

namespace modulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona();
            persona1.Nombre = "Felipe Gavilán";
            persona1.Caminar(7);
            persona1.Resumen();
        }
    }
}
