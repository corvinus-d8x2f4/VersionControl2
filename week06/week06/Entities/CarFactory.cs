﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week06.Abstractions;

namespace week06.Entities
{
    public class CarFactory : IToyFactory
    {
        public Abstraction.Toy CreateNew()
        {
            return new Car();
        }
    }
}
