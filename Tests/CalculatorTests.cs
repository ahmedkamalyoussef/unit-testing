using NUnit.Framework;
using UnitTesting;
namespace Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddIntTestPositiveNumbers()
        {
            //AAA


            //Arrange =>   حدد ال obj اللي هشتغل عليه

            Calculator caculator = new Calculator();


            //Act => هعمل تيست علي انهي ميثود

            var result = caculator.AddInt(5, 15);

            //Assert => apply the test case

            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void DivDoubleTest()
        {
            Calculator caculator = new Calculator();
            var result = caculator.DivDouble(1, 3);

            Assert.That(result, Is.EqualTo(0.33).Within(0.004)/*.Percent*/);
        }
        [Test]
        public void DivByZeroTest()
        {
            Calculator caculator = new Calculator();
            //Assert.Throws<DivideByZeroException>(() =>
            //{
            //    caculator.DivDouble(5, 0);
            //});

            Assert.That(() => caculator.DivDouble(2, 0), Throws.TypeOf<DivideByZeroException>());
        }
        [Test]
        public void TestCollection()
        {
            var names = new string[] { "Ali", "Ahmed", "Kamal", "Youssef", "Kamal" };
            //Assert.That(names, Has.Length.EqualTo(5));
            //Assert.That(names, Has.Exactly(5).Items);
            //Assert.That(names,Is.Unique);
            //Assert.That(names, Is.Empty, "not empty");
            //Assert.That(names, Does.Contain("Ahmed"));
            //Assert.That(names, Has.Exactly(2).EqualTo("KAMAL").IgnoreCase.And.Exactly(1).EqualTo("Ahmed"));
            //Assert.That(names, Has.Exactly(2).Matches<string>(s => s.Contains("Ka")));
            Assert.That(names, Has.Exactly(1).Matches<string>(s => s.Length == 3));
        }
    }
}
