using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo6_proyectoFinal
{
    class CalculoSueldo
    {
        public double sueldo;

        public double DescIsss()
        {
            if (sueldo >= 0.01 && sueldo <= 685.71)
            {
                return (sueldo * 0.03);
            }
            else
            {
                return 20.57;
            }

        }

        public double DesAfp()
        {
            return sueldo * 0.0725;
        }

        public double DesRenta()
        {
            if (sueldo >= 472.01 && sueldo < 895.24)
            {
                return ((sueldo - 472.00) * 0.1) + 17.67;
            }
            else if (sueldo > 895.25 & sueldo < 2038.10)
            {
                return ((sueldo - 895.24) * 0.2) + 60.00;
            }
            else if (sueldo > 2038.11)
            {
                return ((sueldo - 2038.10) * 0.3) + 288.57;
            }
            return 0;


        }

       public decimal SueldoNeto()
        {
          
            double sueldo = this.sueldo -  DescIsss() - DesAfp() - DesRenta();
          
            decimal sueldoNeto = Convert.ToDecimal(sueldo);

            return sueldoNeto;
        }

    }
        
    }