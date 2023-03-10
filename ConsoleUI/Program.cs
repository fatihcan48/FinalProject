using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CategoryTest();

            ProductTest();
             
            Console.ReadKey();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var item in categoryManager.GetAll().Data)
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            if (productManager.GetAll().Success==true)
            {
                Console.WriteLine(productManager.GetAll());
                foreach (var item in productManager.GetAll().Data)
                {
                    Console.WriteLine("{0} ---- {1}", item.ProductName, item.UnitPrice);
                }
            }
            else
                Console.WriteLine(productManager.GetAll());
        }
    }
}