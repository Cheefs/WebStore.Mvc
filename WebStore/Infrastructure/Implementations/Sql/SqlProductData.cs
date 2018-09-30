﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebStore.DAL.Context;
using WebStore.DomainNew.Entities;
using WebStore.DomainNew.Filters;
using WebStore.Infrastructure.Interfaces;


namespace WebStore.Infrastructure.Implementations.Sql
{
    public class SqlProductData : IProductData
    {
        private readonly WebStoreContext _context;

        public SqlProductData(WebStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Section> GetSections()
        {
            return _context.Sections.ToList();
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var query = _context.Products.Include("Brand").Include("Section").AsQueryable();

            if (filter.Ids != null && filter.Ids.Count > 0)
            {
                query = query.Where(c => filter.Ids.Contains(c.Id));
            }
            if (filter.BrandId.HasValue)
                query = query.Where(c => c.BrandId.HasValue && c.BrandId.Value.Equals(filter.BrandId.Value));
            if (filter.SectionId.HasValue)
                query = query.Where(c => c.SectionId.Equals(filter.SectionId.Value));
            return query.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Include("Brand").Include("Section").FirstOrDefault(p => p.Id.Equals(id));
        }

        public void Edit()
        {
            using (var trans = _context.Database.BeginTransaction())
            {

                trans.Commit();
            }
        }

        public void AddNew(Product model)
        {
            using (var trans = _context.Database.BeginTransaction())
            {
                _context.Products.Add(model);           
                _context.SaveChanges();
                trans.Commit();
            }
        }

        public void Delete(int id)
        {
            using (var trans = _context.Database.BeginTransaction())
            {
                var product = GetProductById(id);
                _context.Remove(product);
                _context.SaveChanges();
                trans.Commit();
            }
        }
    }
}

