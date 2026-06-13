namespace GestKaixa.Models
{
    public class Alerta
    {
        public int Id { get; set; }
        public int CuentaId { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }
    }
}