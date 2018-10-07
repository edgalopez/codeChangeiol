/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        #region Formas

        public const int Cuadrado = 1;
        public const int TrianguloEquilatero = 2;
        public const int Circulo = 3;
        public const int Trapecio = 4;

        #endregion

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Frances = 3;

        #endregion

        private readonly decimal _lado ;

        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;

        }

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();

            string traduccionArea = "";
            string traduccionPerimetro = "";
            string traduccionForma = "";
            string traduccionLista = "";
            string traduccionReporte = "";

            Castellano castellano = new Castellano();
            Ingles ingles = new Ingles();
            Frances frances = new Frances();



            switch (idioma)
            {
                case Castellano:
                    traduccionArea = castellano.TraducirTitulo("A");
                    traduccionPerimetro = castellano.TraducirTitulo("P");
                    traduccionForma = castellano.TraducirTitulo("F");
                    traduccionLista = castellano.TraducirTitulo("L");
                    traduccionReporte = castellano.TraducirTitulo("R");
                    break;
                case Ingles:
                    traduccionArea = ingles.TraducirTitulo("A");
                    traduccionPerimetro = ingles.TraducirTitulo("P");
                    traduccionForma = ingles.TraducirTitulo("F");
                    traduccionLista = ingles.TraducirTitulo("L");
                    traduccionReporte = ingles.TraducirTitulo("R");
                    break;
                case Frances:
                    traduccionArea = frances.TraducirTitulo("A");
                    traduccionPerimetro = frances.TraducirTitulo("P");
                    traduccionForma = frances.TraducirTitulo("F");
                    traduccionLista = frances.TraducirTitulo("L");
                    traduccionReporte = frances.TraducirTitulo("R");
                    break;

            }

            if (!formas.Any())
            {
                sb.Append(traduccionLista);
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(traduccionReporte);

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;

                for (var i = 0; i < formas.Count; i++)
                {

                    switch (formas[i].Tipo)
                    {
                        case Cuadrado :
                            Cuadrado cuadrado = new Cuadrado();
                            areaCuadrados += cuadrado.CalcularArea(formas[i]._lado);
                            perimetroCuadrados += cuadrado.CalcularPerimetro(formas[i]._lado);
                            numeroCuadrados++;
                            break;
                        case Circulo :
                            Circulo circulo = new Circulo();
                            numeroCirculos++;
                            areaCirculos += circulo.CalcularArea(formas[i]._lado);
                            perimetroCirculos += circulo.CalcularPerimetro(formas[i]._lado);
                            break;
                        case TrianguloEquilatero:
                            TrianguloEquilatero trianguloEquilatero = new TrianguloEquilatero();
                            numeroTriangulos++;
                            areaTriangulos += trianguloEquilatero.CalcularArea(formas[i]._lado);
                            perimetroTriangulos += trianguloEquilatero.CalcularPerimetro(formas[i]._lado);
                            break;
                    }

                }
                
                sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, Cuadrado, idioma));
                sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, Circulo, idioma));
                sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TrianguloEquilatero, idioma));

                // FOOTER

                sb.Append("TOTAL:<br/>");
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + traduccionForma + " ");
                sb.Append(traduccionPerimetro + " " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
                sb.Append(traduccionArea + " " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma)
        {
            if (cantidad > 0)
            {
                Castellano castellano = new Castellano();
                Ingles ingles = new Ingles();
                Frances frances = new Frances();

                string traduccionFigura = "";
                string traduccionArea = "";
                string traduccionPerimetro = "";

                switch (idioma)
                {
                    case 1:
                        traduccionFigura = castellano.TraducirFigura(tipo, cantidad, idioma);
                        traduccionArea = castellano.TraducirTitulo("A");
                        traduccionPerimetro = castellano.TraducirTitulo("P");
                        break;
                    case 2:
                        traduccionFigura = ingles.TraducirFigura(tipo, cantidad, idioma);
                        traduccionArea = ingles.TraducirTitulo("A");
                        traduccionPerimetro = ingles.TraducirTitulo("P");
                        break;
                    case 3:
                        traduccionFigura = frances.TraducirFigura(tipo, cantidad, idioma);
                        traduccionArea = frances.TraducirTitulo("A");
                        traduccionPerimetro = frances.TraducirTitulo("P");
                        break;
                }
                    return $"{cantidad} {traduccionFigura} | {traduccionArea} {area:#.##} | {traduccionPerimetro} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

    }
}
