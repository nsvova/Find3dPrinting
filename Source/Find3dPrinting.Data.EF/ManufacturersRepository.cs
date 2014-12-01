using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Models;

namespace Find3dPrinting.Data.EF
{
    public class ManufacturersRepository : Find3dPrintingRepository<Manufacturer>
    {

            public override void Add(Manufacturer model)
            {
                base.Add(model);
            }

            public override Manufacturer GetById(int id)
            {
                return base.GetById(id);
            }

            public override Manufacturer GetById(int[] id)
            {
                return base.GetById(id);
            }

            public override void Remove(int id)
            {
                base.Remove(id);
            }

            public override void Remove(Manufacturer model)
            {
                base.Remove(model);
            }

            public override void Update(int id, Manufacturer newModel)
            {
                base.Update(id, newModel);
            }

            public override void Update(Manufacturer oldModel, Manufacturer newModel)
            {
                base.Update(oldModel, newModel);
            }

            public override IList<Manufacturer> GetAll()
            {
                return base.GetAll();
            }

            public override Manufacturer GetFirst()
            {
                return base.GetFirst();
            } 
           
    }
}
