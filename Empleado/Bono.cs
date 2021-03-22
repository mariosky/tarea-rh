namespace Empleados
{
    public class Bono
    {
        static public decimal calcBono(Empleado e)
        {
            decimal bono;
            calcBono(e.Antigüedad, e.Edad, out bono);
            return bono;

        }

        static public void calcBono(short antigüedad, short edad, out decimal bono)
        {
            bono = 0.0m;
               
        }

    }
}
