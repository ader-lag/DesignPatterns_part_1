using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildersDPatterns
{
    public class ProductStockReportBuilder:IProductStockReportBuilder
    {
        private ProductStockReport _productStockReport;
        private IEnumerable<Product> _products;

        public ProductStockReportBuilder(IEnumerable<Product> products)
        {
            _products = products;
            _productStockReport = new ProductStockReport();
        }

        public void BuildHeader()
        {
            _productStockReport.HeaderPart = $"Reporte de stock de los producto en la fecha: {DateTime.Now}\n";
        }

        public void BuildBody()
        {
            _productStockReport.BodyPart = string.Join(Environment.NewLine,
                _products.Select(p => $"Nombre del producto: {p.ProductName}, Precio: {p.ProductPrice} bs"));
        }

        public void BuildFooter()
        {
            _productStockReport.FooterPart = "\nInforme proporcionado por la empresa GRIDY.";
        }

        public ProductStockReport GetReport()
        {
            var productStockReport = _productStockReport;
            Clear();
            return productStockReport;
        }

        private void Clear() => _productStockReport = new ProductStockReport();
    }
}
