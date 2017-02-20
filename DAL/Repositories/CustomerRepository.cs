﻿using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CustomerRepository : BaseRepository<AspNetUsers>, IRepository<AspNetUsers>
    {
        public CustomerRepository(OnlineStoreEntities3 context)
        {
            this.db = context;
        }

        public void Create(AspNetUsers customer)
        {
            db.AspNetUsers.Add(customer);
        }

        public void Delete(int id)
        {
            AspNetUsers customer = db.AspNetUsers.Find(id);
            if (customer != null)
            {
                db.AspNetUsers.Remove(customer);
            }
        }

        public AspNetUsers Get(int id)
        {
            return db.AspNetUsers.Find(id);
        }

        public IEnumerable<AspNetUsers> GetAll()
        {
            return db.AspNetUsers;
        }

        public void Update(AspNetUsers customer)
        {
            db.Entry(customer).State = EntityState.Modified;
        }

        //public IEnumerable<AspNetUsers> Find(Func<AspNetUsers, bool> predicate)
        //{
        //    throw new NotImplementedException();
        //}
    }
}