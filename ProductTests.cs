using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace CodeInsider.Supermarket.Receipt.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Should_Not_Accept_Empty_Products()
        {
            var product=new Product("Apple",2);
            var cart = new Cart();
            Assert.Throws<ArgumentException>(()=>new Product("test",-1));
            Assert.Throws<ArgumentException>(()=>new Product("",1));
            Assert.Throws<ArgumentException>(()=>new Product("  ",1));
            Assert.Throws<ArgumentException>(()=>new Product(null,1));
            
            

        }
         [Fact]
        public void Should_Add_Product()
        {

            var product=new Product("Apple",2);
            var cart = new Cart();

            Assert.Equal(0,cart.Products.Count);                   
            

            cart.Add(product,3);
            Assert.Equal(1,cart.Products.Count);                   
            Assert.Equal(3,cart.Products[product]);

            var productTwo= new Product("orange",4);
            cart.Add(productTwo,6);
            Assert.Equal(2,cart.Products.Count);                   
            Assert.Equal(6,cart.Products[productTwo]);
            Assert.Equal(3,cart.Products[product]);

        }

        
         [Fact]
        public void Should_Delete_If_Found_Product()
        {
            var product=new Product("Apple",2);
            var cart = new Cart();

            Assert.Equal(0,cart.Products.Count);                   
            

            cart.Add(product,3);
            Assert.Equal(1,cart.Products.Count);                   
            Assert.Equal(3,cart.Products[product]);

            cart.Delete(product);

            Assert.Equal(0,cart.Products.Count);                   


            
            //Assert.Throws<ParameterizedKeyNotFoundException<Product>>(()=>cart.Delete(product));        
        }

        [Fact]
        public void Should_Affiche_Receipt()
        {
            var cart = new Cart();
            cart.Add(new Product("Apple",10),16);
            cart.Add(new Product("Banana",10),4);
            //cart.Add(new Product("Tea",19),1);
            //cart.Add(new Product("Apple",3),1);
                
            Assert.Equal(200,cart.GetTotal());



        }
    
        [Fact]
        public void Discount_Test()
        {
            List<Books> books = Books.GetBooks();
            var booktitles = from b in books 
            where b.Price>500
            select b.Title;
            Assert.Equal(2,booktitles.Count());
        }
        
    }
    
}