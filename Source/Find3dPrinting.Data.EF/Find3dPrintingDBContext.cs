

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "Find3dPrinting\Web.config"
//     Connection String Name: "MyDbContext"
//     Connection String:      "Data Source=(localdb)\ProjectsV12;Initial Catalog=Find3dPrintingDB;Integrated Security=true"

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Find3dPrinting.Models;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Find3dPrinting.Data.EF
{
    // ************************************************************************
    // Unit of work
    /*public interface IMyDbContext : IDisposable
    {
        IDbSet<BoxSize> BoxSizes { get; set; } // BoxSizes
        IDbSet<ComputeTechnology> ComputeTechnologies { get; set; } // ComputeTechnologies
        IDbSet<Delivery> Deliveries { get; set; } // Delivery
        IDbSet<DeliveryManufacturers> DeliveryManufacturers { get; set; } // Delivery_Manufacturers
        IDbSet<Manufacturer> Manufacturers { get; set; } // Manufacturers
        IDbSet<ManufacturersPrinters> ManufacturersPrinters { get; set; } // Manufacturers_Printers
        IDbSet<ManufacturersServices> ManufacturersServices { get; set; } // Manufacturers_Services
        IDbSet<Material> Materials { get; set; } // Materials
        IDbSet<Payment> Payments { get; set; } // Payments
        IDbSet<PaymentsManufacturers> PaymentsManufacturers { get; set; } // Payments_Manufacturers
        IDbSet<Printer> Printers { get; set; } // Printers
        IDbSet<Service> Services { get; set; } // Services
        IDbSet<User> Users { get; set; } // Users

        int SaveChanges();
    }*/

    // ************************************************************************
    // Database context
    public class Find3dPrintingDBContext : DbContext
    {
        public IDbSet<BoxSize> BoxSizes { get; set; } // BoxSizes
        public IDbSet<ComputeTechnology> ComputeTechnologies { get; set; } // ComputeTechnologies
        public IDbSet<Delivery> Deliveries { get; set; } // Delivery
        public IDbSet<DeliveryManufacturers> DeliveryManufacturers { get; set; } // Delivery_Manufacturers
        public IDbSet<Manufacturer> Manufacturers { get; set; } // Manufacturers
        public IDbSet<ManufacturersPrinters> ManufacturersPrinters { get; set; } // Manufacturers_Printers
        public IDbSet<ManufacturersServices> ManufacturersServices { get; set; } // Manufacturers_Services
        public IDbSet<Material> Materials { get; set; } // Materials
        public IDbSet<Payment> Payments { get; set; } // Payments
        public IDbSet<PaymentsManufacturers> PaymentsManufacturers { get; set; } // Payments_Manufacturers
        public IDbSet<Printer> Printers { get; set; } // Printers
        public IDbSet<Service> Services { get; set; } // Services
        public IDbSet<User> Users { get; set; } // Users

        public Find3dPrintingDBContext()
            : base("Name=Find3dPrintingDBContext")
        {
        }

        public Find3dPrintingDBContext(string connectionString)
            : base(connectionString)
        {
        }

        public Find3dPrintingDBContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BoxSizeConfiguration());
            modelBuilder.Configurations.Add(new ComputeTechnologyConfiguration());
            modelBuilder.Configurations.Add(new DeliveryConfiguration());
            modelBuilder.Configurations.Add(new DeliveryManufacturersConfiguration());
            modelBuilder.Configurations.Add(new ManufacturerConfiguration());
            modelBuilder.Configurations.Add(new ManufacturersPrintersConfiguration());
            modelBuilder.Configurations.Add(new ManufacturersServicesConfiguration());
            modelBuilder.Configurations.Add(new MaterialConfiguration());
            modelBuilder.Configurations.Add(new PaymentConfiguration());
            modelBuilder.Configurations.Add(new PaymentsManufacturersConfiguration());
            modelBuilder.Configurations.Add(new PrinterConfiguration());
            modelBuilder.Configurations.Add(new ServiceConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new BoxSizeConfiguration(schema));
            modelBuilder.Configurations.Add(new ComputeTechnologyConfiguration(schema));
            modelBuilder.Configurations.Add(new DeliveryConfiguration(schema));
            modelBuilder.Configurations.Add(new DeliveryManufacturersConfiguration(schema));
            modelBuilder.Configurations.Add(new ManufacturerConfiguration(schema));
            modelBuilder.Configurations.Add(new ManufacturersPrintersConfiguration(schema));
            modelBuilder.Configurations.Add(new ManufacturersServicesConfiguration(schema));
            modelBuilder.Configurations.Add(new MaterialConfiguration(schema));
            modelBuilder.Configurations.Add(new PaymentConfiguration(schema));
            modelBuilder.Configurations.Add(new PaymentsManufacturersConfiguration(schema));
            modelBuilder.Configurations.Add(new PrinterConfiguration(schema));
            modelBuilder.Configurations.Add(new ServiceConfiguration(schema));
            modelBuilder.Configurations.Add(new UserConfiguration(schema));
            return modelBuilder;
        }
    }

    // ************************************************************************
    // Fake Database context
    /*
    public class FakeMyDbContext : IMyDbContext
    {
        public IDbSet<BoxSize> BoxSizes { get; set; }
        public IDbSet<ComputeTechnology> ComputeTechnologies { get; set; }
        public IDbSet<Delivery> Deliveries { get; set; }
        public IDbSet<DeliveryManufacturers> DeliveryManufacturers { get; set; }
        public IDbSet<Manufacturer> Manufacturers { get; set; }
        public IDbSet<ManufacturersPrinters> ManufacturersPrinters { get; set; }
        public IDbSet<ManufacturersServices> ManufacturersServices { get; set; }
        public IDbSet<Material> Materials { get; set; }
        public IDbSet<Payment> Payments { get; set; }
        public IDbSet<PaymentsManufacturers> PaymentsManufacturers { get; set; }
        public IDbSet<Printer> Printers { get; set; }
        public IDbSet<Service> Services { get; set; }
        public IDbSet<User> Users { get; set; }

        public FakeMyDbContext()
        {
            BoxSizes = new FakeDbSet<BoxSize>();
            ComputeTechnologies = new FakeDbSet<ComputeTechnology>();
            Deliveries = new FakeDbSet<Delivery>();
            DeliveryManufacturers = new FakeDbSet<DeliveryManufacturers>();
            Manufacturers = new FakeDbSet<Manufacturer>();
            ManufacturersPrinters = new FakeDbSet<ManufacturersPrinters>();
            ManufacturersServices = new FakeDbSet<ManufacturersServices>();
            Materials = new FakeDbSet<Material>();
            Payments = new FakeDbSet<Payment>();
            PaymentsManufacturers = new FakeDbSet<PaymentsManufacturers>();
            Printers = new FakeDbSet<Printer>();
            Services = new FakeDbSet<Service>();
            Users = new FakeDbSet<User>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException(); 
        }
    }
    */
    // ************************************************************************
    // Fake DbSet
    /*
    public class FakeDbSet<T> : IDbSet<T> where T : class
    {
        private readonly HashSet<T> _data;

        public FakeDbSet()
        {
            _data = new HashSet<T>();
        }

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public T Add(T item)
        {
            _data.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Attach(T item)
        {
            _data.Add(item);
            return item;
        }

        public void Detach(T item)
        {
            _data.Remove(item);
        }

        Type IQueryable.ElementType
        {
            get { return _data.AsQueryable().ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return _data.AsQueryable().Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return _data.AsQueryable().Provider; }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public ObservableCollection<T> Local
        {
            get
            {
                return new ObservableCollection<T>(_data);
            }
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }
    }
    */
    // ************************************************************************
    // POCO classes
    /*
    // BoxSizes
    public class BoxSize
    {
        public long BoxSizesId { get; set; } // BoxSizes_id (Primary key)
        public float XDimmSize { get; set; } // X_dimm_size
        public float YDimmSize { get; set; } // Y_dimm_size
        public float ZDimmSize { get; set; } // Z_dimm_size
        public float ScallingRatio { get; set; } // ScallingRatio

        // Reverse navigation
        public virtual ICollection<Printer> Printers { get; set; } // Printers.FK_Printers_BoxSizes

        public BoxSize()
        {
            Printers = new List<Printer>();
        }
    }

    // ComputeTechnologies
    public class ComputeTechnology
    {
        public long ComputeTechnologiesId { get; set; } // ComputeTechnologies_id (Primary key)
        public string ComputeTechnology_ { get; set; } // ComputeTechnology

        // Reverse navigation
        public virtual ICollection<Printer> Printers { get; set; } // Printers.FK_Printers_ComputeTechnologies

        public ComputeTechnology()
        {
            Printers = new List<Printer>();
        }
    }

    // Delivery
    public class Delivery
    {
        public long DeliveryId { get; set; } // Delivery_id (Primary key)
        public string ShippingMethod { get; set; } // ShippingMethod

        // Reverse navigation
        public virtual ICollection<DeliveryManufacturers> DeliveryManufacturers { get; set; } // Delivery_Manufacturers.FK_Delivery_Manufacturers_Delivery

        public Delivery()
        {
            DeliveryManufacturers = new List<DeliveryManufacturers>();
        }
    }

    // Delivery_Manufacturers
    public class DeliveryManufacturers
    {
        public long DeliveryManufacturersId { get; set; } // Delivery_Manufacturers_id (Primary key)
        public long DeliveryId { get; set; } // Delivery_id
        public long ManufacturerId { get; set; } // Manufacturer_id

        // Foreign keys
        public virtual Delivery Delivery { get; set; } // FK_Delivery_Manufacturers_Delivery
        public virtual Manufacturer Manufacturer { get; set; } // FK_Delivery_Manufacturers_Manufacturers
    }

    // Manufacturers
    public class Manufacturer
    {
        public long ManufacturersId { get; set; } // Manufacturers_id (Primary key)
        public string OrganizationName { get; set; } // OrganizationName
        public long UserId { get; set; } // User_id

        // Reverse navigation
        public virtual ICollection<DeliveryManufacturers> DeliveryManufacturers { get; set; } // Delivery_Manufacturers.FK_Delivery_Manufacturers_Manufacturers
        public virtual ICollection<ManufacturersPrinters> ManufacturersPrinters { get; set; } // Manufacturers_Printers.FK_Manufacturers_Printers_Manufacturers
        public virtual ICollection<PaymentsManufacturers> PaymentsManufacturers { get; set; } // Payments_Manufacturers.FK_Payments_Manufacturers_Manufacturers
        public virtual ManufacturersServices ManufacturersServices { get; set; } // Manufacturers_Services.FK_Manufacturers_Services_Manufacturers

        // Foreign keys
        public virtual User User { get; set; } // FK_Manufacturers_Users

        public Manufacturer()
        {
            DeliveryManufacturers = new List<DeliveryManufacturers>();
            ManufacturersPrinters = new List<ManufacturersPrinters>();
            PaymentsManufacturers = new List<PaymentsManufacturers>();
        }
    }

    // Manufacturers_Printers
    public class ManufacturersPrinters
    {
        public long ManufacturersPrintersId { get; set; } // Manufacturers_Printers_id (Primary key)
        public long ManufacturerId { get; set; } // Manufacturer_id
        public long PrinterId { get; set; } // Printer_id

        // Foreign keys
        public virtual Manufacturer Manufacturer { get; set; } // FK_Manufacturers_Printers_Manufacturers
        public virtual Printer Printer { get; set; } // FK_Manufacturers_Printers_Printers
    }

    // Manufacturers_Services
    public class ManufacturersServices
    {
        public long ManufacturersServicesId { get; set; } // Manufacturers_Services_id (Primary key)
        public long ManufacturerId { get; set; } // Manufacturer_id
        public long ServiceId { get; set; } // Service_id

        // Foreign keys
        public virtual Service Service { get; set; } // FK_Manufacturers_Services_Services
    }

    // Materials
    public class Material
    {
        public long MaterialsId { get; set; } // Materials_id (Primary key)
        public string Material_ { get; set; } // Material

        // Reverse navigation
        public virtual ICollection<Printer> Printers { get; set; } // Printers.FK_Printers_Materials

        public Material()
        {
            Printers = new List<Printer>();
        }
    }

    // Payments
    public class Payment
    {
        public long PaymentsId { get; set; } // Payments_id (Primary key)
        public string PaymentMethod { get; set; } // PaymentMethod

        // Reverse navigation
        public virtual ICollection<PaymentsManufacturers> PaymentsManufacturers { get; set; } // Payments_Manufacturers.FK_Payments_Manufacturers_Payments

        public Payment()
        {
            PaymentsManufacturers = new List<PaymentsManufacturers>();
        }
    }

    // Payments_Manufacturers
    public class PaymentsManufacturers
    {
        public long PaymentsManufacturersId { get; set; } // Payments_Manufacturers_id (Primary key)
        public long PaymentId { get; set; } // Payment_id
        public long ManufacturerId { get; set; } // Manufacturer_id

        // Foreign keys
        public virtual Manufacturer Manufacturer { get; set; } // FK_Payments_Manufacturers_Manufacturers
        public virtual Payment Payment { get; set; } // FK_Payments_Manufacturers_Payments
    }

    // Printers
    public class Printer
    {
        public long PrintersId { get; set; } // Printers_id (Primary key)
        public int NozzleThickness { get; set; } // NozzleThickness
        public string PrinterName { get; set; } // PrinterName
        public long BoxSizeId { get; set; } // BoxSize_id
        public long MaterialId { get; set; } // Material_id
        public long ComputeTechnologyId { get; set; } // ComputeTechnology_id

        // Reverse navigation
        public virtual ICollection<ManufacturersPrinters> ManufacturersPrinters { get; set; } // Manufacturers_Printers.FK_Manufacturers_Printers_Printers

        // Foreign keys
        public virtual BoxSize BoxSize { get; set; } // FK_Printers_BoxSizes
        public virtual ComputeTechnology ComputeTechnology { get; set; } // FK_Printers_ComputeTechnologies
        public virtual Material Material { get; set; } // FK_Printers_Materials

        public Printer()
        {
            ManufacturersPrinters = new List<ManufacturersPrinters>();
        }
    }

    // Services
    public class Service
    {
        public long ServicesId { get; set; } // Services_id (Primary key)
        public string ServiceName { get; set; } // ServiceName

        // Reverse navigation
        public virtual ManufacturersServices ManufacturersServices { get; set; } // Manufacturers_Services.FK_Manufacturers_Services_Services
    }

    // Users
    public class User
    {
        public long UsersId { get; set; } // Users_id (Primary key)
        public string Email { get; set; } // Email
        public string Password { get; set; } // Password
        public string PhoneNumber { get; set; } // PhoneNumber

        // Reverse navigation
        public virtual Manufacturer Manufacturer { get; set; } // Manufacturers.FK_Manufacturers_Users
    }
    */

    // ************************************************************************
    // POCO Configuration

    // BoxSizes
    internal class BoxSizeConfiguration : EntityTypeConfiguration<BoxSize>
    {
        public BoxSizeConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".BoxSizes");
            HasKey(x => x.BoxSizesId);

            Property(x => x.BoxSizesId).HasColumnName("BoxSizes_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.XDimmSize).HasColumnName("X_dimm_size").IsRequired();
            Property(x => x.YDimmSize).HasColumnName("Y_dimm_size").IsRequired();
            Property(x => x.ZDimmSize).HasColumnName("Z_dimm_size").IsRequired();
            Property(x => x.ScallingRatio).HasColumnName("ScallingRatio").IsRequired();
        }
    }

    // ComputeTechnologies
    internal class ComputeTechnologyConfiguration : EntityTypeConfiguration<ComputeTechnology>
    {
        public ComputeTechnologyConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ComputeTechnologies");
            HasKey(x => x.ComputeTechnologiesId);

            Property(x => x.ComputeTechnologiesId).HasColumnName("ComputeTechnologies_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ComputeTechnology_).HasColumnName("ComputeTechnology").IsRequired().IsUnicode(false).HasMaxLength(300);
        }
    }

    // Delivery
    internal class DeliveryConfiguration : EntityTypeConfiguration<Delivery>
    {
        public DeliveryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Delivery");
            HasKey(x => x.DeliveryId);

            Property(x => x.DeliveryId).HasColumnName("Delivery_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ShippingMethod).HasColumnName("ShippingMethod").IsRequired().IsUnicode(false).HasMaxLength(300);
        }
    }

    // Delivery_Manufacturers
    internal class DeliveryManufacturersConfiguration : EntityTypeConfiguration<DeliveryManufacturers>
    {
        public DeliveryManufacturersConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Delivery_Manufacturers");
            HasKey(x => x.DeliveryManufacturersId);

            Property(x => x.DeliveryManufacturersId).HasColumnName("Delivery_Manufacturers_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DeliveryId).HasColumnName("Delivery_id").IsRequired();
            Property(x => x.ManufacturerId).HasColumnName("Manufacturer_id").IsRequired();

            // Foreign keys
            HasRequired(a => a.Delivery).WithMany(b => b.DeliveryManufacturers).HasForeignKey(c => c.DeliveryId); // FK_Delivery_Manufacturers_Delivery
            HasRequired(a => a.Manufacturer).WithMany(b => b.DeliveryManufacturers).HasForeignKey(c => c.ManufacturerId); // FK_Delivery_Manufacturers_Manufacturers
        }
    }

    // Manufacturers
    internal class ManufacturerConfiguration : EntityTypeConfiguration<Manufacturer>
    {
        public ManufacturerConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Manufacturers");
            HasKey(x => x.ManufacturersId);

            Property(x => x.ManufacturersId).HasColumnName("Manufacturers_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.OrganizationName).HasColumnName("OrganizationName").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.UserId).HasColumnName("User_id").IsRequired();

            // Foreign keys
            HasRequired(a => a.User).WithOptional(b => b.Manufacturer); // FK_Manufacturers_Users
        }
    }

    // Manufacturers_Printers
    internal class ManufacturersPrintersConfiguration : EntityTypeConfiguration<ManufacturersPrinters>
    {
        public ManufacturersPrintersConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Manufacturers_Printers");
            HasKey(x => x.ManufacturersPrintersId);

            Property(x => x.ManufacturersPrintersId).HasColumnName("Manufacturers_Printers_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ManufacturerId).HasColumnName("Manufacturer_id").IsRequired();
            Property(x => x.PrinterId).HasColumnName("Printer_id").IsRequired();

            // Foreign keys
            HasRequired(a => a.Manufacturer).WithMany(b => b.ManufacturersPrinters).HasForeignKey(c => c.ManufacturerId); // FK_Manufacturers_Printers_Manufacturers
            HasRequired(a => a.Printer).WithMany(b => b.ManufacturersPrinters).HasForeignKey(c => c.PrinterId); // FK_Manufacturers_Printers_Printers
        }
    }

    // Manufacturers_Services
    internal class ManufacturersServicesConfiguration : EntityTypeConfiguration<ManufacturersServices>
    {
        public ManufacturersServicesConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Manufacturers_Services");
            HasKey(x => x.ManufacturersServicesId);

            Property(x => x.ManufacturersServicesId).HasColumnName("Manufacturers_Services_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ManufacturerId).HasColumnName("Manufacturer_id").IsRequired();
            Property(x => x.ServiceId).HasColumnName("Service_id").IsRequired();

            // Foreign keys
            HasRequired(a => a.Service).WithOptional(b => b.ManufacturersServices); // FK_Manufacturers_Services_Services
        }
    }

    // Materials
    internal class MaterialConfiguration : EntityTypeConfiguration<Material>
    {
        public MaterialConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Materials");
            HasKey(x => x.MaterialsId);

            Property(x => x.MaterialsId).HasColumnName("Materials_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Material_).HasColumnName("Material").IsRequired().IsUnicode(false).HasMaxLength(300);
        }
    }

    // Payments
    internal class PaymentConfiguration : EntityTypeConfiguration<Payment>
    {
        public PaymentConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Payments");
            HasKey(x => x.PaymentsId);

            Property(x => x.PaymentsId).HasColumnName("Payments_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PaymentMethod).HasColumnName("PaymentMethod").IsRequired().IsUnicode(false).HasMaxLength(300);
        }
    }

    // Payments_Manufacturers
    internal class PaymentsManufacturersConfiguration : EntityTypeConfiguration<PaymentsManufacturers>
    {
        public PaymentsManufacturersConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Payments_Manufacturers");
            HasKey(x => x.PaymentsManufacturersId);

            Property(x => x.PaymentsManufacturersId).HasColumnName("Payments_Manufacturers_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PaymentId).HasColumnName("Payment_id").IsRequired();
            Property(x => x.ManufacturerId).HasColumnName("Manufacturer_id").IsRequired();

            // Foreign keys
            HasRequired(a => a.Payment).WithMany(b => b.PaymentsManufacturers).HasForeignKey(c => c.PaymentId); // FK_Payments_Manufacturers_Payments
            HasRequired(a => a.Manufacturer).WithMany(b => b.PaymentsManufacturers).HasForeignKey(c => c.ManufacturerId); // FK_Payments_Manufacturers_Manufacturers
        }
    }

    // Printers
    internal class PrinterConfiguration : EntityTypeConfiguration<Printer>
    {
        public PrinterConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Printers");
            HasKey(x => x.PrintersId);

            Property(x => x.PrintersId).HasColumnName("Printers_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.NozzleThickness).HasColumnName("NozzleThickness").IsRequired();
            Property(x => x.PrinterName).HasColumnName("PrinterName").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.BoxSizeId).HasColumnName("BoxSize_id").IsRequired();
            Property(x => x.MaterialId).HasColumnName("Material_id").IsRequired();
            Property(x => x.ComputeTechnologyId).HasColumnName("ComputeTechnology_id").IsRequired();

            // Foreign keys
            HasRequired(a => a.BoxSize).WithMany(b => b.Printers).HasForeignKey(c => c.BoxSizeId); // FK_Printers_BoxSizes
            HasRequired(a => a.Material).WithMany(b => b.Printers).HasForeignKey(c => c.MaterialId); // FK_Printers_Materials
            HasRequired(a => a.ComputeTechnology).WithMany(b => b.Printers).HasForeignKey(c => c.ComputeTechnologyId); // FK_Printers_ComputeTechnologies
        }
    }

    // Services
    internal class ServiceConfiguration : EntityTypeConfiguration<Service>
    {
        public ServiceConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Services");
            HasKey(x => x.ServicesId);

            Property(x => x.ServicesId).HasColumnName("Services_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ServiceName).HasColumnName("ServiceName").IsOptional().IsUnicode(false).HasMaxLength(300);
        }
    }

    // Users
    internal class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Users");
            HasKey(x => x.UsersId);

            Property(x => x.UsersId).HasColumnName("Users_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Email).HasColumnName("Email").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Password).HasColumnName("Password").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").IsRequired().IsUnicode(false).HasMaxLength(150);
        }
    }

}

