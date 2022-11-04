using DataAccess;
using Entities;

namespace Business
{
    // Capa de negocio
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public static void CreateProduct(ProductEntity oProduct) // o => objeto
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges(); // Guardar los cambios agregados
            }
        }

        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(oProduct); // Actualizar el product
                db.SaveChanges(); // Guardar cambios
            }
        }

        public static void DeleteProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Remove(oProduct); // Eliminar el product
                db.SaveChanges(); // Guardar cambios
            }
        }

    }
}
