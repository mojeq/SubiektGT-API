using FluentAssertions;
using NUnit.Framework;
using SubiektGT_API.Services;

namespace SubiektGT_API.Tests
{
    public class ProductServiceTests
    {
        [Test]
        public void GetAllProducts_WhenCalled_ShouldProductsListFromSubiektIsNotNull()
        {
            ProductService product = new ProductService();

            var productsList = product.GetAllProducts();

            productsList.Should().NotBeEmpty();
        }
    }
}