# Nota importante:
Para entrgar la tarea en un curso, espera la invitación a la tarea y hazla en el repositorio 
creado autamáticamente por GitHub Classroom. Si quieres practicar, usa este repositorio como
plantilla para crear una copia en tu usuario.

# Ejercicio Unidad 2

## Recursos Humanos
Una empresa desea llevar el control del sueldo de sus empleados antes de impuestos.

### Sueldo
El sueldo de los empleados se calcula utilizando un salario base multiplicado por hora trabajada.
Para cada  empleado se registra en una lista el periodo diario de trabajo con una hora inicial y
una hora final. Para calcular el número de horas trabajadas en el periodo simplemente 
se suman las diferencias entre la hora final e inicial. Para calcular el sueldo base
se multiplica el número de horas por el sueldo base. Las horas trabajadas pueden incluir fracciones.
En este caso los empleados no tienen un horario establecido por lo que no hay retardos o faltas.

### Bono
Al sueldo base se le suma un bono el cual considera la antigüedad del empleado. A partir del 
tercer año se le suma un 2% del sueldo base por año adicional trabajado. Por ejemplo, un
empleado de 5 años recibiría un bono del 6% (2% del tercer año + 2% del cuarto +2% del quinto). 
Además, si el empleado es mayor de 40 años recibe un 2% adicional por cada año.

### Necesidades de los usuarios
Los usuarios desean agregar al sistema las horas trabajadas por cada empleado. Al final del mes desean 
poder consultar la información por cada empleado, utilizando su número de control.
La información consiste en el nombre del empleado, horas trabajadas, bono y sueldo del periodo.

### Pruebas Unitarias
Tú código debe pasar las siguientes pruebas:

```csharp
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

```




  

