using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Models;

namespace Find3dPrinting.Data.EF
{
    public class ComputeTechnologiesRepository : DataModel<ComputeTechnology>
    {
        public override void Add(int id)
        {
            base.Add(id);
        }

        public override void Add(ComputeTechnology model)
        {
            base.Add(model);
        }

        public override ComputeTechnology GetById(int id)
        {
            return base.GetById(id);
        }

        public override ComputeTechnology GetById(int[] id)
        {
            return base.GetById(id);
        }

        public override void Remove(int id)
        {
            base.Remove(id);
        }

        public override void Remove(ComputeTechnology model)
        {
            base.Remove(model);
        }

        public override void Update(int id, ComputeTechnology newModel)
        {
            base.Update(id, newModel);
        }
    }
}
