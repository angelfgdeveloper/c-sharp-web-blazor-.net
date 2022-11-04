using DataAccess;
using Entities;

namespace Business
{
    // Capa de negocio
    public class B_Storage
    {
        public List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public void CreateStorage(StorageEntity oStorage) // o => objeto
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges(); // Guardar los cambios agregados
            }
        }

        public void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage); // Actualizar la storages
                db.SaveChanges(); // Guardar cambios
            }
        }

        public void DeleteStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Remove(oStorage); // Eliminar storages
                db.SaveChanges(); // Guardar cambios
            }
        }

    }
}
