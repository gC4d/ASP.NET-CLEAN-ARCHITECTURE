using CleanArch.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "Create a product with valid parameters")]
        public void CreateProduct_WithValidParameters_ResultInValidObject() 
        {
            Action action = () => new Product(1, "Produto", "Produto 1", 10, 10, "Image Name");
            action.Should()
                .NotThrow<Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create a product with invalid id value")]
        public void CreateProduct_WithInvalidIdValue_ResultInDomainException()
        {
            Action action = () => new Product(-1, "Produto", "Produto 1", 10, 10, "Image Name");
            action.Should()
                .Throw<Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("Invalid Id value");
        }

        [Fact(DisplayName = "Create a product with a null image parameter")]
        public void CreateProduct_WithNullImageValue_ResultInNotThrowDomainExceptionValidation()
        {
            Action action = () => new Product(1, "Produto", "Produto 1", 9.99m, 10, null);
            action.Should()
                .NotThrow<Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create a product with a null image parameter expecting not throw a null reference exception")]
        public void CreateProduct_WithNullImageValue_NotResultInANullReferenceException()
        {
            Action action = () => new Product(1, "Produto", "Produto 1", 9.99m, 10, null);
            action.Should()
                .NotThrow<NullReferenceException>();
        }

    }
}
