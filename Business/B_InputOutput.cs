using DataAccess;
using Entities;

namespace Business
{
    // capa de negocio
    public class B_InputOutput
    {
        public List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInputOutput(InputOutputEntity oInputOutput) // o => objeto
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInputOutput);
                db.SaveChanges(); // Guardar los cambios agregados
            }
        }

        public void UpdateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInputOutput); // Actualizar la entrada-salida
                db.SaveChanges(); // Guardar cambios
            }
        }

        public void DeleteInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Remove(oInputOutput); // Eliminar la entrada-salida
                db.SaveChanges(); // Guardar cambios
            }
        }

    }
}
