using curso_asp.Data;
using curso_asp.Models;
using curso_asp.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace curso_asp.UnitOfWork
{
    public class UnityOfWorkApp : DbContext
    {
        ContextApp context = new ContextApp();
        Repository.Repository<Product> productRepository;

        public Repository<Product> ProductRepository 
        { 
            get
            {
                if (productRepository == null)
                { 
                    productRepository = new Repository<Product>(context);
                }
                return productRepository;
            }
        }

        public void Commit()
        {
            context.SaveChanges();

        }
    }


}