using System;
using System.Collections.Generic;

namespace Find3dPrinting.Data.Interfaces
{
    public interface IRepository<ModelType>
    {
        
        ModelType GetById(int id);
        ModelType GetById(int[] id);
        ModelType GetFirst();
        IList<ModelType> GetAll();
        void Add(ModelType model);
        void Remove(ModelType model);
        void Remove(int id);
        void Update(int id, ModelType newModel);
        void Update(ModelType oldModel, ModelType newModel);
    }
}
