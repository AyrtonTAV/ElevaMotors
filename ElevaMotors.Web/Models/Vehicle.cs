using System.ComponentModel.DataAnnotations;

namespace ElevaMotors.Web.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Modelo { get; set; } = string.Empty;

        [Required]
        [StringLength(10)]
        public string Placa { get; set; } = string.Empty;

        [StringLength(50)]
        public string? Chassi { get; set; }

        [Range(0, 9999999)]
        public decimal ValorCompra { get; set; }

        [Range(0, 9999999)]
        public decimal ValorVenda { get; set; }

        [Range(0, 9999999)]
        public decimal CustoTotal { get; set; }

        public bool EhConsignado { get; set; }
        public bool EhParceria { get; set; }

        // Situação: Disponível / Vendido / Em manutenção
        public string Situacao { get; set; } = "Disponível";

        public DateTime DataEntrada { get; set; } = DateTime.Now;

        public DateTime? DataVenda { get; set; }
    }
}
