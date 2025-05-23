﻿namespace eCommerce.Models
{
    public class Product
    {
        public required string Id { get; set; }

        public required string Name { get; set; }

        public double Price { get; set; }

        public required string Photo { get; set; }
    }
}