using System.ComponentModel.DataAnnotations;

namespace Entities
{
	public class StorageEntity
	{
        [Key] // Llave primaria
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; } // Ultima fecha de actualizacion

        [Required]
        public int PartialQuantity { get; set; } // Cantidad de producto


        // Relación con productos (ProductEntity)
        // El almacenamiento solo puede tener un producto
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }


        // Relación con bodegas (WarehouseEntity)
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }


        // Relación con movimientos (InputOutputEntity)
        public ICollection<InputOutputEntity> InputOutputs { get; set; }
    }
}
