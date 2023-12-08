﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Dog:Animal
    { 
        

        public Dog(string name, string favoredFood) : base(name, favoredFood)
        {
            
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "\nBORK";
        }
    }
}
