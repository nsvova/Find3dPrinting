﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Models;

namespace Find3dPrinting.Data.EF
{
    public class MaterialsRepository : Find3dPrintingRepository<Material>
    {


        public override void Add(Material model)
        {
            base.Add(model);
        }

        public override Material GetById(int id)
        {
            return base.GetById(id);
        }

        public override Material GetById(int[] id)
        {
            return base.GetById(id);
        }

        public override void Remove(int id)
        {
            base.Remove(id);
        }

        public override void Remove(Material model)
        {
            base.Remove(model);
        }

        public override void Update(int id, Material newModel)
        {
            base.Update(id, newModel);
        }

        public override void Update(Material oldModel, Material newModel)
        {
            base.Update(oldModel, newModel);
        }

        public override IList<Material> GetAll()
        {
            return base.GetAll();
        }

        public override Material GetFirst()
        {
            return base.GetFirst();
        } 
    }
}
