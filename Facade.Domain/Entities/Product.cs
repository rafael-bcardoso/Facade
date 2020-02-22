﻿using System;

namespace Facade.Domain.Entities
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public void AddPrice(decimal price)
        {
            this.Price = price;
        }

        public void AlterPrice(decimal price)
        {
            this.Price = price;
        }
    }
}
