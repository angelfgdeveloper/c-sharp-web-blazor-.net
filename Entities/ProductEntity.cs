using System.ComponentModel.DataAnnotations;

namespace Entities
{
	public class ProductEntity
	{
		[Key] // Llave primaria (Data Annotations)
		[StringLength(50)] // Max. 50 caracteres
		public string ProductId { get; set; }

		[Required] // Campo obligatorio
		[StringLength(100)] // Max. 100 caracteres
		public string ProductName { get; set; }

		[StringLength(600)] // Max. 600 caracteres
		public string ProductDescription { get; set; }

		public int TotalQuantity { get; set; }


		// Relación con categorias (CategoryEntity)
        // Un producto solo tiene una categoria
        public string CategoryId { get; set; }
		// Traemes toda la categoria
		public CategoryEntity Category { get; set; }
		

		// Relación con almacenamiento (StorageEntity)
		// Un producto puede estar en muchas lineas de almacenamiento
		public ICollection<StorageEntity> Storages { get; set; }
	}
}
