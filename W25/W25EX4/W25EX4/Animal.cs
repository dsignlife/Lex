﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W25EX4
{

    /*Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and 
     * define suitable constructors and methods according to the following rules: all of this are Animals. 
     * Kittens and tomcats are cats. All animals are described by age, name and sex. 
     * 
     * Kittens can be only female and tomcats can be only male. Each animal produce a sound. 
     * Create arrays of different kinds of animals and calculate the average age of each kind of animal using static methods.
     * Create static method in the animal class that identifies the animal by its sound.
*/
     class Animal
    {

        public virtual string AnimalName { get; set; }
        public virtual string AnimalSex { get; set; }
        public virtual int AnimalAge { get; set; }

       public Animal(string animalName, string animalSex, string animnalAge)
        {
            
        }


    }

    class Dog
    {
        
    }

    class Frog
    {
        
    }

    class Cat
    {
        
    }

    class Kitten
    {
        public string fff(string animalName)
        {
            return "F";
        }
    }



}
