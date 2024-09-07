using NUnit.Framework;
using NUnit.Framework.Internal;
using UnitTesting;

namespace Tests
{
    [TestFixture]
    public class ProductTest
    {
        private Product product;

        [SetUp]//تشتغل قبل كل تيست كيس
        public void SetUp()
        {
            product = new Product();
            product.Id = 10;

        }

        [TearDown]//تشتغل بعد كل تيست كيس
        public void Dispose()
        {
            product.Name = null;
        }
        [OneTimeSetUp]//تشتغل قبل كل الكيسيس مره واحده
        public void OneTimeSetUp()
        {
            product = new Product();
            product.Id = 10;
        }

        [OneTimeTearDown]//تشتغل بعد كل الكيسيس مره واحده
        public void OneTimeDispose()
        {
            product.Id = 20;
        }
        [Test]
        public void TestNameProperty()
        {
            product.Name = "ahmed";
            //Assert.That(product, Has.Property("Name"));
            Assert.That(product.Name, Is.Not.Null.And.Not.Empty);

        }

        [Test]
        [Category("Id test")]
        public void TestIdProperty()
        {
            //product.Id = 10;

            //Assert.That(product, Has.Property("Name"));
            Assert.That(product.Id, Is.EqualTo(10));

        }
    }
}
