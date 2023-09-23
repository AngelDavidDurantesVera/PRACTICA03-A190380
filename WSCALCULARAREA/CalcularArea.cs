using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSCALCULARAREA
{
    public class CalcularArea
    {
        public decimal lado_cuadrado { get; set; }
        public decimal altura_triangulo { get; set; }
        public decimal base_triangulo { get; set; }
        public double radio_circulo { get; set; }
        public decimal area_cuadrado ()
        {
            return lado_cuadrado * lado_cuadrado;
        }
        public decimal area_triangulo ()
        {
            return base_triangulo * altura_triangulo / 2;
        }
        public double area_circulo ()
        {
            var rc = radio_circulo * radio_circulo;
            return rc * Math.PI;
        }
    }
}