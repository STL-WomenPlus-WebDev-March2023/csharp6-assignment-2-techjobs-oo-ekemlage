using System;
namespace TechJobsOOAutoGraded6
{
	public class CoreCompetency : JobField
	{
        //public CoreCompetency() : base()
        //{
        //}

        public CoreCompetency(string value) : base(value)
        {
        }
        /*
        public int Id {  get; set; } //removed ; added {get set} // made id uppercase //made public
        private static int nextId = 1;
        public string Value { get; set; } //made public, removed ; added {get set} //made value uppercase

        // TODO: Task 2: Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
            Id = nextId; //made id uppercase
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v; //made value uppercase
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id; //made id uppercase
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id); //made id uppercase
        }

        public override string ToString()
        {
            return Value; //made value uppercase
        }
        */
    }
}

