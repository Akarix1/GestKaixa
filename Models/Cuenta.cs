namespace GestKaixa.Models
{
    public class Cuenta
    {
        public int Id { get; set; }
        public string NumeroCuenta { get; set; }
        public DateTime DataCreacion { get; set; }
        public string Estado { get; set; } // ACTIVO / BLOQUEADO
    }
}