using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job testJob;

        Job testJob1;

        Job testJob2;

        Job testJob3;

        Job testJob4;

        [TestInitialize]
        public void CreateJobObject()
        {
            testJob = new Job();
            testJob1 = new Job();
            testJob2 = new Job("Grahams Graphics", new Employer("Michael Graham"), new Location("Fenton, MO"), new PositionType("Graphic Designer"), new CoreCompetency("Design"));
            testJob3 = new Job("Grahams Graphics", new Employer("Michael Graham"), new Location("Fenton, MO"), new PositionType("Graphic Designer"), new CoreCompetency("Design"));
            testJob4 = new Job("Grahams Graphics", new Employer("Michael Graham"), new Location(""), new PositionType(), new CoreCompetency("Design"));
        }

        [TestMethod]
        public void TestSettingJobID()
        {
            Assert.IsFalse(testJob.Id == testJob1.Id);
            Assert.AreEqual(testJob1.Id, testJob.Id + 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(testJob2.Name, "Grahams Graphics");
            Assert.AreEqual(testJob2.EmployerName.Value, "Michael Graham");
            Assert.AreEqual(testJob2.EmployerLocation.Value, "Fenton, MO");
            Assert.AreEqual(testJob2.JobType.Value, "Graphic Designer");
            Assert.AreEqual(testJob2.JobCoreCompetency.Value, "Design");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(testJob2.Equals(testJob3));
        }

        [TestMethod]
        public void ShouldStartAndEnd()
        { 
            string testString = testJob2.ToString();
            Assert.AreEqual(testString[0], testString[testString.Length - 1]);           
        }

        [TestMethod]
        public void TestToString()
        {
            string testString = $"\nID: {testJob2.Id}\n Name: {testJob2.Name}\n Employer: {testJob2.EmployerName.Value}\n Location: {testJob2.EmployerLocation.Value}\n Position Type: {testJob2.JobType.Value}\n Core Competency: {testJob2.JobCoreCompetency.Value}\n";
            Assert.AreEqual(testJob2.ToString(), testString);
        }

        [TestMethod]
        public void TestEmptyOrNull()
        {
            string testString = $"\nID: {testJob4.Id}\n Name: {testJob4.Name}\n Employer: {testJob4.EmployerName.Value}\n Location: Data Not Available\n Position Type: Data Not Available\n Core Competency: {testJob2.JobCoreCompetency.Value}\n";
            Assert.AreEqual(testJob4.ToString(), testString);

        }
    }
}
 