using SecondApplication.Domains;

namespace SecondApplication.Repository
{
    public class HumanStorage
    {
        private Dictionary<int, Human> Humans { get; } = new Dictionary<int, Human>();

        public void Create(Human human)
        {
            Humans.Add(human.HumanID, human);
        }

        public Human Read(int ID)
        {
            return Humans[ID];
        }

        public Human Update(int ID, Human newHuman)
        {
            Humans[ID] = newHuman;
            return Humans[ID];
        }

        public bool Delete(int ID)
        {
            return Humans.Remove(ID);
        }

    }
}
