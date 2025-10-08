namespace Obligatorio._P2
{
    internal class Program
    {
        static Sistema miSistema;
        static void Main(string[] args)
        {
            miSistema = new Sistema();

            string opcion = "";
            while (opcion != "0")
            {
                MostrarMenu();
                Console.Write("Ingrese una opcion -> ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":

                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("ERROR: Opcion inválida");
                        break;
                }

                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }


        static void MostrarMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("****** MENÚ DE GESTIÓN DE GASTOS ******");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1 - Listar todos los usuarios");
            Console.WriteLine("2 - Listar pagos de un usuario por email");
            Console.WriteLine("3 - Alta de usuario");
            Console.WriteLine("4 - Listar usuarios por nombre de equipo");
            Console.WriteLine("5 - Listar gastos del mes actual");
            Console.WriteLine("0 - Salir");
        }




    }
}