using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTransporte.Models
{
    public class Reporte
    {
        [Key]
        public int IdReporte { get; set; }

        public string TipoReporte { get; set; } = string.Empty;
        public DateTime FechaGeneracion { get; set; } = DateTime.Now;
        public string? Descripcion { get; set; }

        public int IdVehiculo { get; set; }

        [ForeignKey("IdVehiculo")]public Vehiculo? Vehiculo { get; set; }
    }
}
