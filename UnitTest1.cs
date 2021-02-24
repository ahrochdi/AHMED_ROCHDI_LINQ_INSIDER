using System;
using Xunit;


namespace Exo.Tests
{
    public class UnitTest1
    {
       [Fact]
        public void Test1()
        {
                Assert.Equal(0,Exo.SquareArea(0));
                Assert.Equal(16,Exo.SquareArea(4));
                Assert.Throws<ArgumentException>(()=>Exo.SquareArea(-1));
        }

         [Fact]
        public void Should_Be_The_Same_Guitars()
        {
            Guitar redStrato = new Guitar("Fender", "stratocaster", "red");
            Guitar blueStrato = new Guitar("Fender", "stratocaster", "blue");

           Assert.Equal(redStrato,blueStrato);
        }

        
        [Fact]
        public void Should_Go_Left()
        {
            var coordinates = new Coordinates(8,5);

            new Valeur().GoToLeft(ref coordinates);

            Assert.Equal(coordinates,new Coordinates(7,5));
        }


        [Fact]
        public void Should_Contains_Integer_Elements()
        {
            var elements = LinkedList<int>.From(1, 2, 3, 4, 5);

            //Check.That(elements.Value).Equals(1);
            //Check.That(elements.Next.Value).Equals(2);
            Assert.Equal(elements.Value,1);            
            Assert.Equal(elements.Next.Value,2);

        }

        [Fact]
        public void Should_Contains_String_Elements()
        {
            var elements = LinkedList<String>.From("1", "2", "3", "4", "5");
            Assert.Equal(elements.Value,"1");            
            Assert.Equal(elements.Next.Value,"2");
        }

        [Fact]
        public void Should_Sort_Names()
        {
            var names = new[] { "Liskov Barbara", "Fowler Martin", "Hopper Grace", "Feathers Michael", "Larsen Diana", "Mancuso Sandro", "Evans Eric", "Derby Esther" };
            var sortedNames= new LinqExercice().Sorted(names);
           // Assert.Equal("EVANS Eric",sortedNames.ElementAt(0));
           // Check.That(Sorted(names)).ContainsExactly("DERBY Esther", "EVANS Eric", "FEATHERS Michael", "FOWLER Martin", "HOPPER Grace", "LARSEN Diana", "LISKOV Barbara", "MANCUSO Sandro");

            
        }


    }
}
