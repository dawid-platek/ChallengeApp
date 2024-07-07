namespace ChallengeApp
{
    public abstract class Person // klasa abstrakcyjna
    {
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
