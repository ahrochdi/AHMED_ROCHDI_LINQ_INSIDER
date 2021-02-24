using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

//using NFluent;

namespace Exo
{
    /*
     * La méthode suivante permet de calculer l'aire d'un carré.
     * Le but de cet exercice est d'écrire un (ou plusieurs !) test(s) permettant de valider le bon fonctionnement de cette méthode :
     * Pour information, ce projet contient Xunit, et NFluent ;)
     */
    public class Exo
    {
        public static int SquareArea(int side)
        {
            if (side < 0)
                throw new ArgumentException(nameof(side));

            return side * side;
        }

        
         
    }

    public class Guitar
    {
        private string _brand { get; }
        public string Model { get; }

        public string Color { get; }

        public Guitar(string brand, string model, string color)
        {
            _brand = brand;
            Model = model;
            Color = color;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
                 {
                      return false;
                  }
             else {
            Guitar guitar= (Guitar) obj;
            return _brand.Equals(guitar._brand) && Model.Equals(guitar.Model);
             }
        }
    }

    public struct Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"X: {X}, Y: {Y}";
    }

    public class Valeur
    {

        /*
         * Attention, il ne faut pas modifier le type de retour de cette méthode : ce-dernier doit rester à void  !
         */
        public void GoToLeft(ref Coordinates coordinates)
        {
            --coordinates.X;
        }
    }



     public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
    public class LinkedList<T>
    {
        public static Node<T> From(params T[] elements)
        {
            return From((IEnumerable<T>)elements);
        }
        public static Node<T> From(IEnumerable<T> elements)
        {
            return new Node<T>
            {
                Value = elements.First(), 
                Next = elements.Skip(1).Any() ? From(elements.Skip(1)) : null
            };
        }
    }

     public class LinqExercice
    {
      

        public  IEnumerable<string> Sorted(IEnumerable<string> toSort)
        {
            
            return toSort.OrderBy(q => q).Select(s=>ToUpperCase(s));
        }

        private String ToUpperCase(String fullName){
            var splittedName=fullName.Split(' ');
            var firstName=splittedName[0].ToUpper();
            var secondName=fullName[1];
            return null;
        }

       
    }

    public class Vehicule{
        private String _typeName;
        public Vehicule(String type){
            _typeName=type;
        }

        public void Action(String action)
        {
            Console.WriteLine(_typeName+"."+action+"()");
        }


    }
    
}