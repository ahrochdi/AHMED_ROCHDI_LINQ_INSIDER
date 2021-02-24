using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeInsider.Supermarket.Receipt
{
    public class Product
    {
        public decimal Price{ get;set; }
        public String Name { get; set;}

        public Product(String name,decimal price){
            if(price<0){
                throw  new ArgumentException(nameof(price));     
            }
            if(String.IsNullOrWhiteSpace(name)){
                throw  new ArgumentException(nameof(name));                 
            }
            Price=price;
            Name=name;
        }


    }

    public class Cart
    {
           public Dictionary<Product,int> Products{get;private set;}

           public Cart(Dictionary <Product,int> products){
               this.Products=products;
           }
            
            public Cart(){
               this.Products=new Dictionary<Product,int>();
           }
           public void Add(Product p,int quantity){
               if(Products.ContainsKey(p)){
                   Products[p]+=quantity;
               }
               Products.Add(p,quantity);
           }

           public void Delete(Product product){
               int val;
               if(Products.TryGetValue(product , out val)){
                   Products.Remove(product);
               }
           }

           public decimal GetTotal(){
               return Products.Sum(s=> s.Key.Price * s.Value);
           }

    
    
    }

    public class Books
{
   public string ID {get; set;}
   public string Title { get; set; }
   public decimal Price { get; set; }
   public DateTime DateOfRelease { get; set; }

   public static List<Books> GetBooks()
   {
      List<Books> list = new List<Books>();
      list.Add(new Books { ID = "001", 
         Title = "Programming in C#", 
         Price = 634.76m, 
         DateOfRelease = Convert.ToDateTime("2010-02-05") });
     
      list.Add(new Books { ID = "002", 
         Title = "Learn Java in 30 days", 
         Price = 250.76m, 
         DateOfRelease = Convert.ToDateTime("2011-08-15") });
     
      list.Add(new Books { ID = "003", 
         Title = "Programming in ASP.Net 4.0", 
         Price = 700.00m, 
         DateOfRelease = Convert.ToDateTime("2011-02-05") });
     
      list.Add(new Books { ID = "004", 
         Title = "VB.Net Made Easy", 
         Price = 500.99m, 
         DateOfRelease = Convert.ToDateTime("2011-12-31") });
     
      list.Add(new Books { ID = "005", 
         Title = "Programming in C", 
         Price = 314.76m, 
         DateOfRelease = Convert.ToDateTime("2010-02-05") });
     
      list.Add(new Books { ID = "006", 
         Title = "Programming.NET in C++", 
         Price = 456.76m, 
         DateOfRelease = Convert.ToDateTime("2010-02-05") });
     
      list.Add(new Books { ID = "007", 
         Title = "Datebase Developement", 
         Price = 1000.76m, 
         DateOfRelease = Convert.ToDateTime("2010-02-05") });
         
      return list;
   }

    } 

//    public interface IDiscount{
//        public void Apply();
//    }
//
//    public class PercentDiscount : IDiscount{
//
//        public int val{get;set;}
//        public Product product;
//        public PercentDiscount(Product product, int v){
//            this.product=product;
//            this.val=v;
//        }    
//
//        public void Apply(){
//            
//        }
//    }

}
