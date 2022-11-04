using DataAccess;
using Entities;

namespace Business
{
    // Capa de negocio
    public class B_Warehouse
    {
        public List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public void CreateWarehouse(WarehouseEntity oWarehouse) // o => objeto
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges(); // Guardar los cambios agregados
            }
        }

        public void UpdateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(oWarehouse); // Actualizar el almacen
                db.SaveChanges(); // Guardar cambios
            }
        }

        public void DeleteWarehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Remove(oWarehouse); // Eliminar el almacen
                db.SaveChanges(); // Guardar cambios
            }
        }

    }
}
