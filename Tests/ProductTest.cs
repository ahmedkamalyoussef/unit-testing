using NUnit.Framework;
using UnitTesting;

namespace Tests
{
    [TestFixture]
    public class ProductTest
    {
        [Test]
        public void TestNameProperty()
        {
            Product product = new Product();
            product.Name = "ahmed";
            //Assert.That(product, Has.Property("Name"));
            Assert.That(product.Name, Is.Not.Null.And.Not.Empty);

        }
    }
}
