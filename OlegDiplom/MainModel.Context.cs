﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OlegDiplom
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OlegTrushDiplomEntities : DbContext
    {
        public OlegTrushDiplomEntities()
            : base("name=OlegTrushDiplomEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GroupCars> GroupCars { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<GroupWorkers> GroupWorkers { get; set; }
        public virtual DbSet<GunModel> GunModel { get; set; }
        public virtual DbSet<Guns> Guns { get; set; }
        public virtual DbSet<GunType> GunType { get; set; }
        public virtual DbSet<LoginData> LoginData { get; set; }
        public virtual DbSet<Marks> Marks { get; set; }
        public virtual DbSet<ModelCars> ModelCars { get; set; }
        public virtual DbSet<Objects> Objects { get; set; }
        public virtual DbSet<ObjectTypes> ObjectTypes { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Prichini> Prichini { get; set; }
        public virtual DbSet<Sostoyanie> Sostoyanie { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<WorkerGun> WorkerGun { get; set; }
        public virtual DbSet<WorkersObjects> WorkersObjects { get; set; }
        public virtual DbSet<CarsView> CarsView { get; set; }
        public virtual DbSet<WorkersInGroupsView> WorkersInGroupsView { get; set; }
        public virtual DbSet<WorkersOnObjectsView> WorkersOnObjectsView { get; set; }
        public virtual DbSet<ObjectsView> ObjectsView { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
        public virtual DbSet<Calls> Calls { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
    }
}
