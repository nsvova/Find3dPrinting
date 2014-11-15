using System;

namespace Find3dPrinting.Data.Interfaces
{
    public interface IDataModel<ModelType>
    {
        ModelType GetById(int id);
        ModelType GetById(int[] id);
        void Add(ModelType model);
        void Add(int id);
        void Remove(ModelType model);
        void Remove(int id);
        void Update(int id, ModelType newModel);
    }
}
