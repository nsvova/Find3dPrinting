using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Models;

namespace Find3dPrinting.Data.EF
{
    public class PaymentsRepository : Find3dPrintingRepository<Payment>
    {

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

        public override void Update(Payment oldModel, Payment newModel)
        {
            base.Update(oldModel, newModel);
        }

        public override IList<Payment> GetAll()
        {
            return base.GetAll();
        }

        public override Payment GetFirst()
        {
            return base.GetFirst();
        } 
    }
}
