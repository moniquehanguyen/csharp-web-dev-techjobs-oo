using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTest
    {
        Employer acme = new Employer("ACME");
        Location desert = new Location("Desert");
        PositionType qualityControl = new PositionType("Quality control");
        CoreCompetency persistence = new CoreCompetency("Persistence");

        [TestMethod]
        public void TestSettingJobId()
        {
           Job idTest = new Job();
           Job idTest2 = new Job();
           int difference = idTest2.Id - idTest.Id;

           Assert.IsFalse(idTest.Id == idTest2.Id);
           Assert.AreEqual(1, difference);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job productTester = new Job("Product tester", acme, desert, qualityControl, persistence);
            Assert.AreEqual(1, productTester.Id);
            Assert.AreEqual("Product tester", productTester.Name);
            Assert.AreEqual(acme, productTester.EmployerName);
            Assert.AreEqual(desert, productTester.EmployerLocation);
            Assert.AreEqual(qualityControl, productTester.JobType);
            Assert.AreEqual(persistence, productTester.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job productTester = new Job("Product tester", acme, desert, qualityControl, persistence);
            Job productTester2 = new Job("Product tester", acme, desert, qualityControl, persistence);
            Assert.IsFalse(productTester.Equals(productTester2));
        }
    }
}
