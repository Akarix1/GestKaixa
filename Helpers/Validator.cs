namespace GestKaixa.Helpers
{
    public static class Validator
    {
        //--- DNI -----------------------------------------------------------
        public static bool ValidarDni(string dni)
        {
            if (dni.Length != 9) return false;

            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            string numeros = dni.Substring(0, 8);
            char letra = char.ToUpper(dni[8]);

            if (!numeros.All(char.IsDigit)) return false;

            int resto = int.Parse(numeros) % 23;
            return letras[resto] == letra;
        }

        //--- Teléfono -----------------------------------------------------------
        public static bool ValidarTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono)) return true;
            return telefono.Length <= 12 && telefono.All(c => char.IsDigit(c) || c == '+');
        }
        
        //--- Importe -----------------------------------------------------------
        public static bool ValidarImporte(string input, out decimal importe)
        {
            return decimal.TryParse(input, out importe) && importe > 0;
        }

        //--- Texto obligatorio -----------------------------------------------------------
        public static bool ValidarTexto(string texto, int maxLength)
        {
            return !string.IsNullOrWhiteSpace(texto) && texto.Length <= maxLength;
        }

        //--- Username -----------------------------------------------------------
        public static bool ValidarUsername(string username)
        {
            return !string.IsNullOrWhiteSpace(username) &&
                   username.Length >= 3 &&
                   username.Length <= 30 &&
                   username.All(c => char.IsLetterOrDigit(c) || c == '_');
        }

        //--- Password -----------------------------------------------------------
        public static bool ValidarPassword(string password)
        {
            return password.Length >= 6 && password.Length <= 64;
        }
    }
}