namespace ProgramasEnClase.Repeticiones
{
    public class BucleFor
    {
        public void ImprimirNumeroHasta100()
        {

            try
            {
                for (int i = 0; i <= 100; i++)
                {

                    Console.WriteLine($"El valor es: {i}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error imprimiendo los valores: {ex.Message}");

            }

        }
    }
}
