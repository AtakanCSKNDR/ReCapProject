using ReCapCar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.Entities.Concreate
{
    public class Color :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
