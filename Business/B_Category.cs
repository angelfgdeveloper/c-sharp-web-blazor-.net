using DataAccess;
using Entities;

namespace Business
{
    // Capa de negocio
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }

        public static void CreateCategory(CategoryEntity oCategory) // o => objeto
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges(); // Guardar los cambios agregados
            }
        }

        public static void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(oCategory); // Actualizar la categoria
                db.SaveChanges(); // Guardar cambios
            }
        }

        public static void DeleteCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Remove(oCategory); // Eliminar la categoria
                db.SaveChanges(); // Guardar cambios
            }
        }
    }
}
