using System.Collections.Generic;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDAO _productDAO;

        public ProductRepository()
        {
            _productDAO = new ProductDAO();
        }

        public void DeleteProduct(BusinessObjects.Product p) =>
            _productDAO.DeleteProduct(ConvertToDataAccessProduct(p));

        public void SaveProduct(BusinessObjects.Product p) =>
            _productDAO.SaveProduct(ConvertToDataAccessProduct(p));

        public void UpdateProduct(BusinessObjects.Product p) =>
            ProductDAO.UpdateProduct(ConvertToDataAccessProduct(p));

        public List<BusinessObjects.Product> GetProducts() =>
            ConvertToBusinessProductList(_productDAO.GetProducts());

        public BusinessObjects.Product GetProductById(int id) =>
            ConvertToBusinessProduct(_productDAO.GetProductById(id));

        // Helper methods to convert between types
        private DataAccessLayer.Product ConvertToDataAccessProduct(BusinessObjects.Product p)
        {
            if (p == null) return null;

            return new DataAccessLayer.Product
            {
                ProductID = p.ProductId,
                ProductName = p.ProductName,
                CategoryID = p.CategoryId,
                UnitsInStock = p.UnitsInStock,
                UnitPrice = p.UnitPrice
            };
        }

        private BusinessObjects.Product ConvertToBusinessProduct(DataAccessLayer.Product p)
        {
            if (p == null) return null;

            return new BusinessObjects.Product(
                p.ProductID,
                p.ProductName,
                p.CategoryID ?? 0,
                p.UnitsInStock ?? 0,
                p.UnitPrice ?? 0);
        }

        private List<BusinessObjects.Product> ConvertToBusinessProductList(List<DataAccessLayer.Product> products)
        {
            List<BusinessObjects.Product> result = new List<BusinessObjects.Product>();

            foreach (var p in products)
            {
                result.Add(ConvertToBusinessProduct(p));
            }

            return result;
        }
    }
}
