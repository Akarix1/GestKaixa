namespace GestKaixa.Models
{
    public class Movimiento
    {
        public int Id { get; set; }
        public int CuentaId { get; set; }
        public decimal Importe { get; set; }
        public string Concepto { get; set; }
        public decimal Saldo { get; set; }
        public DateTime Fecha { get; set; }
    }
}