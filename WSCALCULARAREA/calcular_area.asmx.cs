using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSCALCULARAREA
{
    /// <summary>
    /// Descripción breve de calcular_area
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class calcular_area : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public decimal area_cuadrado (decimal lado)
        {
            CalcularArea ca = new CalcularArea();
            ca.lado_cuadrado = lado;
            return ca.area_cuadrado();
        }
        [WebMethod]
        public decimal area_triangulo (decimal bace, decimal altura)
        {
            CalcularArea ca = new CalcularArea();
            ca.base_triangulo = bace;
            ca.altura_triangulo = altura;
            return ca.area_triangulo();
        }
        [WebMethod]
        public double area_circulo (double radio)
        {
            CalcularArea ca = new CalcularArea();
            ca.radio_circulo = radio;
            return ca.area_circulo();
        }
    }
}
