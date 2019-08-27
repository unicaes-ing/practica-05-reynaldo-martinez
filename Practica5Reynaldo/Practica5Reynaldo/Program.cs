using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5Reynaldo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escriba una función que retorne cuantos días faltan para finalizar el año actual. Y demostrar
              su uso con un programa.             */
            int opc = 0;

            Console.WriteLine("[1] Ejercicio 1");
            Console.WriteLine("[2] Ejercicio 2");
            Console.WriteLine("[3] Ejercicio 3");
            Console.WriteLine("[4] Ejercicio 4");
            Console.WriteLine("[5] Ejercicio 5");
            Console.WriteLine("[6] Ejercicio 6");
            Console.WriteLine("Que ejercicio desea ver?");
            opc = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            switch (opc)
            {
                   
                case 1:
                    Console.WriteLine( "Los dias que faltan son: "+ejer1());
                    break;
                case 2:
                    int numero = 0;
                    Console.WriteLine("Coloque un numero");
                    numero = Convert.ToInt16(Console.ReadLine());
                    ejer2(numero);
                    break;
                case 3:
                    int num = 0;
                      Console.WriteLine("FACTORIAL DE UN NUMERO C# n Inserta el numero:"); 
                      num = int.Parse(Console.ReadLine());
                      Console.WriteLine(ejer3(num));   
                    break;
                case 4:
                    int t1, t2, t3, t4;
                    Console.WriteLine("Coloque el primer telefono sin guion");
                    t1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Coloque el segundo telefono sin guion");
                    t2 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Coloque el tercer telefono sin guion");
                    t3 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Coloque el cuarto telefono sin guion");
                    t4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("El numero ganador es: "+ ejer4(t1, t2, t3, t4));
                    break;
                case 5:
                    double porcentajeDescuento = 0, precio=0;
                    Console.WriteLine("Coloque el valor de la compra");
                    precio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Coloque el porcentaje de descuento [0.example]");
                    porcentajeDescuento = double.Parse(Console.ReadLine());
                   
                    Console.WriteLine("A pagar con descuento : {0} ", ejer5(precio, porcentajeDescuento));
                    break;
                case 6:
                    double suma = 0;

                     Console.WriteLine("Cuantos alumnos seran?");
                       int alumnos = Convert.ToInt32(Console.ReadLine());
                    double []lasNotas = new double[alumnos];
                    for (int i = 0; i < lasNotas.Length; i++)
                    {
                        Console.WriteLine("Coloque la nota del alumno "+ (i+1));
                        double nota = Convert.ToDouble(Console.ReadLine());
                        lasNotas[i] = nota;
                        suma = suma + lasNotas[i];
                    }
                    Console.WriteLine("El promedio es: " + ejer6(lasNotas));
                    
                   
                  
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

        #region ejercicio1
        static int ejer1()
        {
            return 365 - DateTime.Now.DayOfYear;
        }
        #endregion

        #region ejercicio2
           static int ejer2(int numero)
        {
               if (numero < 0)
	            {
		            Console.WriteLine("El numero es negativo");
	            }else
	            {
                   if (numero > 0)
	                {
		                Console.WriteLine("El numero es positivo");
	                }else
	                    {
                            if (numero == 0)
	                        {
		                        Console.WriteLine("El numero es cero");
	                        }
	                    }
	            }

               return numero;
        }
       
        #endregion

        #region ejer3
           static int ejer3(int nu)
           {
               int resultado=1;
               for (int i = nu; i > 0; i--)
               {
                   Console.WriteLine(nu + "*" + i + "=" + nu*i + "    " );
                   resultado *=  i;
               }
               return resultado;
           }
        #endregion

        #region ejercicio4
        static int ejer4(int t1, int t2, int t3, int t4)
        {
            int ganador = 0;
            int aleatorio;
            Random ale = new Random();
            aleatorio = ale.Next(1,4);

            if (aleatorio == 1)
	        {
		        ganador = t1;
	        }else
	            {
                    if (aleatorio == 2)
	                {
		                ganador = t2;
	                }else
	                    {
                            if ( aleatorio == 3)
	                        {
		                       ganador = t3;
                            }
                            else
                            {
                                if (ganador == 4)
                                {
                                    ganador = t4;
                                }
                            }
	                    }
                            
	            }

            return ganador;
        }
        #endregion

        #region ejercicio5
        static double ejer5(double precio, double porcentaje = 0.01)
        {
            double descuento=0, totalPagar = 0;
            descuento = precio * porcentaje;
            totalPagar = precio - descuento;
            return totalPagar;
        }
        #endregion


        #region Ejercicio6
        static double ejer6(double[] notas)
        {
           
            double promedio = 0;
            double suma = 0;
            double nota;


            for (int i = 0; i < notas.Length; i++)
            {
                suma = suma + notas[i];
            }
            promedio = suma / notas.Length;

            return promedio;
        }
        #endregion
    }
}
