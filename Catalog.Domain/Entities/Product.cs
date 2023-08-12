using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Domain.Validation;

namespace Catalog.Domain.Entities
{
    public sealed class Product : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }

        public Product(string name, string description, decimal price, int stock, string image) 
        {
            ValidateDomain(name, description, price, stock);

            Image = image;
        }

        public Product(int id, string name, string description, decimal price, int stock, string image) 
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value");
            Id = id;

            ValidateDomain(name, description, price, stock);

            Image = image;
        }

        public void Update(string name, string description, decimal price, int stock, string image, int categoryId) 
        {
            ValidateDomain(name, description, price, stock);

            CategoryId = categoryId;
            Image = image;
        }

        private void ValidateDomain(string name, string description, decimal price, int stock)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(name), "Invalid name");

            DomainExceptionValidation.When(name.Length < 3, "Invalid name length. Minimum 3 caracters");

            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(description), "Invalid description");

            DomainExceptionValidation.When(description.Length < 5, "Invalid description length. Minimum 5 caracters");

            DomainExceptionValidation.When(price < 0, "Invalid price value");

            DomainExceptionValidation.When(stock < 0, "Invalid stock value");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
        }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}