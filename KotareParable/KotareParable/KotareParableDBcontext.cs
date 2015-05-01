namespace KotareParable
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KotareParableDBcontext : DbContext
    {
        // Your context has been configured to use a 'KotareParableDBcontext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'KotareParable.KotareParableDBcontext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'KotareParableDBcontext' 
        // connection string in the application configuration file.
        public KotareParableDBcontext()
            : base("name=KotareParableDBcontext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Narration> Narrations { get; set; }
        public virtual DbSet<Response> Responses { get; set; }
        public virtual DbSet<NtoR> NarrationJoinResponses { get; set; }

    }
}