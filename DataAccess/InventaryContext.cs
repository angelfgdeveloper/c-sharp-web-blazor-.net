using Microsoft.EntityFrameworkCore;
using Entities;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    // Conexion a la DB
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; } // Relacion de la tabla Product
        public DbSet<CategoryEntity> Categories { get; set; } // Relacion a la tabla Category
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured) // Sino esta configurado
            {
                //options.UseSqlServer("Data Source=(local)\\;Initial Catalog=TareasDB;user id=nombreUsuario;password=contrasenia");
                // options.UseSqlServer("Server=(local)\\; Database=InventoryDB;User Id=nombreUsuario; Password=contrasenia");

                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile("appsettings.json").Build();

                options.UseSqlServer(configuration.GetConnectionString("Local"));
                // 1. Package Manager Console => Terminal
                // 2. Default project => DataAccess
                // 3. Crear el proyecto de migracion => add-migration FirstMigration
                // 4. Agregar en Nuget => tools
                // 5. Colocar como proyecto de inicio => Seleccionar DataAccess, clic y seleccionar Set as Startup Project
            }
        }

        // Pre-cargar datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Categorias
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumería" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }
            );

            // Bodegas
            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Central", WarehouseAddress = "Calle 8 con 23" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Norte", WarehouseAddress = "Calle norte con occidente" }
            );

            // Productos
            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity { ProductId = "ASJ-98745", ProductName = "Crema para manos marca Tersa", ProductDescription = "", CategoryId = "PRF" },
                new ProductEntity { ProductId = "RPT-546587", ProductName = "Pastillas para la garganta LESUS", ProductDescription = "", CategoryId = "SLD" }
            );

            // Agregar a la DB Sqlserver
            // 1. Abrir Terminal => Package Manager Console
            // 2. update-database
            // 3. Hacer migracion para agregar los datos en DB => add-migration AddData
            // 4. Volvemos a actualizar con => update-database
        }
    }
}
