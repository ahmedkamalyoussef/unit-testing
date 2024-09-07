using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections;
using UnitTesting;

namespace Tests
{
    [TestFixture]
    public class EmployeeTest
    {
        Employee employee;

        [SetUp]
        public void SetUp()
        {
            employee = new Employee();
        }

        //[Test]
        //[TestCase(60, true)]
        //[TestCase(70, true)]
        //[TestCase(40, false)]
        //public void IsSeniorTest(int age, bool expectedValue)
        //{
        //    var result = employee.IsSenior(age);
        //    Assert.That(result, Is.EqualTo(expectedValue));
        //}


        //[Test]
        //[TestCase(60, ExpectedResult = true)]
        //[TestCase(70, ExpectedResult = true)]
        //[TestCase(40, ExpectedResult = false)]
        //public bool IsSeniorTest(int age)
        //{
        //    return employee.IsSenior(age);
        //}


        [Test]
        [TestCaseSource(typeof(TestData))]
        public bool IsSeniorTest(int age)
        {
            return employee.IsSenior(age);
        }

        public class TestData : IEnumerable<TestCaseData>
        {
            public IEnumerator<TestCaseData> GetEnumerator()
            {
                //yield return new TestCaseData(50).Returns(false);
                //yield return new TestCaseData(60).Returns(true);
                //yield return new TestCaseData(80).Returns(true);

                StreamReader stream = new StreamReader("D:\\Visual studio\\UnitTesting\\Tests\\EmployeesData.json");
                string json = stream.ReadToEnd();
                List<EmployeeData> employees = JsonConvert.DeserializeObject<List<EmployeeData>>(json);
                foreach (var employee in employees)
                {
                    yield return new TestCaseData(employee.Age).Returns(employee.ExpectedValue);
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
