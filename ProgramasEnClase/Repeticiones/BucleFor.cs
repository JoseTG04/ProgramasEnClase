using System.Security.Cryptography.X509Certificates;

namespace ProgramasEnClase.Repeticiones
{
    public class BucleFor
    {
        public void ImprimirNumeroHasta100()
        {
           
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    
                    Console.WriteLine($"El valor es: {i}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error imprimiendo los valores: {ex.Message}");

            }

        }


        public void CalcularSumayPromedio()
        {
            int valor;
            int suma = 0;
            int promedio;
            int cantidad;

            try
            {
                Console.Write("Digite la cantidad: ");

                cantidad = Convert.ToInt32( Console.ReadLine() );

                for (int i = 0; i <= cantidad; i++)
                {

                    Console.Write($"Digite el valor { i } : ");

                    valor = Convert.ToInt32( Console.ReadLine() );

                    suma += valor;

                }

                promedio = (suma / cantidad);

                Console.WriteLine($"La suma es: {suma} y el promedio es: {promedio}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error calculando la suma y el promedio: {ex.Message}");
            }
        }

        
    }
}
