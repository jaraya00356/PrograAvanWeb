﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace BE.DAL.Repository
{
    interface IRepository<T> where T:class
    {
        IQueryable<T> AsQueryble();
        IEnumerable<T> GetAll();
        IEnumerable<T> Search(Expression<Func<T, bool>> predicado);
        T GetOne(Expression<Func<T, bool>> predicado);
        T GetOnebyID(int id);
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        void Commit();
        void AddRange(IEnumerable<T> t);
        void UpdateRange(IEnumerable<T> t);
        void RemoveRange(IEnumerable<T> t);
    }
}
