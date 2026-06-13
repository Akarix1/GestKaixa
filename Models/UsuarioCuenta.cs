namespace GestKaixa.Models
{
    public class UsuarioCuenta
    {
        public int UsuarioId { get; set; }
        public int CuentaId { get; set; }
        public string Rol { get; set; } // TITULAR / AUTORIZADO
    }
}