using System.ComponentModel.DataAnnotations;

namespace Entities
{
	public class CategoryEntity
	{
		[Key] // Llave primaria (Data Annotations)
		[StringLength(50)] // Tamaño de largo
		public string CategoryId { get; set; }

		[Required] // Campo obligatorio
		[StringLength(100)] // Max. 100 caracteres
		public string CategoryName { get; set; }

		// Relación con productos
		// Una categoria puede estar en muchos productos
		public ICollection<ProductEntity> Products { get; set; }
	}
}
