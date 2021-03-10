using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ONC.RESTful.Entities.Obra;

namespace ONC.RESTful.Data.EF6
{
    //DbContext generalmente representa una conexión de base de datos y un conjunto de tablas. 
    public partial class ApiDbContext : DbContext
    {
        public ApiDbContext() : base("name=ApiDbContext")
        {
            // Database.SetInitializer<ApiDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.HasDefaultSchema("API");
        }
        /// DbSet Artist se utiliza para representar una tabla.
        public virtual DbSet<ActaInicioObra> ActaInicioObra { get; set; }

        /// DbSet Product se utiliza para representar una tabla.
        public virtual DbSet<AmpliacionAdicional> AmpliacionAdicional { get; set; }

        /// DbSet Product se utiliza para representar una tabla.
        public virtual DbSet<AnticipoFinanciero> AnticipoFinanciero { get; set; }

        public virtual DbSet<AvanceFisico> AvanceFisico { get; set; }
        public virtual DbSet<CertificacionAvancePrecioRedeterminado> CertificacionAvancePrecioRedeterminado { get; set; }
        public virtual DbSet<CertificacionAvancePrecioBase> CertificacionAvancePrecioBase { get; set; }
        public virtual DbSet<CertificacionAjusteRedeterminacion> CertificacionAjusteRedeterminacion { get; set; }
        public virtual DbSet<ProrrogaPlazo> ProrrogaPlazo { get; set; }
        public virtual DbSet<PlanTrabajoCurvaCertificacion> PlanTrabajoCurvaCertificacion { get; set; }
        public virtual DbSet<PenalidadSancionAplicada> PenalidadSancionAplicada { get; set; }
        public virtual DbSet<RedeterminacionPrecioTramiteAprobada> RedeterminacionPrecioTramiteAprobada { get; set; }
        public virtual DbSet<ResponsableTecnicoObra> ResponsableTecnicoObra { get; set; }
        public virtual DbSet<SubcontratistaAutorizado> SubcontratistaAutorizado { get; set; }
        public virtual DbSet<SuspensionObra> SuspensionObra { get; set; }
        public virtual DbSet<ApiLog> ApiLog { get; set; }
        


    }
}
