﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find3dPrinting.Models;

namespace Find3dPrinting.Data.EF
{
    public class UsersRepository : Find3dPrintingRepository<User>
    {

        public override void Add(User model)
        {
            base.Add(model);
        }

        public override User GetById(int id)
        {
            return base.GetById(id);
        }

        public override User GetById(int[] id)
        {
            return base.GetById(id);
        }

        public override void Remove(int id)
        {
            base.Remove(id);
        }

        public override void Remove(User model)
        {
            base.Remove(model);
        }

        public override void Update(int id, User newModel)
        {
            base.Update(id, newModel);
        }

        public override void Update(User oldModel, User newModel)
        {
            base.Update(oldModel, newModel);
        }

        public override IList<User> GetAll()
        {
            return base.GetAll();
        }

        public override User GetFirst()
        {
            return base.GetFirst();
        } 
    }
}
