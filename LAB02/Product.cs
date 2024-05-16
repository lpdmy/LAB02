namespace LAB02
{
    //Exercise 1
    public class Product
    {
        private string _name;
        private double _price;
        private double _discount;

        //Exercise 4
        public string ProductName { 
            get => _name;
            set => _name = value; }
        public double Price { 
            get => _price; 
            set => _price = value;
        }
        public double Discount { 
            get => _discount;
            set => _discount = value;
        }

        public Product(string name, double price, double discount) {
            _name = name;
            _price = price;
            _discount = discount;
        }

        public Product(string name, double price)
        {
            _name = name;
            _price = price;
            _discount = 0;
        }

        public Product() { }
        private double getImportTax()
        {
            return Price * 0.1;
        }

        public void display()
        {
            Console.WriteLine($"{ProductName} : Price: {Price} - Discount: {Discount} - Tax : {getImportTax()}");
        }
        
        public static Product input()
        {
            Console.WriteLine("Input a product please: ");
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter Discount: ");
            double discount = double.Parse(Console.ReadLine());
            return new Product()
            {
                ProductName = name,
                Price = price,
                Discount = discount
            };
        }
    }
}
