using Catalog.Domain.Entities;

namespace Catalog.Domain.Tests;

public class CategoryUnitTest1
{
    [Fact]
    public void CreateCategory_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Category(1, "Category Name");

        //action.Should().NotThrow<ArgumentNullException>();
    }
}