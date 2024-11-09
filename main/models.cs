public class Product{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
}

public class Customer{
    public int Id {get; set;}
    public string Name { get; set; }
}

public class Store{
    public static List<Product> products= new List<Product>();
}