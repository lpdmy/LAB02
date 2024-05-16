namespace LAB02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2
            Product p1 = Product.input();
            Product p2 = Product.input();
            p1.display();
            p2.display();


            //Exercise 3
            Product p3 = new Product("Macbook Pro", 1000, 0.10);
            Product p4 = new Product("Iphone 15", 999);
            p3.display();
            p4.display();
        }
    }
}
