using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Models;

namespace Find3dPrinting.Data.EF
{
    public class ManufacturersRepository : DataModel<Manufacturer>
    {
            public override void Add(int id)
            {
                base.Add(id);
            }

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
    }
}
