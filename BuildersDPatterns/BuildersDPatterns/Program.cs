using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildersDPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
        {
            new Product { ProductName = "Monitor", ProductPrice = 1200.50 },
            new Product { ProductName = "Mouse", ProductPrice = 150.41 },
            new Product { ProductName = "Teclado", ProductPrice = 700.15}
        };

            var builder = new ProductStockReportBuilder(products);
            var director = new ProductStockReportDirector(builder);
            director.BuildStockReport();

            var report = builder.GetReport();
            Console.WriteLine(report);

            Console.ReadKey();
        }
    }
}
