using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Find3dPrinting.Models;
using Find3dPrinting.Data.EF;
using Find3dPrinting.Data.Interfaces;


namespace Find3dPrinting.Data.DI
{
    public class Find3dPrintingBinding : NinjectModule
    {

        public override void Load()
        {
            this.Bind<IRepository<User>>().To<UsersRepository>();
            this.Bind<IRepository<BoxSize>>().To<BoxSizesRepository>();
            this.Bind<IRepository<ComputeTechnology>>().To<ComputeTechnologiesRepository>();
            this.Bind<IRepository<Delivery>>().To<DeliveriesRepository>();
            this.Bind<IRepository<Manufacturer>>().To<ManufacturersRepository>();
            this.Bind<IRepository<Material>>().To<MaterialsRepository>();
            this.Bind<IRepository<Payment>>().To<PaymentsRepository>();
            this.Bind<IRepository<Printer>>().To<PrintersRepository>();
            this.Bind<IRepository<Service>>().To<ServicesRepository>();
        }

    }
}
