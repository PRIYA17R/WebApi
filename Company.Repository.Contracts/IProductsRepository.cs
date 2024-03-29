﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;

namespace Company.Repository.Contracts
{
    public interface IProductsRepository
    {
        List<Product> GetProducts();
        List<Product> SearchProducts(string ProductName);
        Product GetProductByProductID(long ProductID);
        void InertProduct(Product p);
        void UpdateProduct(Product p);
        void DeleteProduct(long ProductID);
    }
}
