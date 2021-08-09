using System;

namespace Lab5_1RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // TESTING GAMECHARACTER CLASS
            GameCharacter character1 = new GameCharacter("Voldemort", 82, 99);
            character1.Play();
            GameCharacter character2 = new GameCharacter("Harry Potter", -10, 50);
            character2.Play();
            GameCharacter character3 = new GameCharacter("Hermoine Granger", -50, 101);
            character3.Play();
            GameCharacter character4 = new GameCharacter(null , -10, 50);
            character4.Play();
        }
    }

    class GameCharacter
    {
        // PRIVATE MEMBERS
        private string pName;
        private int pStrength;
        private int pIntelligence;

        // CONSTRUCTORS
        public GameCharacter(string Name, int Strength, int Intelligence)
        {
            SetName(Name);
            SetStrength(Strength);
            SetIntelligence(Intelligence);
        }

        // GETTERS AND SETTERS
        public string GetName()
        {
            return pName;
        }

        public void SetName(string Name)
        {
            if (!String.IsNullOrEmpty(Name))
            {
                pName = Name;
            }
            else
            {
                pName = "EMPTY";
            }
        }
        public int GetStrength()
        {
            return pStrength;
        }

        public void SetStrength(int Strength)
        {
            if (Strength < 0)
            {
                pStrength = 0;
            }
            else if (Strength > 100)
            {
                pStrength = 100;
            }
            else
            {
                pStrength = Strength;
            }
        }
        public int GetIntelligence()
        {
            return pIntelligence;
        }
        public void SetIntelligence(int Intelligence)
        {
            if (Intelligence < 0)
            {
                pIntelligence = 0;
            }
            else if (Intelligence > 100)
            {
                pIntelligence = 100;
            }
            else
            {
                pIntelligence = Intelligence;
            }
        }

        // METHODS
        public virtual void Play()
        {
            Console.WriteLine($"\n{pName}(Intelligence: {pIntelligence}, Strength: {pStrength}");
        }
    }
}
