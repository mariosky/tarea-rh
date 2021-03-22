using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados
{

    public struct HorasTrabajadas
    {
        public HorasTrabajadas(DateTime horaInicial, DateTime horaFinal)
        {

        }

      //  public DateTime HoraFinal { get; set; }
      //  public DateTime HoraInicial { get; set; }

        public int TotalHoras
        {
            get
            {
               return 0;
            }
        }

    }

    public class Empleado
    {
        private int identificador;
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private DateTime fechaDeInicio;
        private decimal salarioBase;
        private List<HorasTrabajadas> horasMes = new List<HorasTrabajadas>();

        private int _totalHoras()
            {
                return 0;
            }
                
        public decimal TotalHoras
        {
            get => _totalHoras();
        }

        public decimal SalarioPeriodo
        {
            get => 0;
        }

        public Empleado(int identificador, 
            string nombre, 
            string apellido, 
            DateTime fechaDeNacimiento, 
            DateTime fechaDeInicio,
            decimal salarioBase)
           {

           }

        public short Antigüedad
        {
            get {
                // Calcular Antigüedad
                int ant = 0;
                return (short) ant;
            }
        }

        public short  Edad
        {
            get 
            {
                // Calcular edad
                var edad = 0;
                return (short)edad;
            }
        }

        public decimal BonoPeriodo
        {
            get
            {
                // Calcular bono
                return Bono.calcBono(this);
            }
        }

        public void AgregaHoras(HorasTrabajadas horas)
        {
            

        }
        public void BorraHora(HorasTrabajadas horas)
        {
            
        }
        public void BorraHoras()
        {
            
        }

        

        public int Identificador { get => identificador; set => identificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public DateTime FechaDeInicio { get => fechaDeInicio; set => fechaDeInicio = value; }
        public decimal SalarioBase { get => salarioBase; set => salarioBase = value; }
    }
}

