using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Models;

namespace Find3dPrinting.Data.EF
{
    public class PrintersRepository : DataModel<Printer>
    {
        public override void Add(int id)
        {
            base.Add(id);
        }

        public override void Add(Printer model)
        {
            base.Add(model);
        }

        public override Printer GetById(int id)
        {
            return base.GetById(id);
        }

        public override Printer GetById(int[] id)
        {
            return base.GetById(id);
        }

        public override void Remove(int id)
        {
            base.Remove(id);
        }

        public override void Remove(Printer model)
        {
            base.Remove(model);
        }

        public override void Update(int id, Printer newModel)
        {
            base.Update(id, newModel);
        }
    }
}
