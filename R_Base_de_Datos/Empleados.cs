using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_Base_de_Datos
{
    class Empleados
    {   
        private string nombre;
        private string dui;
        private double salario;
        private double afp;
        private double isss;
        private double neto;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Dui
        {
            get { return dui; }
            set { dui = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public double Afp
        {
            get { return afp; }
            set { afp = value; }
        }

        public double Isss
        {
            get { return isss; }
            set { isss = value; }
        }

        public double Neto
        {
            get { return neto; }
            set { neto = value; }
        }

        public double AFP(double Salario)
        {
            double CalcAFP = Salario * 0.0625;
            return CalcAFP;
        }
        public double ISSS(double Salario)
        {
            double CalcISSS = Salario * 3 / 100;
            return CalcISSS;
        }
        public double NETO(double Salario)
        {
            double CalcAFP = Salario * 0.0625;
            double CalcISSS = Salario * 3 / 100;
            double CalcNeto = Salario - CalcAFP - CalcISSS;
            return CalcNeto;
        }
    }
}
