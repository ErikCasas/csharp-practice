namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

        /*
        • Nombre: Erik Santiago Henrández Casas
        • Grupo:  213022_780
        • Programa: Ing de sistemas 
        • Código Fuente: autoría propia 👇
         */
        {
            Console.Write("Ingrese el nombre del pasajero: ");
            string name = Console.ReadLine();

            double basicFare;
            while (true)
            {
                Console.Write("Ingrese la tarifa básica del pasaje: ");
                if (double.TryParse(Console.ReadLine(), out basicFare) && basicFare > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tarifa básica no válida. Intente nuevamente.");
                }
            }

            int age;
            while (true)
            {
                Console.Write("Ingrese la edad del pasajero: ");
                if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Edad no válida. Intente nuevamente.");
                }
            }

            string season;
            while (true)
            {
                Console.WriteLine("Seleccione la temporada:");
                Console.WriteLine("1. Alta");
                Console.WriteLine("2. Baja");
                if (int.TryParse(Console.ReadLine(), out int seasonOption) && (seasonOption == 1 || seasonOption == 2))
                {
                    season = seasonOption == 1 ? "alta" : "baja";
                    break;
                }
                else
                {
                    Console.WriteLine("Opción de temporada no válida. Intente nuevamente.");
                }
            }

            bool isEstudent;
            while (true)
            {
                Console.WriteLine("¿Es estudiante?");
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");

                if (int.TryParse(Console.ReadLine(), out int estudentOption) && (estudentOption == 1 || estudentOption == 2))
                {
                    isEstudent = estudentOption == 1;
                    break;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                }
            }

            // Validar compañía
            int companyOption;
            string company;
            while (true)
            {
                Console.WriteLine("Seleccione la compañía aérea:");
                Console.WriteLine("1. ALAS");
                Console.WriteLine("2. VOLAR");
                if (int.TryParse(Console.ReadLine(), out companyOption) && (companyOption == 1 || companyOption == 2))
                {
                    company = companyOption == 1 ? "ALAS" : "VOLAR";
                    break;
                }
                else
                {
                    Console.WriteLine("Opción de compañía no válida. Intente nuevamente.");
                }
            }

            // Lógica para el cálculo del precio final
            double finalPrice = basicFare;

            if (company == "ALAS")
            {
                if (season == "alta")
                {
                    finalPrice += basicFare * 0.30;
                }

                if (age < 18)
                {
                    finalPrice -= basicFare * 0.50;
                }
                else if (isEstudent && season == "baja")
                {
                    finalPrice -= basicFare * 0.10;
                }
            }
            else if (company == "VOLAR")
            {
                if (season == "alta")
                {
                    finalPrice += basicFare * 0.20;
                }

                if (age < 18)
                {
                    finalPrice -= basicFare * 0.50;
                }
            }

            Console.WriteLine($"El pasajero {name} debe pagar: ${finalPrice:F2}");
        }
    }
}
