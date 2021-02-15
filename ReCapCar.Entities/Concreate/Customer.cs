﻿using ReCapCar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.Entities.Concreate
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
