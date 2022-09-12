namespace WebApplication.Domains
{
    public class Human
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public Human(int id,string name, string surname, DateTime birthDate)
        {
            ID = id;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }
    }
}
