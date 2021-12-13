using System;

namespace Patron_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotor motorDiesel = new Diesel();
            Vehiculo berlina = new Berlina(motorDiesel, 4);

            berlina.MostrarCaracteristicas();
            berlina.Acelerar(2.4d);
            

        }
    }
}
