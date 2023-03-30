using Course.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("TV", 900.00));
        list.Add(new Product("Notebook", 1200.00));
        list.Add(new Product("Tablet", 450.00));

        // Way 1 to do this, without lambda
        // Comparison<Product> comp = CompareProducts;

        // Declaring anonymous function (lambda)
        //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

        // Or list.Sort(CompareProducts);
        list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

        foreach (Product product in list)
        {
            Console.WriteLine(product);
        }
    }

    /*
     * We'll do function lambda
    static int CompareProducts(Product p1, Product p2)
    {
        return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
    }
    */

}