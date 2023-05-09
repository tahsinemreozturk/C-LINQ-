using Business.Concrete;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new InMemoryProductDal());

        foreach (var prodcut in productManager.GetAll())
        {
            Console.WriteLine(prodcut.ProductName);
        }

        
    }
}