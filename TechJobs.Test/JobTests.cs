
namespace TechJobs.Tests
{
    [TestClass]
	public class JobTests
	{
        //Testing Objects
        //begin changes
        Job job1 = new Job();
        Job job2 = new Job();
        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //end changes
        //initalize your testing objects here

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsTrue(job1.Id!=job2.Id, "The two job's Ids match. Each job should have a unique Id.");
            Assert.IsTrue(job2.Id - job1.Id == 1, "Id's are not incremented by 1.");
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job3.Name,"Product tester", "Name incorrect");
            Assert.AreEqual(job3.EmployerName.Value,"ACME", "EmployerName incorrect");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert", "EmployerLocation incorrect");
            Assert.AreEqual(job3.JobType.Value, "Quality control", "JobType incorrect");
            Assert.AreEqual(job3.JobCoreCompetency.value, "Persistence", "JobCoreCompetency incorrect");

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Equals(job2),"Equals returned true when it should have returned false.");
        }
    }
}

