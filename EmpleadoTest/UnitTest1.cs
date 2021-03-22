using System;
using Xunit;
using Empleados;


namespace EmpleadoTest
{
    public class UnitTestRH
    {
        [Fact]
        public void AgregaSumaHoras()
        {
            Empleado e = new Empleado(1000, "Ana", "Lee", new DateTime(1995, 8, 23), new DateTime(2014, 1, 12), 200);
            Assert.Equal(0, e.TotalHoras);
            e.AgregaHoras(new HorasTrabajadas(new DateTime(2021, 3, 1, 8, 0, 0, 0), new DateTime(2021, 3, 1, 14, 0, 0, 0)));
            e.AgregaHoras(new HorasTrabajadas(new DateTime(2021, 3, 1, 8, 0, 0, 0), new DateTime(2021, 3, 1, 14, 0, 0, 0)));
            Assert.Equal(12, e.TotalHoras);
        }

        [Fact]
        public void BonoTest()
        {
            Empleado e = new Empleado(1000, "Joe", "Lee", new DateTime(1973, 8, 23), new DateTime(2014, 1, 12), 200);
            Assert.Equal(47, e.Edad);
            Assert.Equal(7, e.Antigüedad);
            Assert.Equal(0.24m, Bono.calcBono(e));
        }

        [Fact]
        public void BonoOutTest()
        {
            Empleado e = new Empleado(1000, "Joe", "Lee", new DateTime(1973, 8, 23), new DateTime(2014, 1, 12), 200);
            Assert.Equal(47, e.Edad);
            Assert.Equal(7, e.Antigüedad);
            decimal bono;
            Bono.calcBono(e.Antigüedad, e.Edad, out bono);
            Assert.Equal(0.24m, bono);
        }

        [Fact]
        public void ConstructorYPropiedades()
        {
            Empleado e = new Empleado(1000, "Ana", "Lee", new DateTime(1995, 8, 23), new DateTime(2014, 1, 12), 200);
            Assert.Equal("Ana", e.Nombre);
            Assert.Equal("Lee", e.Apellido);
            
        }

        [Fact]
        public void Edad()
        {
            Empleado e = new Empleado(1000, "Ana", "Lee", new DateTime(1995, 8, 23), new DateTime(2014, 1, 12), 200);
            Assert.Equal(25, e.Edad);
        }

        [Fact]
        public void Antigüedad()
        {
            Empleado e = new Empleado(1000, "Ana", "Lee", new DateTime(1995, 8, 23), new DateTime(2014, 1, 12), 200);
            Assert.Equal(7, e.Antigüedad);
        }

    }
}
