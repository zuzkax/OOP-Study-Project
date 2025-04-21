using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.BLL
{
    public abstract class Animal
    {
        public string FoodType { get; protected set; }
        public int NumLegs { get; protected set; }
        public string Origin { get; protected  set; }
        public string Spicies { get; protected set; }


        public Animal(string foodType, int numLegs, string origin, string spicies)
        {
            FoodType = foodType;
            NumLegs = numLegs;
            Origin = origin;
            Spicies = spicies;
        }

        public virtual string ToString()
        {
            return $"Animall | Food Type: {FoodType}, Number of Legs: {NumLegs}, Origin: {Origin}, Spicies: {Spicies} ";
        }
    }
}
