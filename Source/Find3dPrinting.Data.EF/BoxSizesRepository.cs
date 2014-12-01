using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Models;

namespace Find3dPrinting.Data.EF
{
    public class BoxSizesRepository : Find3dPrintingRepository<BoxSize>
    {

        public override void Add(BoxSize model)
        {
            base.Add(model);
        }

        public override BoxSize GetById(int id)
        {
            return base.GetById(id);
        }

        public override BoxSize GetById(int[] id)
        {
            return base.GetById(id);
        }

        public override void Remove(int id)
        {
            base.Remove(id);
        }

        public override void Remove(BoxSize model)
        {
            base.Remove(model);
        }

        public override void Update(int id, BoxSize newModel)
        {
            base.Update(id, newModel);
        }

        public override void Update(BoxSize oldModel, BoxSize newModel)
        {
            base.Update(oldModel, newModel);
        }

        public override IList<BoxSize> GetAll()
        {
            return base.GetAll();
        }

        public override BoxSize GetFirst()
        {
            return base.GetFirst();
        } 

    }
}
