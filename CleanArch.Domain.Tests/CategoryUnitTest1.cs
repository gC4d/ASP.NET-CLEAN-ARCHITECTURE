using CleanArch.Domain.Entities;
using FluentAssertions;

namespace CleanArch.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName = "Create category with valid state")]
        public void Createcategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }
        [Fact(DisplayName = "Create category with a negative id value")]
        public void Createcategory_WithNegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(-1, "Category Name");
            action.Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("Invalid Id value");
        }
        
        [Fact(DisplayName = "Create category with short name value")]
        
        public void Createcategory_WithShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Category(1, "Cn");
            action.Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("Invalid name. too short, minimum 3 characters");
        }

        [Fact(DisplayName = "Create category without name value")]

        public void Createcategory_WithoutNameValue_DomainExceptionMissingName()
        {
            Action action = () => new Category(1, "");
            action.Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("Invalid name. Name is required");
        }
    }
}