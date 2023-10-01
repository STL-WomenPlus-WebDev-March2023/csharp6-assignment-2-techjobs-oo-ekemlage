
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.Metrics;

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
            Assert.AreEqual(job3.JobCoreCompetency.Value, "Persistence", "JobCoreCompetency incorrect");

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Equals(job2),"Equals returned true when it should have returned false.");
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job4.ToString().StartsWith("\n"),"String does not start with new line.");
            Assert.IsTrue(job4.ToString().EndsWith("\n"),"String does not end with new line.");
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            List<string> labels = new List<string> { "ID","Name","Employer","Location","Position Type","Core Competency"};
            for(int i = 0; i < labels.Count; i++)
            {
                Assert.IsTrue(job3.ToString().Contains(labels[i]), "Does not contain the label: " + labels[i]);
            }

            List<string> data = new List<string> {Convert.ToString(job3.Id), job3.Name , Convert.ToString(job3.EmployerName), Convert.ToString(job3.EmployerLocation) , Convert.ToString(job3.JobType) , Convert.ToString(job3.JobCoreCompetency) };
            for (int i = 0; i < data.Count; i++)
            {
                Assert.IsTrue(job3.ToString().Contains(data[i]), "Does not contain the data: " + data[i]);
            }
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.IsTrue(job1.ToString().Contains("Data not available"), "The message 'Data not available' is not printed when necesarry.");
            Assert.IsFalse(job3.ToString().Contains("Data not available"), "The message 'Data not available' is unnecesarry and should not be printed.");

        }
    }
}

