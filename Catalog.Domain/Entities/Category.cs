using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Domain.Validation;

namespace Catalog.Domain.Entities
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateDomain(name);
        }


        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value");
            Id = id;

            ValidateDomain(name);
        }

        public ICollection<Product> Products { get; set; }

        public void Update(string name)
        {
            ValidateDomain(name);
        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(name), "Invalid name");

            DomainExceptionValidation.When(name.Length < 3, "Invalid name length. Minimum 3 caracters");

            Name = name;
        }       
    }
}