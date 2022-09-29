namespace HumanInfoApplication.Domains
{
    public class Human
    {
        public int HumanID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public Human(int humanId,string name, string surname, DateTime birthDate)
        {
            HumanID = humanId;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }
    }
}
