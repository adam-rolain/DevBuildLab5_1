using System;
using System.Collections.Generic;

namespace Lab5_1RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // CHARACTERS
            Wizard wizard1 = new Wizard("Voldemort", 82, 99, 75, 82);
            Wizard wizard2 = new Wizard("Harry Potter", 40, 40, 90, 100);
            Wizard wizard3 = new Wizard("Hermoine Granger", 11, 100, 80, 100);
            Warrior warrior1 = new Warrior("Jon Snow", 72, 99, "Sword");
            Warrior warrior2 = new Warrior("Robert Baratheon", 90, 32, "Hammer");
            Warrior warrior3 = new Warrior("Gregor Clegane", 100, 12, "Longsword");

            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            gameCharacters.Add(warrior1);
            gameCharacters.Add(warrior2);
            gameCharacters.Add(wizard1);
            gameCharacters.Add(wizard2);
            gameCharacters.Add(wizard3);

            Console.WriteLine("Welcome to World of Dev.Buildcraft!");

            foreach (GameCharacter character in gameCharacters)
            {
                character.Play();
            }
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
            Console.WriteLine($"\n{pName} (Intelligence: {pIntelligence}, Strength: {pStrength})");
        }
    }

    class MagicUsingCharacter : GameCharacter
    {
        // PRIVATE MEMBERS
        private int pMagicalEnergy;

        //CONSTRUCTORS
        public MagicUsingCharacter(string Name, int Strength, int Intelligence, int MagicalEnergy) : base(Name, Strength, Intelligence)
        {
            SetMagicalEnergy(MagicalEnergy);
        }

        // GETTERS AND SETTERS
        public int GetMagicalEnergy()
        {
            return pMagicalEnergy;
        }
        public void SetMagicalEnergy(int MagicalEnergy)
        {
            if (MagicalEnergy < 0)
            {
                pMagicalEnergy = 0;
            }
            else if (MagicalEnergy > 100)
            {
                pMagicalEnergy = 100;
            }
            else
            {
                pMagicalEnergy = MagicalEnergy;
            }
        }

        // METHODS
        public override void Play()
        {
            Console.WriteLine($"\n{GetName()} (Intelligence: {GetIntelligence()}, Strength: {GetStrength()}, Magic: {pMagicalEnergy})");
        }
    }

    class Wizard : MagicUsingCharacter
    {
        // PRIVATE MEMBERS
        private int pSpellNumber;

        // CONSTRUCTORS
        public Wizard(string Name, int Strength, int Intelligence, int MagicalEnergy, int SpellNumber) : base(Name, Strength, Intelligence, MagicalEnergy)
        {
            SetSpellNumber(SpellNumber);
        }

        // GETTERS AND SETTERS
        public int GetSpellNumber()
        {
            return pSpellNumber;
        }
        public void SetSpellNumber(int SpellNumber)
        {
            if (SpellNumber < 0)
            {
                pSpellNumber = 0;
            }
            else if (SpellNumber > 100)
            {
                pSpellNumber = 100;
            }
            else
            {
                pSpellNumber = SpellNumber;
            }
        }

        // METHODS
        public override void Play()
        {
            Console.WriteLine($"\n{GetName()} (Intelligence: {GetIntelligence()}, Strength: {GetStrength()}, Magic: {GetMagicalEnergy()}) {pSpellNumber} spells");
        }
    }

    class Warrior : GameCharacter
    {
        // PRIVATE MEMBERS
        private string pWeaponType;

        // CONSTRUCTORS
        public Warrior(string Name, int Strength, int Intelligence, string WeaponType) : base(Name, Strength, Intelligence)
        {
            SetWeaponType(WeaponType);
        }

        // GETTERS AND SETTERS
        public string GetWeaponType()
        {
            return pWeaponType;
        }
        public void SetWeaponType(string WeaponType)
        {
            if (!String.IsNullOrEmpty(WeaponType))
            {
                pWeaponType = WeaponType;
            }
            else
            {
                pWeaponType = "EMPTY";
            }
        }

        // METHODS
        public override void Play()
        {
            Console.WriteLine($"\n{GetName()} (Intelligence: {GetIntelligence()}, Strength: {GetStrength()}) {pWeaponType}");
        }
    }
}
