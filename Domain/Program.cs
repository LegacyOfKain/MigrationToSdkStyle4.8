using CleanArchitecture.Common.Dates;
using CleanArchitecture.Domain.Products;
using CleanArchitecture.Domain.Sales;
using System;

namespace CleanArchitecture.Domain
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("jkjkj");



            var _sale = new Sale();

            _sale.UnitPrice = 89;
            _sale.Product = new Product();
            _sale.Product.Name = new DateService().GetDate().ToString();

            Console.WriteLine(_sale.Product.Name);

            Console.ReadKey();
        }
    }
}
