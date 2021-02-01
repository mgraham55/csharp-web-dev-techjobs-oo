using System;
using System.Collections.Generic;

namespace TechJobsOO
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

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, object employerName, object employerLocation, object jobType, object jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = (Employer)employerName;
            EmployerLocation = (Location)employerLocation;
            JobType = (PositionType)jobType;
            JobCoreCompetency = (CoreCompetency)jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Name))
            {
                Name = "Data Not Available";
            }
            if (string.IsNullOrEmpty(EmployerName.Value))
            {
               EmployerName.Value = "Data Not Available";
            }
            if (string.IsNullOrEmpty(EmployerLocation.Value))
            {
                EmployerLocation.Value = "Data Not Available";
            }
            if (string.IsNullOrEmpty(JobType.Value))
            {
                JobType.Value = "Data Not Available";
            }
            if (string.IsNullOrEmpty(JobCoreCompetency.Value))
            {
                JobCoreCompetency.Value = "Data Not Available";
            }
            return $"\nID: {Id}\n Name: {Name}\n Employer: {EmployerName.Value}\n Location: {EmployerLocation.Value}\n Position Type: {JobType.Value}\n Core Competency: {JobCoreCompetency.Value}\n";
        }
    }
}
