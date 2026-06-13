namespace GestKaixa.Helpers
{
    public static class ConsoleHelpers
    {
        //--- Mensajes -----------------------------------------------------------
        public static void MostrarError(string mensaje)
        {
            Console.Write("\n[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR");
            Console.ResetColor();
            Console.WriteLine("] : " + mensaje);
        }

        public static void MostrarExito(string mensaje)
        {
            Console.Write("\n[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("OK");
            Console.ResetColor();
            Console.WriteLine("] : " + mensaje);
        }

        public static void MostrarAdvertencia(string mensaje)
        {
            Console.Write("\n[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("AVISO");
            Console.ResetColor();
            Console.WriteLine("] : " + mensaje);
        }

        public static void MostrarInfo(string mensaje)
        {
            Console.Write("\n[");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("INFO");
            Console.ResetColor();
            Console.WriteLine("] : " + mensaje);
        }

        //--- Títulos -----------------------------------------------------------
        public static void MostrarTitulo(string titulo)
        {
            string linea = new string('─', 40);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(linea);
            Console.WriteLine("  GESTKAIXA · " + titulo.ToUpper());
            Console.WriteLine(linea);
            Console.ResetColor();
        }

        //--- Separadores -----------------------------------------------------------
        public static void MostrarSeparador()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('─', 40));
            Console.ResetColor();
        }

        //--- Inputs -----------------------------------------------------------
        public static string PedirInput(string etiqueta)
        {
            Console.Write(etiqueta + ": ");
            return Console.ReadLine() ?? "";
        }

        public static string PedirPassword()
        {
            Console.Write("Contraseña: ");
            string password = "";
            ConsoleKeyInfo tecla;
            do
            {
                tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Substring(0, password.Length - 1);
                    Console.Write("\b \b");
                }
                else if (tecla.Key != ConsoleKey.Enter && tecla.Key != ConsoleKey.Backspace)
                {
                    password = password + tecla.KeyChar;
                    Console.Write("*");
                }

            } while (tecla.Key != ConsoleKey.Enter);
            return password;
        }

        //--- Pausa -----------------------------------------------------------
        public static void Pausa()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Pulsa cualquier tecla para continuar...");
            Console.ResetColor();
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}