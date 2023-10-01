using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.

        //begin my changes
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        //end my changes

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.
        
        //begin my changes
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }


        //end my changes

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            List<string> properties = new List<string> {Convert.ToString(this.Id), this.Name, Convert.ToString(this.EmployerName), Convert.ToString(this.EmployerLocation), Convert.ToString(this.JobType), Convert.ToString(this.JobCoreCompetency)};
            List<string> labels = new List<string> { "ID: ", "Name: ", "Employer: ", "Location: ", "Position Type: ", "Core Competency: " };
            string stringToReturn = "";
            stringToReturn = stringToReturn + Environment.NewLine;
            for (int i = 0; i < properties.Count; i++)
            {
                stringToReturn = stringToReturn + labels[i];
                if (properties[i]!=null)
                {
                    stringToReturn = stringToReturn + properties[i] + Environment.NewLine;
                }
                else
                {
                    stringToReturn = stringToReturn + "Data not available" + Environment.NewLine;
                }
            }
            stringToReturn = stringToReturn + Environment.NewLine;
            return stringToReturn;
            //return Environment.NewLine+ "ID: " + this.Id + Environment.NewLine + "Name: " + this.Name + Environment.NewLine + "Employer: " + this.EmployerName + Environment.NewLine + "Location: " + this.EmployerLocation + Environment.NewLine + "Position Type: " + this.JobType + Environment.NewLine + "Core Competency: " + this.JobCoreCompetency + Environment.NewLine;
        }








    }
}

