using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Models;

namespace Find3dPrinting.Data.EF
{
    public class PaymentsRepository : DataModel<Payment>
    {
        public override void Add(int id)
        {
            base.Add(id);
        }

        public override void Add(Payment model)
        {
            base.Add(model);
        }

        public override Payment GetById(int id)
        {
            return base.GetById(id);
        }

        public override Payment GetById(int[] id)
        {
            return base.GetById(id);
        }

        public override void Remove(int id)
        {
            base.Remove(id);
        }

        public override void Remove(Payment model)
        {
            base.Remove(model);
        }

        public override void Update(int id, Payment newModel)
        {
            base.Update(id, newModel);
        }
    }
}
