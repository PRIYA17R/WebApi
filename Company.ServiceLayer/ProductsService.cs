﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Company.ServiceContracts;
using Company.DataLayer;
using Company.DomainModels;
using Company.Repository.Contracts;
using Company.RepositoryLayer;

namespace Company.ServiceLayer
{
    public class ProductsService : IProductsService
    {
         IProductsRepository prodRep;

        public ProductsService(IProductsRepository r)
        {
            this.prodRep =r;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = prodRep.GetProducts();
            return products;
        }

        public List<Product> SearchProducts(string ProductName)
        {
            List<Product> products = prodRep.SearchProducts(ProductName);
            return products;
        }

        public Product GetProductByProductID(long ProductID)
        {
          Product p=   prodRep.GetProductByProductID(ProductID);
            return p;
          
        }
        public void InertProduct(Product p)
        {
            prodRep.InertProduct(p);
        }
        public void UpdateProduct(Product p)
        {

            prodRep.UpdateProduct(p);
        }
        public void DeleteProduct(long ProductID)
        {
            prodRep.DeleteProduct(ProductID);
        }
    }
}


