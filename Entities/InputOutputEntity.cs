using System.ComponentModel.DataAnnotations;

namespace Entities
{
	public class InputOutputEntity
	{
        [Key] // Llave primaria
        [StringLength(50)]
        public string InOutId { get; set; }

        [Required]
        public DateTime InOutDate { get; set; } // Fecha

        [Required]
        public int Quantity { get; set; } // Cantidad

        [Required]
        public bool IsInput { get; set; } // Entrada o salida, true o false


        // Relación con almacenamiento (StorageEntity)
        public string StorageId { get; set; }
        public StorageEntity Storage { get; set; }

    }
}
