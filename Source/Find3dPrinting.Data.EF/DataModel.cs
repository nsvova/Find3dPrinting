using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Data.Interfaces;

namespace Find3dPrinting.Data.EF
{
    public abstract class DataModel<ModelType> : IDataModel<ModelType>
    {
        public virtual ModelType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual ModelType GetById(int[] id)
        {
            throw new NotImplementedException();
        }

        public virtual void Add(ModelType model)
        {
            throw new NotImplementedException();
        }

        public virtual void Add(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(ModelType model)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(int id, ModelType newModel)
        {
            throw new NotImplementedException();
        }
    }
}
