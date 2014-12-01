using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Models;

namespace Find3dPrinting.Data.EF
{
    public class ServicesRepository : Find3dPrintingRepository<Service>
    {

        public override void Add(Service model)
        {
            base.Add(model);
        }

        public override Service GetById(int id)
        {
            return base.GetById(id);
        }

        public override Service GetById(int[] id)
        {
            return base.GetById(id);
        }

        public override void Remove(int id)
        {
            base.Remove(id);
        }

        public override void Remove(Service model)
        {
            base.Remove(model);
        }

        public override void Update(int id, Service newModel)
        {
            base.Update(id, newModel);
        }

        public override void Update(Service oldModel, Service newModel)
        {
            base.Update(oldModel, newModel);
        }

        public override IList<Service> GetAll()
        {
            return base.GetAll();
        }

        public override Service GetFirst()
        {
            return base.GetFirst();
        } 
    }
}
