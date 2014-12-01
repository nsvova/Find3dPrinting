using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Models;

namespace Find3dPrinting.Data.EF
{
    public class DeliveriesRepository : Find3dPrintingRepository<Delivery>
    {

        public override void Add(Delivery model)
        {
            base.Add(model);
        }

        public override Delivery GetById(int id)
        {
            return base.GetById(id);
        }

        public override Delivery GetById(int[] id)
        {
            return base.GetById(id);
        }

        public override void Remove(int id)
        {
            base.Remove(id);
        }

        public override void Remove(Delivery model)
        {
            base.Remove(model);
        }

        public override void Update(int id, Delivery newModel)
        {
            base.Update(id, newModel);
        }

        public override void Update(Delivery oldModel, Delivery newModel)
        {
            base.Update(oldModel, newModel);
        }

        public override IList<Delivery> GetAll()
        {
            return base.GetAll();
        }

        public override Delivery GetFirst()
        {
            return base.GetFirst();
        } 

    }
}
