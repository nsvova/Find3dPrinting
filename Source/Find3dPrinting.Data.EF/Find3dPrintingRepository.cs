using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Data.Interfaces;

namespace Find3dPrinting.Data.EF
{
    public abstract class Find3dPrintingRepository<ModelType> : IRepository<ModelType>
        where ModelType : class, new()
    {
        public virtual ModelType GetById(int id)
        {
            using (var context = new Find3dPrintingDBContext())
            {
                return context.Set<ModelType>().Find(id);
            }
        }

        public virtual ModelType GetById(int[] id)
        {
            throw new NotImplementedException();
        }

        public virtual void Add(ModelType model)
        {
            using (var context = new Find3dPrintingDBContext())
            {
                context.Set<ModelType>().Add(model);
                context.SaveChanges();
            }
        }

        public virtual void Remove(ModelType model)
        {
            using (var context = new Find3dPrintingDBContext())
            {
                context.Set<ModelType>().Remove(model);
                context.SaveChanges();
            }
        }

        public virtual void Remove(int id)
        {
            ModelType modelToDelete = this.GetById(id);

            using (var context = new Find3dPrintingDBContext())
            {
                context.Set<ModelType>().Remove(modelToDelete);
                context.SaveChanges();
            }
        }

        public virtual void Update(int id, ModelType newModel)
        {
            throw new NotImplementedException();
        }


        public virtual void Update(ModelType oldModel, ModelType newModel)
        {
            throw new NotImplementedException();
        }


        public virtual ModelType GetFirst()
        {
            return new ModelType();
            using (var context = new Find3dPrintingDBContext())
            {
                return context.Set<ModelType>().First();
            }
        }

        public virtual IList<ModelType> GetAll()
        {
            
            using (var context = new Find3dPrintingDBContext())
            {
                return context.Set<ModelType>().ToList();
            }
             
        }
    }
}
